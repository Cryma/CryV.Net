using LiteNetLib;

namespace CryV.Net.Server.Elements
{
    public class Client
    {

        public int Id => _peer.Id;

        private readonly NetPeer _peer;

        public Client(NetPeer peer)
        {
            _peer = peer;
        }

    }
}
