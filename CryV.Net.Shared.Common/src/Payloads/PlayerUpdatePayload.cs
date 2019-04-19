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
        public SerializableVector3 AimTarget { get; set; }

        [ProtoMember(6)]
        public int Speed { get; set; }

        [ProtoMember(7)]
        public ulong Model { get; set; }

        [ProtoMember(8)]
        public ulong WeaponModel { get; set; }

        [ProtoMember(9)]
        public int PedData { get; set; }

        [ProtoMember(10)]
        public int VehicleId { get; set; }

        public PlayerUpdatePayload()
        {
        }

        public PlayerUpdatePayload(int id, Vector3 position, Vector3 velocity, float heading, Vector3 aimTarget, int speed, ulong model, ulong weaponModel,
            bool isJumping, bool isClimbing, bool isClimbingLadder, bool isRagdoll, bool isAiming, bool isEnteringVehicle, bool isInVehicle, int vehicleId)
        {
            Id = id;
            Position = position;
            Velocity = velocity;
            Heading = heading;
            AimTarget = aimTarget;
            Speed = speed;
            Model = model;
            WeaponModel = weaponModel;
            VehicleId = vehicleId;

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

            if (isAiming)
            {
                PedData |= (int) Flags.PedData.IsAiming;
            }

            if (isEnteringVehicle)
            {
                PedData |= (int) Flags.PedData.IsEnteringVehicle;
            }

            if (isInVehicle)
            {
                PedData |= (int) Flags.PedData.IsInVehicle;
            }
        }

    }
}
