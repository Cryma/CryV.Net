using System;
using System.Numerics;
using CryV.Net.Shared.Common.Enums;
using CryV.Net.Shared.Common.Payloads.Partials;
using ProtoBuf;

namespace CryV.Net.Shared.Common.Payloads;

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
    public float EngineHealth { get; set; }

    [ProtoMember(6)]
    public string? NumberPlate { get; set; }

    [ProtoMember(7)]
    public ulong Model { get; set; }

    [ProtoMember(8)]
    public bool EngineState { get; set; }

    [ProtoMember(9)]
    public byte CurrentGear { get; set; }

    [ProtoMember(10)]
    public float CurrentRPM { get; set; }

    [ProtoMember(11)]
    public float Clutch { get; set; }

    [ProtoMember(12)]
    public float Turbo { get; set; }

    [ProtoMember(13)]
    public float Acceleration { get; set; }

    [ProtoMember(14)]
    public float Brake { get; set; }

    [ProtoMember(15)]
    public float SteeringAngle { get; set; }

    [ProtoMember(16)]
    public int ColorPrimary { get; set; }

    [ProtoMember(17)]
    public int ColorSecondary { get; set; }

    [ProtoMember(18)]
    public int VehicleData { get; set; }

    [ProtoMember(19)]
    public int? TrailerId { get; set; }

    // Empty construct is needed due to reflection
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public VehicleUpdatePayload()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    {
    }

    public VehicleUpdatePayload(int id, Vector3 position, Vector3 velocity, Vector3 rotation, float engineHealth, string? numberPlate,
        ulong model, bool engineState, byte currentGear, float currentRPM, float clutch, float turbo, float acceleration, float brake, float steeringAngle,
        int colorPrimary, int colorSecondary, bool isHornActive, bool isBurnout, bool roofUp, bool roofLowering, bool roofDown, bool roofRaising, bool siren,
        int? trailerId)
    {
        Id = id;
        Position = position;
        Velocity = velocity;
        Rotation = rotation;
        EngineHealth = engineHealth;
        NumberPlate = numberPlate;
        Model = model;
        EngineState = engineState;
        CurrentGear = currentGear;
        CurrentRPM = currentRPM;
        Clutch = clutch;
        Turbo = turbo;
        Acceleration = acceleration;
        Brake = brake;
        SteeringAngle = steeringAngle;
        ColorPrimary = colorPrimary;
        ColorSecondary = colorSecondary;
        TrailerId = trailerId;

        if (isHornActive)
        {
            VehicleData |= (int) Flags.VehicleData.IsHornActive;
        }

        if (isBurnout)
        {
            VehicleData |= (int) Flags.VehicleData.IsBurnout;
        }

        if (roofUp)
        {
            VehicleData |= (int) Flags.VehicleData.RoofUp;
        }

        if (roofLowering)
        {
            VehicleData |= (int) Flags.VehicleData.RoofLowering;
        }

        if (roofDown)
        {
            VehicleData |= (int) Flags.VehicleData.RoofDown;
        }

        if (roofRaising)
        {
            VehicleData |= (int) Flags.VehicleData.RoofRaising;
        }

        if (siren)
        {
            VehicleData |= (int) Flags.VehicleData.IsSirenActive;
        }
    }

    public bool IsDifferent(VehicleUpdatePayload payload)
    {
        return ((Vector3) Position - payload.Position).Length() > 0.1f ||
               ((Vector3) Velocity - payload.Velocity).Length() > 0.1f ||
               ((Vector3) Rotation - payload.Rotation).Length() > 0.1f ||
               Math.Abs(EngineHealth - payload.EngineHealth) > 0.1f ||
               NumberPlate != payload.NumberPlate ||
               EngineState != payload.EngineState ||
               Math.Abs(CurrentRPM - payload.CurrentRPM) > 1f ||
               Math.Abs(SteeringAngle - payload.SteeringAngle) > 0.02f ||
               ColorPrimary != payload.ColorPrimary ||
               ColorSecondary != payload.ColorSecondary ||
               VehicleData != payload.VehicleData ||
               TrailerId != payload.TrailerId;
    }

}
