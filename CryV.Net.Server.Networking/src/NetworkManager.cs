using System;
using System.Reflection;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using Autofac;
using CryV.Net.Server.Common.Interfaces;
using CryV.Net.Shared.Common.Enums;
using CryV.Net.Shared.Common.Events;
using CryV.Net.Shared.Common.Payloads.Helpers;
using LiteNetLib;
using Micky5991.EventAggregator.Interfaces;

namespace CryV.Net.Server.Networking
{
    public class NetworkManager : INetworkManager, IStartable
    {

        private readonly EventBasedNetListener _listener = new EventBasedNetListener();
        private readonly NetManager _netManager;

        private const int _maxPlayers = 32;

        private readonly IPlayerManager _playerManager;
        private readonly IEventAggregator _eventAggregator;

        public NetworkManager(IPlayerManager playerManager, IEventAggregator eventAggregator)
        {
            _playerManager = playerManager;
            _eventAggregator = eventAggregator;

            _listener.ConnectionRequestEvent += OnConectionRequest;
            _listener.NetworkReceiveEvent += OnNetworkReceive;
            _listener.PeerConnectedEvent += OnPeerConnected;
            _listener.PeerDisconnectedEvent += OnPeerDisconnected;

            _netManager = new NetManager(_listener);
        }

        private void OnPeerConnected(NetPeer peer)
        {
            _playerManager.AddPlayer(peer);
        }

        private void OnPeerDisconnected(NetPeer peer, DisconnectInfo disconnectinfo)
        {
            _playerManager.RemovePlayer(peer);
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

            var senderProperty = eventType.GetProperty("Sender", BindingFlags.Public | BindingFlags.Instance);
            if (senderProperty == null)
            {
                return;
            }

            payloadProperty.SetValue(eventInstance, payload);
            senderProperty.SetValue(eventInstance, peer);

            _eventAggregator.Publish(eventInstance);
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
                catch (TaskCanceledException)
                {
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.ToString());
                }
            }
        }

    }
}
