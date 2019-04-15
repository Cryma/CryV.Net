using System.Numerics;
using CryV.Net.Shared.Common.Enums;
using CryV.Net.Shared.Common.Payloads.Partials;
using ProtoBuf;

namespace CryV.Net.Shared.Common.Payloads
{
    [ProtoContract]
    public class PlayerUpdatePayload : IPayload
    {

        public PayloadType PayloadType { get; } = PayloadType.UpdatePlayer;

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
        public ulong WeaponModel { get; set; }

        [ProtoMember(7)]
        public int PedData { get; set; }

        public PlayerUpdatePayload()
        {
        }

        public PlayerUpdatePayload(int id, Vector3 position, Vector3 velocity, float heading, int speed, ulong model, ulong weaponModel, bool isJumping, bool isClimbing,
            bool isClimbingLadder, bool isRagdoll)
        {
            Id = id;
            Position = position;
            Velocity = velocity;
            Heading = heading;
            Speed = speed;
            Model = model;
            WeaponModel = weaponModel;

            if (isJumping)
            {
                PedData |= (int) Flags.PedData.IsJumping;
            }

            if (isClimbing)
            {
                PedData |= (int) Flags.PedData.IsClimbing;
            }

            if (isClimbingLadder)
            {
                PedData |= (int) Flags.PedData.IsClimbingLadder;
            }

            if (isRagdoll)
            {
                PedData |= (int) Flags.PedData.IsRagdoll;
            }
        }

    }
}
