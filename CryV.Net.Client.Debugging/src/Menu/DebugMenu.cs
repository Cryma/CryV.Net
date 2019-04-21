using System;
using System.Drawing;
using System.Linq;
using System.Numerics;
using Autofac;
using CryV.Net.Client.Common.Helpers;
using CryV.Net.Client.Common.Interfaces;
using CryV.Net.Client.Helpers;
using CryV.Net.Elements;

namespace CryV.Net.Client.Debugging.Menu
{
    public class DebugMenu : IStartable
    {

        private bool _enabled;

        private float _width = 400 / 1920f;
        private float _x;
        private float _y;
        private int _line;

        private readonly INetworkManager _networkManager;

        public DebugMenu(INetworkManager networkManager)
        {
            _networkManager = networkManager;
        }

        public void Start()
        {
            NativeHelper.OnNativeTick += Tick;
        }

        public void Tick(float deltaTime)
        {
            if (Utility.IsKeyReleased(ConsoleKey.F4))
            {
                _enabled = _enabled == false;

                if (_enabled)
                {
                    _x = 1 - _width / 2 - 10 / 1920f;
                    _y = 10 / 1080f;
                }
            }

            if (_enabled == false)
            {
                return;
            }

            Draw();
        }

        private void Draw()
        {
            _line = 0;

            var position = LocalPlayer.Character.Position;
            var rotation = LocalPlayer.Character.Rotation;

            PrintVector(position, "Position");
            PrintVector(rotation, "Rotation");

            _line++;

            var entities = EntityPool.GetEntities();
            PrintLine("Peds: " + entities.Count(x => x.GetType() == typeof(Ped)));
            PrintLine("Vehicles: " + entities.Count(x => x.GetType() == typeof(Vehicle)));

            _line++;

            PrintLine("Current Vehicle: " + LocalPlayerHelper.VehicleId);
            if (LocalPlayer.Character.IsInAnyVehicle())
            {
                var vehicle = LocalPlayer.Character.GetVehiclePedIsIn();

                PrintLine("Vehicle health: " + vehicle.Health);
            }

            _line++;

            PrintLine("Ping: " + _networkManager.Ping);

#if !RELEASE
            if (_networkManager.IsConnected)
            {
                _line++;

                PrintLine("Packet loss: " + _networkManager.Statistics.PacketLossPercent + "%");
                PrintLine("Packet loss total: " + _networkManager.Statistics.PacketLoss);

                _line++;

                PrintLine("Bytes received: " + _networkManager.Statistics.BytesReceived);
                PrintLine("Bytes sent: " + _networkManager.Statistics.BytesSent);

                _line++;

                PrintLine("Packets received: " + _networkManager.Statistics.PacketsReceived);
                PrintLine("Packets sent: " + _networkManager.Statistics.PacketsSent);
            }
#endif

            var rectangleHeight = _y + (20 / 1080f) * _line;

            UserInterface.DrawRect(new Vector2(_x, _y + rectangleHeight / 2), new Vector2(_width, rectangleHeight), Color.FromArgb(100, 50, 50, 50));
        }

        private void PrintLine(string text)
        {
            UserInterface.DrawText(text, new Vector2(_x - _width / 2, _y + (20 / 1080f) * _line), 0.3f, Color.FromArgb(255, 255, 255, 255));

            _line++;
        }

        private void PrintVector(Vector3 vector, string prefix = "")
        {
            var text = string.IsNullOrEmpty(prefix) ? "" : prefix + ": ";
            PrintLine($"{text}{vector}");
        }

    }
}
