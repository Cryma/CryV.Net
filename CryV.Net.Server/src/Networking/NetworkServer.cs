﻿using System;
using System.Collections.Generic;
using System.Numerics;
using CryV.Net.Server.Elements;
using CryV.Net.Shared.Payloads;
using LiteNetLib;
using LiteNetLib.Utils;

namespace CryV.Net.Server.Networking
{
    public class NetworkServer
    {

        private readonly EventBasedNetListener _listener = new EventBasedNetListener();
        private readonly NetManager _netManager;

        private readonly GameServer _gameServer;
        private readonly int _maxPlayers;

        private static readonly Vector3 _spawnPosition = new Vector3(412.4f, -976.71f, 29.43f);

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
            _gameServer.AddClient(new Client(peer, _spawnPosition));

            Console.WriteLine($"Peer connected: {peer.Id} ({peer.EndPoint})");
        }

        private void OnPeerDisconnected(NetPeer peer, DisconnectInfo disconnectinfo)
        {
            _gameServer.RemoveClient(peer.Id);

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