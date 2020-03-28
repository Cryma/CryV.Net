using System;
using Autofac;
using CryV.Net.Client.Common.Helpers;
using CryV.Net.Client.Common.Interfaces;
using CryV.Net.Elements;
using LiteNetLib.Utils;

namespace CryV.Net.Client.Debugging.Menu
{
    public class DebugKeybinds : IStartable
    {

        private readonly INetworkManager _networkManager;

        public DebugKeybinds(INetworkManager networkManager)
        {
            _networkManager = networkManager;
        }

        public void Start()
        {
            NativeHelper.OnNativeTick += Tick;
        }

        private void Tick(float deltatime)
        {
            if (_networkManager.IsConnected == false && Utility.IsKeyReleased(ConsoleKey.F5))
            {
                _networkManager.Connect("127.0.0.1", 1337);
            }

        }
    }
}
