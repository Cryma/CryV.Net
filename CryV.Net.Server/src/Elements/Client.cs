using System.Numerics;
using CryV.Net.Shared.Payloads;
using LiteNetLib;
using LiteNetLib.Utils;

namespace CryV.Net.Server.Elements
{
    public class Client
    {

        public int Id => _peer.Id;

        public Vector3 Position { get; set; }
        
        public float Heading { get; set; }

        private readonly NetPeer _peer;

        public Client(NetPeer peer, Vector3 position, float heading)
        {
            _peer = peer;
            Position = position;
            Heading = heading;
        }

        public void Send(IPayload payload)
        {
            var writer = new NetDataWriter();
            payload.Write(writer);

            _peer.Send(writer, DeliveryMethod.ReliableOrdered);
        }

    }
}
