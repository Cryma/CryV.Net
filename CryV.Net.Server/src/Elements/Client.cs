using System.Numerics;
using CryV.Net.Shared.Payloads;
using LiteNetLib;
using LiteNetLib.Utils;

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

        public void Send(IPayload payload)
        {
            var writer = new NetDataWriter();
            payload.Write(writer);

            _peer.Send(writer, DeliveryMethod.ReliableOrdered);
        }

    }
}
