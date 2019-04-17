using System.Numerics;
using CryV.Net.Shared.Common.Enums;
using CryV.Net.Shared.Common.Payloads.Partials;
using ProtoBuf;

namespace CryV.Net.Shared.Common.Payloads
{
    [ProtoContract]
    public class VehicleUpdatePayload : IPayload
    {

        public PayloadType PayloadType { get; } = PayloadType.UpdateVehicle;

        [ProtoMember(1)]
        public int Id { get; set; }

        [ProtoMember(2)]
        public SerializableVector3 Position { get; set; }

        [ProtoMember(3)]
        public SerializableVector3 Velocity { get; set; }

        [ProtoMember(4)]
        public SerializableVector3 Rotation { get; set; }

        [ProtoMember(5)]
        public ulong Model { get; set; }

        public VehicleUpdatePayload()
        {
        }

        public VehicleUpdatePayload(int id, Vector3 position, Vector3 velocity, Vector3 rotation, ulong model)
        {
            Id = id;
            Position = position;
            Velocity = velocity;
            Rotation = rotation;
            Model = model;
        }

    }
}
