using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using CryV.Net.Client.Debugging;
using CryV.Net.Elements;
using CryV.Net.Client.Helpers;
using CryV.Net.Client.Networking;
using CryV.Net.Helpers;
using CryV.Net.Shared.Events.Types;
using CryV.Net.Shared.Payloads;
using CryV.Net.Shared.Payloads.Helpers;
using LiteNetLib;
using ProtoBuf.ServiceModel;
using EventHandler = CryV.Net.Shared.Events.EventHandler;

namespace CryV.Net.Client
{
    public class GameClient
    {

        public bool IsConnected => _networkClient.IsConnected;

        private readonly NetworkClient _networkClient;
        private readonly DebugMenu _debugMenu;

        private readonly ConcurrentDictionary<int, Elements.Client> _clients = new ConcurrentDictionary<int, Elements.Client>();

        private Vector3 _lastPosition = Vector3.Zero;
        private float _lastHeading;

        private bool _isBootstrapped;

        public GameClient()
        {
            _networkClient = new NetworkClient(this);
            _debugMenu = new DebugMenu(this, _networkClient);

            EventHandler.Subscribe<NetworkEvent<BootstrapPayload>>(OnBootstrap);
            EventHandler.Subscribe<NetworkEvent<RemoveClientPayload>>(OnRemoveClient);
            EventHandler.Subscribe<NetworkEvent<ClientUpdatePayload>>(OnTransformUpdate);
        }

        public void Connect(string address, int port)
        {
            _networkClient?.Connect(address, port);
        }

        public void Disconnect()
        {
            _networkClient?.Disconnect();

            _clients.Clear();
            EntityPool.Clear();
        }

        public void Tick()
        {
            foreach (var client in _clients.Values)
            {
                client.Tick();
            }

            _debugMenu.Tick();
        }

        public void SendPayload(IPayload payload, DeliveryMethod deliveryMethod)
        {
            var data = PayloadHandler.SerializePayload(payload).Prepend((byte) payload.PayloadType).ToArray();

            if (_networkClient.Peer == null)
            {
                Utility.Log("Warning: Server is null");

                return;
            }

            _networkClient.Peer.Send(data, deliveryMethod);
        }

        public async Task SyncTransform()
        {
            while (_networkClient.CancellationTokenSource.IsCancellationRequested == false)
            {
                await Task.Delay(1000 / 20, _networkClient.CancellationTokenSource.Token);

                if (_isBootstrapped == false)
                {
                    continue;
                }

                ThreadHelper.Run(() =>
                {
                    var position = LocalPlayer.Character.Position;
                    var rotation = LocalPlayer.Character.Rotation;

                    if ((position - _lastPosition).Length() < 0.05f && Math.Abs(rotation.Z - _lastHeading) < 0.05f)
                    {
                        return;
                    }

                    _lastPosition = position;
                    _lastHeading = rotation.Z;

                    var transformPayload = new ClientUpdatePayload(_networkClient.LocalId, position, LocalPlayer.Character.Velocity, rotation.Z, LocalPlayer.Character.Speed(),
                        LocalPlayer.Model, LocalPlayer.Character.IsPedJumping(), LocalPlayer.Character.IsPedClimbing());

                    SendPayload(transformPayload, DeliveryMethod.Unreliable);
                });
            }
        }

        private void OnBootstrap(NetworkEvent<BootstrapPayload> obj)
        {
            _networkClient.LocalId = obj.Payload.LocalId;

            ThreadHelper.Run(() =>
            {
                LocalPlayer.Character.Position = obj.Payload.StartPosition;
                LocalPlayer.Character.Rotation = new Vector3(LocalPlayer.Character.Rotation.X, LocalPlayer.Character.Rotation.Y, obj.Payload.StartHeading);
                
                LocalPlayer.Model = obj.Payload.StartModel;

                _isBootstrapped = true;
            });
        }

        private void OnRemoveClient(NetworkEvent<RemoveClientPayload> obj)
        {
            ThreadHelper.Run(() =>
            {
                if (_clients.TryRemove(obj.Payload.Id, out var client) == false)
                {
                    return;
                }

                client.Dispose();
            });
        }

        private void OnTransformUpdate(NetworkEvent<ClientUpdatePayload> obj)
        {
            var clientData = obj.Payload;

            ThreadHelper.Run(() =>
            {
                if (_clients.TryGetValue(clientData.Id, out var client) == false)
                {
                    _clients.TryAdd(clientData.Id, new Elements.Client(clientData));

                    return;
                }

                client.ReadPayload(clientData);
            });
        }

    }
}
