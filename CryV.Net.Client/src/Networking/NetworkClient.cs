using System.Runtime.Serialization.Formatters;
using CryV.Net.Client.Elements;
using CryV.Net.Client.Helpers;
using CryV.Net.Shared.Payloads;
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
            if (reader.GetByte() == 1)
            {
                var bootstrapPacket = new Bootstrap();
                bootstrapPacket.Read(reader);

                LocalPlayer.Character.Position = bootstrapPacket.StartPosition;

                foreach (var player in bootstrapPacket.Players)
                {
                    var ped = new Ped("mp_m_freemode_01", player, 0.0f);
                }
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
