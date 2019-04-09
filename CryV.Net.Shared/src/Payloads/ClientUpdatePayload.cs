using System.Numerics;
using CryV.Net.Shared.Enums;
using CryV.Net.Shared.Payloads.Partials;
using ProtoBuf;

namespace CryV.Net.Shared.Payloads
{
    [ProtoContract]
    public class ClientUpdatePayload : IPayload
    {

        public PayloadType PayloadType { get; } = PayloadType.UpdateClient;

        [ProtoMember(1)]
        public int Id { get; set; }

        [ProtoMember(2)]
        public SerializableVector3 Position { get; set; }

        [ProtoMember(3)]
        public SerializableVector3 Velocity { get; set; }

        [ProtoMember(4)]
        public float Heading { get; set; }

        [ProtoMember(5)]
        public int Speed { get; set; }

        [ProtoMember(6)]
        public ulong Model { get; set; }

        [ProtoMember(7)]
        public int PedData { get; set; }

        public ClientUpdatePayload()
        {
        }

        public ClientUpdatePayload(int id, Vector3 position, Vector3 velocity, float heading, int speed, ulong model, bool isJumping, bool isClimbing)
        {
            Id = id;
            Position = position;
            Velocity = velocity;
            Heading = heading;
            Speed = speed;
            Model = model;

            if (isJumping)
            {
                PedData |= (int) Flags.PedData.IsJumping;
            }

            if (isClimbing)
            {
                PedData |= (int) Flags.PedData.IsClimbing;
            }
        }

    }
}
