using System.Runtime.Serialization.Formatters;
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

                LocalPlayer.Character.Position = bootstrapPacket.StartPosition;

                foreach (var player in bootstrapPacket.Players)
                {
                    var ped = new Ped("mp_m_freemode_01", player.Position, player.Heading);
                }
            }
            else if (type == PayloadType.AddClient)
            {
                var addClientPayload = new AddClientPayload();
                addClientPayload.Read(reader);

                var ped = new Ped("mp_m_freemode_01", addClientPayload.Client.Position, addClientPayload.Client.Heading);
            }
        }

        public static void Connect(string address, int port)
        {
            if (Peer != null)
            {
                return;
            }

            Peer = _netManager.Connect(address, port, "hihi");
        }

        public static void Disconnect()
        {
            if (Peer == null)
            {
                return;
            }

            EntityPool.Clear();

            _netManager.DisconnectPeer(Peer);
            Peer = null;
        }

        public static void Tick()
        {
            _netManager?.PollEvents();
        }
        
    }
}
