using System;
using LiteNetLib;

namespace CryV.Net.Server.Networking
{
    public class NetworkServer
    {

        private readonly EventBasedNetListener _listener = new EventBasedNetListener();
        private readonly NetManager _netManager;

        private readonly GameServer _gameServer;
        private readonly int _maxPlayers;

        public NetworkServer(GameServer gameServer, int maxPlayers = 32)
        {
            _gameServer = gameServer;
            _maxPlayers = maxPlayers;

            _listener.ConnectionRequestEvent += OnConnectionRequest;
            _listener.PeerConnectedEvent += OnPeerConnected;
            _listener.PeerDisconnectedEvent += OnPeerDisconnected;

            _netManager = new NetManager(_listener);
        }

        private void OnConnectionRequest(ConnectionRequest request)
        {
            if (_netManager.PeersCount > _maxPlayers)
            {
                request.Reject();

                return;
            }

            request.AcceptIfKey("hihi");
        }

        private void OnPeerConnected(NetPeer peer)
        {
            Console.WriteLine($"Peer connected: {peer.Id} ({peer.EndPoint})");
        }

        private void OnPeerDisconnected(NetPeer peer, DisconnectInfo disconnectinfo)
        {
            Console.WriteLine($"Peer disconnected: {peer.Id} ({peer.EndPoint}) - Reason: {disconnectinfo.Reason}");
        }

        public void Start(int port)
        {
            _netManager.Start(port);
            Console.WriteLine("Network server started");
        }

        public void Stop()
        {
            _netManager.Stop();
        }

        public void Tick()
        {
            _netManager.PollEvents();
        }

    }
}
