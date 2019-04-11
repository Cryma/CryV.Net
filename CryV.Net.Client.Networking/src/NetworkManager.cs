using System;
using System.Threading.Tasks;
using Autofac;
using CryV.Net.Client.Common.Interfaces;
using LiteNetLib;

namespace CryV.Net.Client.Networking
{
    public class NetworkManager : INetworkManager, IStartable
    {

        public bool IsConnected => _peer != null && _peer.ConnectionState == ConnectionState.Connected;

        private NetPeer _peer;

        private readonly EventBasedNetListener _listener = new EventBasedNetListener();
        private readonly NetManager _netManager;

        public NetworkManager()
        {
            _netManager = new NetManager(_listener);
        }

        public void Start()
        {
            _netManager.Start();

            Task.Run(Tick);
        }

        public void Connect(string address, int port)
        {
            if (IsConnected)
            {
                return;
            }

            _peer = _netManager.Connect(address, port, "hihi");
        }

        public void Disconnect()
        {
            if (IsConnected == false)
            {
                return;
            }

            _peer.Disconnect();
        }

        private async Task Tick()
        {
            while (true)
            {
                try
                {
                    await Task.Delay(TimeSpan.FromMilliseconds(1));

                    _netManager.PollEvents();
                }
                catch (Exception exception)
                {
                    // TODO: Add logging
                }
            }
        }

    }
}
