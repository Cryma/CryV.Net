using System;
using System.Linq;
using System.Numerics;
using CryV.Net.Shared.Payloads;
using CryV.Net.Shared.Payloads.Flags;
using CryV.Net.Shared.Payloads.Helpers;
using LiteNetLib;

namespace CryV.Net.Server.Elements
{
    public class Client
    {

        public int Id => _peer.Id;

        public Vector3 Position { get; set; }

        public Vector3 Velocity { get; set; }

        public float Heading { get; set; }

        public int Speed { get; set; }

        public ulong Model { get; set; }

        public bool IsJumping { get; set; }

        public bool IsClimbing { get; set; }

        public bool IsClimbingLadder { get; set; }

        private readonly NetPeer _peer;

        public Client(NetPeer peer)
        {
            _peer = peer;
        }

        public Client(NetPeer peer, ClientUpdatePayload payload)
        {
            _peer = peer;

            ReadPayload(payload);
        }

        public void ReadPayload(ClientUpdatePayload payload)
        {
            Position = payload.Position;
            Velocity = payload.Velocity;
            Heading = payload.Heading;
            Model = payload.Model;
            Speed = payload.Speed;

            IsJumping = (payload.PedData & (int) PedData.IsJumping) > 0;
            IsClimbing = (payload.PedData & (int) PedData.IsClimbing) > 0;
            IsClimbingLadder = (payload.PedData & (int) PedData.IsClimbingLadder) > 0;
        }

        public ClientUpdatePayload GetPayload()
        {
            return new ClientUpdatePayload(Id, Position, Velocity, Heading, Speed, Model, IsJumping, IsClimbing, IsClimbingLadder);
        }

        public void Send(IPayload payload, DeliveryMethod deliveryMethod = DeliveryMethod.ReliableOrdered)
        {
            var data = PayloadHandler.SerializePayload(payload).Prepend((byte) payload.PayloadType).ToArray();

            _peer.Send(data, deliveryMethod);
        }

    }
}
