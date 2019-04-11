using System;
using System.Threading.Tasks;
using Autofac;
using CryV.Net.Server.Common.Interfaces;
using LiteNetLib;

namespace CryV.Net.Server.Networking
{
    public class NetworkManager : INetworkManager, IStartable
    {

        private readonly EventBasedNetListener _listener = new EventBasedNetListener();
        private readonly NetManager _netManager;

        private const int _maxPlayers = 32;

        public NetworkManager()
        {
            _listener.ConnectionRequestEvent += OnConectionRequest;

            _netManager = new NetManager(_listener);
        }

        private void OnConectionRequest(ConnectionRequest request)
        {
            if (_netManager.PeersCount >= _maxPlayers)
            {
                request.Reject();

                return;
            }

            request.AcceptIfKey("hihihi");
        }

        public void Start()
        {
            _netManager.Start(1337);

            Task.Run(Tick);
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