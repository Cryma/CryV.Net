using System;
using System.Reflection;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using Autofac;
using CryV.Net.Server.Common.Interfaces;
using CryV.Net.Shared.Common.Enums;
using CryV.Net.Shared.Common.Interfaces;
using CryV.Net.Shared.Common.Payloads.Helpers;
using CryV.Net.Shared.Events.Types;
using LiteNetLib;

namespace CryV.Net.Server.Networking
{
    public class NetworkManager : INetworkManager, IStartable
    {

        private readonly EventBasedNetListener _listener = new EventBasedNetListener();
        private readonly NetManager _netManager;

        private const int _maxPlayers = 32;

        private readonly IPlayerManager _playerManager;
        private readonly IEventHandler _eventHandler;

        public NetworkManager(IPlayerManager playerManager, IEventHandler eventHandler)
        {
            _playerManager = playerManager;
            _eventHandler = eventHandler;

            _listener.ConnectionRequestEvent += OnConectionRequest;
            _listener.NetworkReceiveEvent += OnNetworkReceive;
            _listener.PeerConnectedEvent += OnPeerConnected;
            _listener.PeerDisconnectedEvent += OnPeerDisconnected;

            _netManager = new NetManager(_listener);
        }

        private void OnPeerConnected(NetPeer peer)
        {
            _playerManager.AddPlayer(peer);
            Console.WriteLine($"Player {peer.Id} ({peer.EndPoint}) connected.");
        }

        private void OnPeerDisconnected(NetPeer peer, DisconnectInfo disconnectinfo)
        {
            _playerManager.RemovePlayer(peer);
            Console.WriteLine($"Player {peer.Id} ({peer.EndPoint}) disconnected.");
        }

        private void OnNetworkReceive(NetPeer peer, NetPacketReader reader, DeliveryMethod deliverymethod)
        {
            var type = (PayloadType) reader.GetByte();

            var payloadObjectType = PayloadHandler.GetPayloadByType(type);
            var payload = PayloadHandler.DeserializePayload(payloadObjectType, reader.GetRemainingBytes());

            var eventType = typeof(NetworkEvent<>).MakeGenericType(payloadObjectType);
            var eventInstance = (IEvent) FormatterServices.GetUninitializedObject(eventType);

            var payloadProperty = eventType.GetProperty("Payload", BindingFlags.Public | BindingFlags.Instance);
            if (payloadProperty == null)
            {
                return;
            }

            payloadProperty.SetValue(eventInstance, payload);

            _eventHandler.Publish(eventType, eventInstance);
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
                    Console.WriteLine(exception.ToString());
                }
            }
        }

    }
}
