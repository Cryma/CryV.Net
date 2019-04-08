﻿using System;
using System.Drawing;
using System.Numerics;
using CryV.Net.Elements;
using CryV.Net.Client.Networking;
using CryV.Net.Enums;

namespace CryV.Net.Client.Debugging
{
    public class DebugMenu
    {

        private readonly GameClient _gameClient;
        private readonly NetworkClient _networkClient;

        private bool _enabled = false;

        private float _width = 400 / 1920f;
        private float _x;
        private float _y;
        private int _line;

        public DebugMenu(GameClient gameClient, NetworkClient networkClient)
        {
            _gameClient = gameClient;
            _networkClient = networkClient;
        }

        public void Tick()
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

            if (_networkClient.IsConnected)
            {
                _line++;

                PrintLine("Packet loss: " + _networkClient.Statistics.PacketLossPercent + "%");
                PrintLine("Packet loss total: " + _networkClient.Statistics.PacketLoss);

                _line++;

                PrintLine("Bytes received: " + _networkClient.Statistics.BytesReceived);
                PrintLine("Bytes sent: " + _networkClient.Statistics.BytesSent);

                _line++;

                PrintLine("Packets received: " + _networkClient.Statistics.PacketsReceived);
                PrintLine("Packets sent: " + _networkClient.Statistics.PacketsSent);
            }

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
