using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Numerics;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Threading;
using System.Threading.Tasks;
using CryV.Net.Client.Elements;
using CryV.Net.Client.Helpers;
using CryV.Net.Shared.Enums;
using CryV.Net.Shared.Events;
using CryV.Net.Shared.Events.Types;
using CryV.Net.Shared.Payloads;
using CryV.Net.Shared.Payloads.Helpers;
using CryV.Net.Shared.Payloads.Partials;
using LiteNetLib;
using LiteNetLib.Utils;
using EventHandler = CryV.Net.Shared.Events.EventHandler;

namespace CryV.Net.Client.Networking
{
    public class NetworkClient
    {

        public int LocalId { get; set; }
        public NetPeer Peer { get; private set; }
        public bool IsConnected => Peer != null;

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

            EventHandler.Publish(eventType, eventInstance);
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
