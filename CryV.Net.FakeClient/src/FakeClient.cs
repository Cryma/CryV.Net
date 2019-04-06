using System;
using System.Numerics;
using System.Threading;
using System.Threading.Tasks;
using CryV.Net.Shared.Events.Types;
using CryV.Net.Shared.Payloads;
using CryV.Net.Shared.Payloads.Partials;
using LiteNetLib;
using EventHandler = CryV.Net.Shared.Events.EventHandler;

namespace CryV.Net.FakeClient
{
    public class FakeClient
    {

        public Client Client { get; }

        private CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();

        public FakeClient()
        {
            EventHandler.Subscribe<NetworkEvent<BootstrapPayload>>(OnBootstrap);

            Client = new Client(this);
        }

        private void OnBootstrap(NetworkEvent<BootstrapPayload> obj)
        {
            Dummy.LocalId = obj.Payload.LocalId;
            Dummy.Position = obj.Payload.StartPosition;
            Dummy.Heading = obj.Payload.StartHeading;

            Console.WriteLine("Received bootstrap!");
        }

        public void HandleCommand(string command)
        {
            if (string.IsNullOrWhiteSpace(command))
            {
                return;
            }

            var commandArray = command.Split(' ');
            var commandName = commandArray[0];

            if (commandName == "quit")
            {
                Environment.Exit(0);
            }
            else if (commandName == "circle")
            {
                DoCircle(Convert.ToInt32(commandArray[1]), Convert.ToSingle(commandArray[2]), Convert.ToInt32(commandArray[3]));
            }
            else if (commandName == "go")
            {
                DoGo(Convert.ToSingle(commandArray[1]), Convert.ToSingle(commandArray[2]), Convert.ToInt32(commandArray[3]));
            }
            else if (commandName == "connect")
            {
                Client.Connect(commandArray[1], Convert.ToInt32(commandArray[2]));

                Console.WriteLine("Connected");
            }
            else if (commandName == "disconnect")
            {
                Client.Disconnect();

                Console.WriteLine("Disconnected");
            }
            else if (commandName == "stop")
            {
                _cancellationTokenSource.Cancel();

                _cancellationTokenSource = new CancellationTokenSource();
            }
            else
            {
                Console.WriteLine("Command not found");
            }
        }

        private void DoGo(float heading, float speed, int moveSpeed)
        {
            var velocity = new Vector3(0.0f, speed, 0.0f);
            var direction = Quaternion.CreateFromAxisAngle(new Vector3(0.0f, 0.0f, 1.0f), (float) (heading * Math.PI / 180));
            var directionVelocity = Vector3.Transform(velocity, direction);

            var interval = 1000.0f / 100.0f;
            var step = directionVelocity / interval;

            Dummy.Heading = heading;
            Dummy.Velocity = directionVelocity;

            Task.Run(async () =>
            {
                while (_cancellationTokenSource.IsCancellationRequested == false)
                {
                    var position = Dummy.Position;

                    position.X += step.X;
                    position.Y += step.Y;
                    position.Z += step.Z;

                    Client.Send(new ClientUpdatePayload(Dummy.LocalId, position, directionVelocity, heading, moveSpeed), DeliveryMethod.Unreliable);

                    Dummy.Position = position;

                    await Task.Delay(TimeSpan.FromMilliseconds(100), _cancellationTokenSource.Token);
                }
            }, _cancellationTokenSource.Token);
        }

        private void DoCircle(int interval, float radius, int moveSpeed)
        {
            var center = Dummy.Position;
            var timeStep = (float) (0.5 * Math.PI / 6);

            var deltaTime = 1000 / interval;

            Task.Run(async () =>
            {
                float timeCounter = 0;
                while (_cancellationTokenSource.IsCancellationRequested == false)
                {
                    timeCounter += 0.1f;
                    var position = center;

                    var dx = (float) Math.Sin(timeCounter * timeStep) * radius;
                    var dy = (float) Math.Cos(timeCounter * timeStep) * radius;

                    position.X += dx;
                    position.Y += dy;

                    Client.Send(new ClientUpdatePayload(Dummy.LocalId, position, new Vector3(dx * deltaTime, dy * deltaTime, 0.0f), 0.0f, moveSpeed), DeliveryMethod.Unreliable);

                    Dummy.Position = position;

                    await Task.Delay(TimeSpan.FromMilliseconds(interval), _cancellationTokenSource.Token);
                }
            }, _cancellationTokenSource.Token);
        }

        public void Tick()
        {
            Client?.Tick();
        }

    }
}
