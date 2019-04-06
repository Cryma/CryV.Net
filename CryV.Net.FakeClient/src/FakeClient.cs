using System;
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
                DoCircle(Convert.ToInt32(commandArray[1]), Convert.ToSingle(commandArray[2]));
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
            else
            {
                Console.WriteLine("Command not found");
            }
        }

        private void DoCircle(int interval, float radius)
        {
            var center = Dummy.Position;
            var timeStep = (float) (0.5 * Math.PI / 6);

            var deltaTime = 1000 / interval;

            Task.Run(async () =>
            {
                float timeCounter = 0;
                while (true)
                {
                    timeCounter += 0.1f;
                    var position = center;

                    var dx = (float) Math.Sin(timeCounter * timeStep) * radius;
                    var dy = (float) Math.Cos(timeCounter * timeStep) * radius;

                    Console.WriteLine(dx + " - " + dy);

                    position.X += dx;
                    position.Y += dy;

                    Client.Send(new TransformUpdatePayload(new ClientPayload(Dummy.LocalId, position, 0.0f)), DeliveryMethod.Unreliable);

                    Dummy.Position = position;

                    await Task.Delay(TimeSpan.FromMilliseconds(interval));
                }
            });
        }

        public void Tick()
        {
            Client?.Tick();
        }

    }
}
