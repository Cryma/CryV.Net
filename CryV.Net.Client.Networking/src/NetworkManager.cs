using System;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.Serialization;
using System.Threading;
using System.Threading.Tasks;
using Autofac;
using CryV.Net.Client.Common.Events;
using CryV.Net.Client.Common.Interfaces;
using CryV.Net.Elements;
using CryV.Net.Shared.Common.Enums;
using CryV.Net.Shared.Common.Interfaces;
using CryV.Net.Shared.Common.Payloads;
using CryV.Net.Shared.Common.Payloads.Helpers;
using CryV.Net.Shared.Events.Types;
using LiteNetLib;

namespace CryV.Net.Client.Networking
{
    public class NetworkManager : INetworkManager, IStartable
    {

        public bool IsConnected => _peer != null && _peer.ConnectionState == ConnectionState.Connected;

        public NetStatistics Statistics => _peer.Statistics;

        public IPEndPoint EndPoint => _peer.EndPoint;

        public int Ping => _peer?.Ping ?? -1;

        private NetPeer _peer;

        private CancellationTokenSource _cancellationTokenSource;

        private readonly EventBasedNetListener _listener = new EventBasedNetListener();
        private readonly NetManager _netManager;

        private readonly IEventHandler _eventHandler;

        public NetworkManager(IEventHandler eventHandler)
        {
            _eventHandler = eventHandler;

            _listener.NetworkReceiveEvent += OnNetworkReceive;

            _netManager = new NetManager(_listener);
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

        public void Start()
        {
            _netManager.Start();
        }

        public void Connect(string address, int port)
        {
            if (IsConnected)
            {
                return;
            }

            _peer = _netManager.Connect(address, port, "hihihi");

            _eventHandler.Publish(new LocalPlayerConnectedEvent());

            _cancellationTokenSource = new CancellationTokenSource();
            Task.Run(Tick, _cancellationTokenSource.Token);
        }

        public void Disconnect()
        {
            if (IsConnected == false)
            {
                return;
            }

            _cancellationTokenSource.Cancel();

            _eventHandler.Publish(new LocalPlayerDisconnectedEvent());

            _peer.Disconnect();
            _peer = null;
        }

        public void Send(IPayload payload, DeliveryMethod deliveryMethod)
        {
            if (IsConnected == false)
            {
                return;
            }

            var data = PayloadHandler.SerializePayload(payload).Prepend((byte)payload.PayloadType).ToArray();

            _peer.Send(data, deliveryMethod);
        }

        private async Task Tick()
        {
            while (_cancellationTokenSource.IsCancellationRequested == false)
            {
                try
                {
                    await Task.Delay(TimeSpan.FromMilliseconds(1), _cancellationTokenSource.Token);

                    _netManager.PollEvents();
                }
                catch (Exception exception)
                {
                    Utility.Log(exception.ToString());
                }
            }
        }

    }
}
