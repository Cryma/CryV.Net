using System.Collections.Concurrent;
using System.Numerics;
using System.Threading.Tasks;
using CryV.Net.Client.Elements;
using CryV.Net.Client.Helpers;
using CryV.Net.Client.Networking;
using CryV.Net.Shared.Events;
using CryV.Net.Shared.Events.Types;
using CryV.Net.Shared.Payloads;
using CryV.Net.Shared.Payloads.Helpers;
using CryV.Net.Shared.Payloads.Partials;
using LiteNetLib;
using LiteNetLib.Utils;

namespace CryV.Net.Client
{
    public class GameClient
    {

        public bool IsConnected => _networkClient.IsConnected;

        private readonly NetworkClient _networkClient;

        private readonly ConcurrentDictionary<int, Networking.Client> _clients = new ConcurrentDictionary<int, Networking.Client>();

        public GameClient()
        {
            _networkClient = new NetworkClient(this);

            EventHandler.Subscribe<NetworkEvent<BootstrapPayload>>(OnBootstrap);
            EventHandler.Subscribe<NetworkEvent<AddClientPayload>>(OnAddClient);
            EventHandler.Subscribe<NetworkEvent<RemoveClientPayload>>(OnRemoveClient);
            EventHandler.Subscribe<NetworkEvent<TransformUpdatePayload>>(OnTransformUpdate);
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
            
        }

        public void SendPayload(IPayload payload, DeliveryMethod deliveryMethod)
        {
            var data = PayloadHandler.SerializePayload(payload);

            _networkClient.Peer.Send(data, deliveryMethod);
        }

        public async Task SyncTransform()
        {
            while (_networkClient.CancellationTokenSource.IsCancellationRequested == false)
            {
                await Task.Delay(1000 / 20, _networkClient.CancellationTokenSource.Token);

                ThreadHelper.Run(() =>
                {
                    var transformPayload = new TransformUpdatePayload(new ClientPayload(_networkClient.LocalId, LocalPlayer.Character.Position, LocalPlayer.Character.Rotation.Z));

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

                foreach (var player in obj.Payload.Players)
                {
                    var client = new Networking.Client(player.Id, player.Position, player.Heading);
                    _clients.TryAdd(client.Id, client);
                }
            });
        }

        private void OnAddClient(NetworkEvent<AddClientPayload> obj)
        {
            var clientData = obj.Payload.Client;

            ThreadHelper.Run(() =>
            {
                var client = new Networking.Client(clientData.Id, clientData.Position, clientData.Heading);
                _clients.TryAdd(client.Id, client);
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

        private void OnTransformUpdate(NetworkEvent<TransformUpdatePayload> obj)
        {
            var clientData = obj.Payload.Client;

            ThreadHelper.Run(() =>
            {
                if (_clients.TryGetValue(obj.Payload.Client.Id, out var client) == false)
                {
                    return;
                }

                client.Position = clientData.Position;
                client.Rotation = new Vector3(client.Rotation.X, client.Rotation.Y, clientData.Heading);
            });
        }

    }
}
