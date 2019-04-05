using System.Runtime.Serialization.Formatters;
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
            _netManager = new NetManager(_listener);
            _netManager.Start();
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

            _netManager.DisconnectPeer(Peer);
            Peer = null;
        }

        public static void Tick()
        {
            _netManager?.PollEvents();
        }
        
    }
}
