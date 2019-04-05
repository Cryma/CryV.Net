using System.Numerics;
using LiteNetLib;

namespace CryV.Net.Server.Elements
{
    public class Client
    {

        public int Id => _peer.Id;

        public Vector3 Position { get; }

        private readonly NetPeer _peer;

        public Client(NetPeer peer, Vector3 position)
        {
            _peer = peer;
            Position = position;
        }

    }
}
