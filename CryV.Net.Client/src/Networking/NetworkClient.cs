using System;
using System.Runtime.Serialization.Formatters;
using System.Threading;
using System.Threading.Tasks;
using CryV.Net.Client.Elements;
using CryV.Net.Client.Helpers;
using CryV.Net.Shared.Payloads;
using CryV.Net.Shared.src.Enums;
using LiteNetLib;

namespace CryV.Net.Client.Networking
{
    public static class NetworkClient
    {

        public static NetPeer Peer { get; private set; }
        public static bool IsConnected => Peer != null;

        private static readonly EventBasedNetListener _listener = new EventBasedNetListener();
        private static readonly NetManager _netManager;

        private static CancellationTokenSource _cancellationTokenSource;

        static NetworkClient()
        {
            _listener.NetworkReceiveEvent += OnNetworkReceive;

            _netManager = new NetManager(_listener);
            _netManager.Start();
        }

        private static void OnNetworkReceive(NetPeer peer, NetPacketReader reader, DeliveryMethod deliverymethod)
        {
            var type = (PayloadType) reader.GetByte();

            if (type == PayloadType.Bootstrap)
            {
                var bootstrapPacket = new BootstrapPayload();
                bootstrapPacket.Read(reader);

                ThreadHelper.Run(() =>
                {
                    LocalPlayer.Character.Position = bootstrapPacket.StartPosition;

                    foreach (var player in bootstrapPacket.Players)
                    {
                        var ped = new Ped("mp_m_freemode_01", player.Position, player.Heading);
                    }
                });
            }
            else if (type == PayloadType.AddClient)
            {
                var addClientPayload = new AddClientPayload();
                addClientPayload.Read(reader);

                ThreadHelper.Run(() =>
                {
                    var ped = new Ped("mp_m_freemode_01", addClientPayload.Client.Position, addClientPayload.Client.Heading);
                });
            }
        }

        public static void Connect(string address, int port)
        {
            if (Peer != null)
            {
                return;
            }

            _cancellationTokenSource = new CancellationTokenSource();

            Peer = _netManager.Connect(address, port, "hihi");

            try
            {
                Task.Run(Tick, _cancellationTokenSource.Token);
            }
            catch (TaskCanceledException exception)
            {
                // Exception expected
            }
        }

        public static void Disconnect()
        {
            if (Peer == null)
            {
                return;
            }

            _cancellationTokenSource.Cancel();

            EntityPool.Clear();

            _netManager.DisconnectPeer(Peer);
            Peer = null;
        }

        public static async Task Tick()
        {
            while (_cancellationTokenSource.IsCancellationRequested == false)
            {
                await Task.Delay(TimeSpan.FromMilliseconds(1), _cancellationTokenSource.Token);

                _netManager?.PollEvents();
            }
        }
        
    }
}
