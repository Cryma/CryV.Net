using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using CryV.Net.Shared.Enums;
using CryV.Net.Shared.Events;
using CryV.Net.Shared.Events.Types;
using CryV.Net.Shared.Payloads;
using CryV.Net.Shared.Payloads.Helpers;
using LiteNetLib;

namespace CryV.Net.FakeClient
{
    public class Client
    {

        private readonly EventBasedNetListener _listener = new EventBasedNetListener();
        private readonly NetManager _netManager;
        private readonly FakeClient _fakeClient;

        public bool IsConnected => _peer != null;

        private NetPeer _peer;

        public Client(FakeClient fakeClient)
        {
            _fakeClient = fakeClient;

            _listener.NetworkReceiveEvent += OnNetworkReceive;

            _netManager = new NetManager(_listener);
            _netManager.Start();
        }

        public void Connect(string address, int port)
        {
            if (IsConnected)
            {
                return;
            }

            _peer = _netManager.Connect(address, port, "hihi");
        }

        public void Send(IPayload payload, DeliveryMethod deliveryMethod)
        {
            var data = PayloadHandler.SerializePayload(payload).Prepend((byte) payload.PayloadType).ToArray();

            _peer?.Send(data, deliveryMethod);
        }

        public void Disconnect()
        {
            if (IsConnected == false)
            {
                return;
            }

            _peer.Disconnect();
            _peer = null;
        }

        public void Tick()
        {
            _netManager?.PollEvents();
        }

        private void OnNetworkReceive(NetPeer peer, NetPacketReader reader, DeliveryMethod deliverymethod)
        {
            var type = (PayloadType)reader.GetByte();

            var payloadObjectType = PayloadHandler.GetPayloadByType(type);
            var payload = PayloadHandler.DeserializePayload(payloadObjectType, reader.GetRemainingBytes());

            var eventType = typeof(NetworkEvent<>).MakeGenericType(payloadObjectType);
            var eventInstance = (IEvent)FormatterServices.GetUninitializedObject(eventType);

            var payloadProperty = eventType.GetProperty("Payload", BindingFlags.Public | BindingFlags.Instance);
            if (payloadProperty == null)
            {
                return;
            }

            payloadProperty.SetValue(eventInstance, payload);

            EventHandler.Publish(eventType, eventInstance);
        }
    }
}
