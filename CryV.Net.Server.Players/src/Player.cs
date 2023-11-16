using System;
using System.Linq;
using System.Numerics;
using CryV.Net.Server.Common.Events;
using CryV.Net.Server.Common.Interfaces;
using CryV.Net.Shared.Common.Enums;
using CryV.Net.Shared.Common.Flags;
using CryV.Net.Shared.Common.Payloads;
using CryV.Net.Shared.Common.Payloads.Helpers;
using LiteNetLib;
using Micky5991.EventAggregator.Interfaces;
using Microsoft.Extensions.Logging;
using ConnectionState = CryV.Net.Server.Common.Enums.ConnectionState;

namespace CryV.Net.Server.Players;

public class Player : IServerPlayer
{

    public int Id => Peer.Id;

    public ConnectionState ConnectionState { get; set; }

    public Vector3 Position { get; set; } = new Vector3(161.1652f, -1069.867f, 29.19238f);

    public Vector3 Rotation { get; set; }

    public Vector3 Velocity { get; set; }

    public float FingerPointingPitch { get; set; }

    public float FingerPointingHeading { get; set; }

    public Vector3 AimTarget { get; set; }

    public int Speed { get; set; }

    public ulong Model { get; set; } = 1885233650; // Male freemode model

    public ulong WeaponModel { get; set; }

    public bool IsJumping { get; set; }

    public bool IsClimbing { get; set; }
    
    public bool IsClimbingLadder { get; set; }

    public bool IsRagdoll { get; set; }

    public bool IsAiming { get; set; }

    public bool IsEnteringVehicle { get; set; }

    public bool IsInVehicle { get; set; }

    public bool IsLeavingVehicle { get; set; }

    public bool IsFingerPointing { get; set; }

    public IServerVehicle? Vehicle { get; set; }

    public NetPeer Peer { get; }

    public int Seat { get; set; }

    private readonly IEventAggregator _eventAggregator;
    private readonly IVehicleManager _vehicleManager;
    private readonly ILogger _logger;

    public Player(IEventAggregator eventAggregator, IVehicleManager vehicleManager, ILogger logger, NetPeer peer)
    {
        _eventAggregator = eventAggregator;
        _vehicleManager = vehicleManager;
        _logger = logger;
        Peer = peer;
    }

    public void Send(IPayload payload, DeliveryMethod deliveryMethod)
    {
        var data = PayloadHandler.SerializePayload(payload).Prepend((byte)payload.PayloadType).ToArray();

        if (Peer == null)
        {
            return;
        }

        Peer.Send(data, deliveryMethod);
    }

    public PlayerUpdatePayload GetPayload()
    {
        return new PlayerUpdatePayload(Id, Position, Velocity, Rotation.Z, FingerPointingPitch, FingerPointingHeading, AimTarget, Speed, Model,
            WeaponModel, IsJumping, IsClimbing, IsClimbingLadder, IsRagdoll, IsAiming, IsEnteringVehicle, IsInVehicle, Vehicle?.Id, Seat,
            IsLeavingVehicle, IsFingerPointing);
    }

    public void ReadPayload(PlayerUpdatePayload payload)
    {
        Position = payload.Position;
        Velocity = payload.Velocity;
        Rotation = new Vector3(Rotation.X, Rotation.Y, payload.Heading);
        FingerPointingPitch = payload.FingerPointingPitch;
        FingerPointingHeading = payload.FingerPointingHeading;
        AimTarget = payload.AimTarget;
        Model = payload.Model;
        WeaponModel = payload.WeaponModel;
        Speed = payload.Speed;
        Seat = payload.Seat;

        if (payload.VehicleId != null)
        {
            Vehicle = _vehicleManager.GetVehicle(payload.VehicleId.Value) ?? throw new InvalidOperationException("Could not get vehicle with id: " + payload.VehicleId.Value);
        }

        IsJumping = (payload.PedData & (int) PedData.IsJumping) > 0;
        IsClimbing = (payload.PedData & (int) PedData.IsClimbing) > 0;
        IsClimbingLadder = (payload.PedData & (int) PedData.IsClimbingLadder) > 0;
        IsRagdoll = (payload.PedData & (int) PedData.IsRagdoll) > 0;
        IsAiming = (payload.PedData & (int) PedData.IsAiming) > 0;
        var isEnteringVehicle = (payload.PedData & (int) PedData.IsEnteringVehicle) > 0;
        if (isEnteringVehicle && IsEnteringVehicle == false)
        {
            if (Vehicle == null)
            {
                throw new InvalidOperationException("Player is trying to enter vehicle that is null!");
            }

            _eventAggregator.Publish(new PlayerEntersVehicleEvent(this, Vehicle, (VehicleSeat) Seat));
        }

        IsEnteringVehicle = isEnteringVehicle;
        IsInVehicle = (payload.PedData & (int) PedData.IsInVehicle) > 0;
        IsLeavingVehicle = (payload.PedData & (int) PedData.IsLeavingVehicle) > 0;
        IsFingerPointing = (payload.PedData & (int) PedData.IsFingerPointing) > 0;
    }

    public void Dispose()
    {
    }

}
