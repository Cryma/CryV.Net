﻿using System;
using System.Numerics;
using CryV.Net.Shared.Common.Enums;
using CryV.Net.Shared.Common.Payloads.Partials;
using ProtoBuf;

namespace CryV.Net.Shared.Common.Payloads;

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
    public float FingerPointingPitch { get; set; }

    [ProtoMember(6)]
    public float FingerPointingHeading { get; set; }

    [ProtoMember(7)]
    public SerializableVector3 AimTarget { get; set; }

    [ProtoMember(8)]
    public int Speed { get; set; }

    [ProtoMember(9)]
    public ulong Model { get; set; }

    [ProtoMember(10)]
    public ulong WeaponModel { get; set; }

    [ProtoMember(11)]
    public int PedData { get; set; }

    [ProtoMember(12)]
    public int? VehicleId { get; set; }

    [ProtoMember(13)]
    public int Seat { get; set; }

    // Empty construct is needed due to reflection
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public PlayerUpdatePayload()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    {
    }

    public PlayerUpdatePayload(int id, Vector3 position, Vector3 velocity, float heading, float fingerPointingPitch, float fingerPointingHeading,
        Vector3 aimTarget, int speed, ulong model, ulong weaponModel, bool isJumping, bool isClimbing, bool isClimbingLadder, bool isRagdoll,
        bool isAiming, bool isEnteringVehicle, bool isInVehicle, int? vehicleId, int seat, bool isLeavingVehicle, bool isFingerPointing)
    {
        Id = id;
        Position = position;
        Velocity = velocity;
        Heading = heading;
        FingerPointingPitch = fingerPointingPitch;
        FingerPointingHeading = fingerPointingHeading;
        AimTarget = aimTarget;
        Speed = speed;
        Model = model;
        WeaponModel = weaponModel;
        VehicleId = vehicleId;
        Seat = seat;

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

        if (isLeavingVehicle)
        {
            PedData |= (int) Flags.PedData.IsLeavingVehicle;
        }

        if (isFingerPointing)
        {
            PedData |= (int) Flags.PedData.IsFingerPointing;
        }
    }

    public bool IsDifferent(PlayerUpdatePayload payload)
    {
        return ((Vector3) Position - payload.Position).Length() > 0.1f ||
               ((Vector3) Velocity - payload.Velocity).Length() > 0.1f ||
               Math.Abs(Heading - payload.Heading) > 0.05f ||
               Math.Abs(FingerPointingPitch - payload.FingerPointingPitch) > 0.05f ||
               Math.Abs(FingerPointingHeading - payload.FingerPointingHeading) > 0.05f ||
               Model != payload.Model ||
               WeaponModel != payload.WeaponModel ||
               ((Vector3) AimTarget - payload.AimTarget).Length() > 0.1f ||
               PedData != payload.PedData;
    }

}
