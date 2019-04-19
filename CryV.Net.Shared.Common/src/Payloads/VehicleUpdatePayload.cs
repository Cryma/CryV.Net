using System;
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

        [ProtoMember(6)]
        public bool EngineState { get; set; }

        [ProtoMember(8)]
        public byte CurrentGear { get; set; }

        [ProtoMember(9)]
        public float CurrentRPM { get; set; }

        [ProtoMember(10)]
        public float Clutch { get; set; }

        [ProtoMember(11)]
        public float Turbo { get; set; }

        [ProtoMember(12)]
        public float Acceleration { get; set; }

        [ProtoMember(13)]
        public float Brake { get; set; }

        [ProtoMember(14)]
        public float SteeringAngle { get; set; }

        public VehicleUpdatePayload()
        {
        }

        public VehicleUpdatePayload(int id, Vector3 position, Vector3 velocity, Vector3 rotation, ulong model, bool engineState, byte currentGear,
            float currentRPM, float clutch, float turbo, float acceleration, float brake, float steeringAngle)
        {
            Id = id;
            Position = position;
            Velocity = velocity;
            Rotation = rotation;
            Model = model;
            EngineState = engineState;
            CurrentGear = currentGear;
            CurrentRPM = currentRPM;
            Clutch = clutch;
            Turbo = turbo;
            Acceleration = acceleration;
            Brake = brake;
            SteeringAngle = steeringAngle;
        }

    }
}
