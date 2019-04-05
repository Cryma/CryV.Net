using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.Serialization.Formatters;
using System.Threading;
using System.Threading.Tasks;
using CryV.Net.Client.Elements;
using CryV.Net.Client.Helpers;
using CryV.Net.Shared.Enums;
using CryV.Net.Shared.Payloads;
using CryV.Net.Shared.Payloads.Partials;
using LiteNetLib;
using LiteNetLib.Utils;

namespace CryV.Net.Client.Networking
{
    public class NetworkClient
    {

        public int LocalId { get; private set; }
        public NetPeer Peer { get; private set; }
        public bool IsConnected => Peer != null;

        private readonly ConcurrentDictionary<int, Client> _clients = new ConcurrentDictionary<int, Client>();

        private readonly EventBasedNetListener _listener = new EventBasedNetListener();
        private readonly NetManager _netManager;
        private readonly GameClient _gameClient;

        public CancellationTokenSource CancellationTokenSource;

        public NetworkClient(GameClient gameClient)
        {
            _listener.NetworkReceiveEvent += OnNetworkReceive;

            _netManager = new NetManager(_listener);
            _netManager.Start();

            _gameClient = gameClient;
        }

        private void OnNetworkReceive(NetPeer peer, NetPacketReader reader, DeliveryMethod deliverymethod)
        {
            var type = (PayloadType) reader.GetByte();

            if (type == PayloadType.Bootstrap)
            {
                var bootstrapPacket = new BootstrapPayload();
                bootstrapPacket.Read(reader);

                ThreadHelper.Run(() =>
                {
                    LocalId = bootstrapPacket.LocalId;

                    LocalPlayer.Character.Position = bootstrapPacket.StartPosition;

                    foreach (var player in bootstrapPacket.Players)
                    {
                        var client = new Client(player.Id, player.Position, player.Heading);
                        _clients.TryAdd(client.Id, client);
                    }
                });
            }
            else if (type == PayloadType.AddClient)
            {
                var addClientPayload = new AddClientPayload();
                addClientPayload.Read(reader);

                ThreadHelper.Run(() =>
                {
                    var client = new Client(addClientPayload.Client.Id, addClientPayload.Client.Position, addClientPayload.Client.Heading);
                    _clients.TryAdd(client.Id, client);
                });
            }
            else if (type == PayloadType.RemoveClient)
            {
                var removeClientPayload = new RemoveClientPayload();
                removeClientPayload.Read(reader);

                ThreadHelper.Run(() =>
                {
                    _clients.TryRemove(removeClientPayload.Id, out var client);

                    client.Dispose();
                });
            }
            else if (type == PayloadType.TransformUpdate)
            {
                var transformUpdatePayload = new TransformUpdatePayload();
                transformUpdatePayload.Read(reader);

                ThreadHelper.Run(() =>
                {
                    if (_clients.TryGetValue(transformUpdatePayload.Client.Id, out var client) == false)
                    {
                        return;
                    }

                    client.Position = transformUpdatePayload.Client.Position;
                    client.Rotation = new Vector3(client.Rotation.X, client.Rotation.Y, transformUpdatePayload.Client.Heading);
                });
            }
        }

        public void Connect(string address, int port)
        {
            if (Peer != null)
            {
                return;
            }

            CancellationTokenSource = new CancellationTokenSource();

            Peer = _netManager.Connect(address, port, "hihi");

            try
            {
                Task.Run(Tick, CancellationTokenSource.Token);
                Task.Run(_gameClient.SyncTransform, CancellationTokenSource.Token);
            }
            catch (TaskCanceledException exception)
            {
                // Exception expected
            }
        }

        public void Disconnect()
        {
            if (Peer == null)
            {
                return;
            }

            CancellationTokenSource.Cancel();

            _clients.Clear();
            EntityPool.Clear();

            _netManager.DisconnectPeer(Peer);
            Peer = null;
        }

        public async Task Tick()
        {
            while (CancellationTokenSource.IsCancellationRequested == false)
            {
                await Task.Delay(TimeSpan.FromMilliseconds(1), CancellationTokenSource.Token);

                _netManager?.PollEvents();
            }
        }

    }
}
