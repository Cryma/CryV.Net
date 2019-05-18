﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using CryV.Net.Enums;
using CryV.Net.Server.Common.Events;
using CryV.Net.Server.Common.Interfaces;
using CryV.Net.Shared.Common.Flags;
using CryV.Net.Shared.Common.Interfaces;
using CryV.Net.Shared.Common.Payloads;
using CryV.Net.Shared.Common.Payloads.Helpers;
using CryV.Net.Shared.Events.Types;
using LiteNetLib;

namespace CryV.Net.Server.Players
{
    public class Player : IPlayer
    {

        public int Id => _peer.Id;

        public Vector3 Position { get; set; } = new Vector3(161.1652f, -1069.867f, 29.19238f);

        public Vector3 Velocity { get; set; }

        public float Heading { get; set; }

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

        public IVehicle Vehicle { get; set; }

        public int Seat { get; set; }

        private readonly NetPeer _peer;
        private readonly IEventHandler _eventHandler;
        private readonly IPlayerManager _playerManager;
        private readonly IVehicleManager _vehicleManager;

        public Player(IPlayerManager playerManager, IEventHandler eventHandler, IVehicleManager vehicleManager, NetPeer peer)
        {
            _playerManager = playerManager;
            _eventHandler = eventHandler;
            _vehicleManager = vehicleManager;
            _peer = peer;
        }

        public void Send(IPayload payload, DeliveryMethod deliveryMethod)
        {
            var data = PayloadHandler.SerializePayload(payload).Prepend((byte)payload.PayloadType).ToArray();

            if (_peer == null)
            {
                return;
            }

            _peer.Send(data, deliveryMethod);
        }

        public NetPeer GetPeer()
        {
            return _peer;
        }

        public PlayerUpdatePayload GetPayload()
        {
            return new PlayerUpdatePayload(Id, Position, Velocity, Heading, AimTarget, Speed, Model, WeaponModel, IsJumping, IsClimbing, IsClimbingLadder, IsRagdoll,
                IsAiming, IsEnteringVehicle, IsInVehicle, Vehicle?.Id ?? -1, Seat, IsLeavingVehicle);
        }

        public void ReadPayload(PlayerUpdatePayload payload)
        {
            Position = payload.Position;
            Velocity = payload.Velocity;
            Heading = payload.Heading;
            AimTarget = payload.AimTarget;
            Model = payload.Model;
            WeaponModel = payload.WeaponModel;
            Speed = payload.Speed;
            Seat = payload.Seat;

            if (payload.VehicleId != -1)
            {
                Vehicle = _vehicleManager.GetVehicle(payload.VehicleId);
            }

            IsJumping = (payload.PedData & (int) PedData.IsJumping) > 0;
            IsClimbing = (payload.PedData & (int) PedData.IsClimbing) > 0;
            IsClimbingLadder = (payload.PedData & (int) PedData.IsClimbingLadder) > 0;
            IsRagdoll = (payload.PedData & (int) PedData.IsRagdoll) > 0;
            IsAiming = (payload.PedData & (int) PedData.IsAiming) > 0;
            var isEnteringVehicle = (payload.PedData & (int) PedData.IsEnteringVehicle) > 0;
            if (isEnteringVehicle && IsEnteringVehicle == false)
            {
                _eventHandler.Publish(new PlayerEntersVehicleEvent(this, Vehicle, (VehicleSeat) Seat));
            }

            IsEnteringVehicle = isEnteringVehicle;
            IsInVehicle = (payload.PedData & (int) PedData.IsInVehicle) > 0;
            IsLeavingVehicle = (payload.PedData & (int) PedData.IsLeavingVehicle) > 0;
        }

        public void Dispose()
        {
        }

    }
}
