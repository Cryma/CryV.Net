using CryV.Net.Server.Common.Interfaces;
using LiteNetLib;

namespace CryV.Net.Server.Players
{
    public class Player : IPlayer
    {

        public int Id => _peer.Id;

        private readonly NetPeer _peer;

        public Player(NetPeer peer)
        {
            _peer = peer;
        }

    }
}
