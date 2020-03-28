using System;
using System.Collections.Generic;
using System.Numerics;
using CryV.Net.Server.Common.Events;
using CryV.Net.Server.Common.Interfaces;
using CryV.Net.Shared.Common.Flags;
using CryV.Net.Shared.Common.Payloads;
using LiteNetLib;
using Micky5991.EventAggregator.Interfaces;

namespace CryV.Net.Server.Vehicles
{
    public partial class Vehicle : IVehicle
    {

        private readonly IEventAggregator _eventAggregator;
        private readonly IPlayerManager _playerManager;

        public Vehicle(IEventAggregator eventAggregator, IPlayerManager playerManager, int id, Vector3 position,
            Vector3 rotation, ulong model, string numberPlate)
        {
            _eventAggregator = eventAggregator;
            _playerManager = playerManager;

            Id = id;
            _position = position;
            _rotation = rotation;
            _model = model;
            _numberPlate = numberPlate;
        }

        public VehicleUpdatePayload GetPayload()
        {
            return new VehicleUpdatePayload(Id, Position, Velocity, Rotation, EngineHealth, NumberPlate, Model, EngineState, CurrentGear, CurrentRPM,
                Clutch, Turbo, Acceleration, Brake, SteeringAngle, ColorPrimary, ColorSecondary, IsHornActive, IsBurnout, IsRoofUp, IsRoofLowering, IsRoofDown,
                IsRoofRaising, IsSirenActive, TrailerId);
        }

        public void ReadPayload(VehicleUpdatePayload payload)
        {
            _position = payload.Position;
            _velocity = payload.Velocity;
            _rotation = payload.Rotation;
            _engineHealth = payload.EngineHealth;
            _numberPlate = payload.NumberPlate;
            _model = payload.Model;
            _engineState = payload.EngineState;
            _currentGear = payload.CurrentGear;
            _currentRPM = payload.CurrentRPM;
            _clutch = payload.Clutch;
            _turbo = payload.Turbo;
            _acceleration = payload.Acceleration;
            _brake = payload.Brake;
            _steeringAngle = payload.SteeringAngle;
            _colorPrimary = payload.ColorPrimary;
            _colorSecondary = payload.ColorSecondary;

            if (_trailerId == -1 && payload.TrailerId != -1)
            {
                _trailerId = payload.TrailerId;

                _eventAggregator.PublishSync(new VehicleTrailerAttachedEvent(this));
            }

            if (_trailerId != -1 && payload.TrailerId == -1)
            {
                _eventAggregator.PublishSync(new VehicleTrailerDetachEvent(this));

                _trailerId = payload.TrailerId;
            }

            _isHornActive = (payload.VehicleData & (int) VehicleData.IsHornActive) > 0;
            _isBurnout = (payload.VehicleData & (int) VehicleData.IsBurnout) > 0;
            _isRoofUp = (payload.VehicleData & (int) VehicleData.RoofUp) > 0;
            _isRoofLowering = (payload.VehicleData & (int) VehicleData.RoofLowering) > 0;
            _isRoofDown = (payload.VehicleData & (int) VehicleData.RoofDown) > 0;
            _isRoofRaising = (payload.VehicleData & (int) VehicleData.RoofRaising) > 0;
            _isSirenActive = (payload.VehicleData & (int) VehicleData.IsSirenActive) > 0;
        }

        public void ForceSync()
        {
            foreach (var player in _playerManager.GetPlayers())
            {
                player.Send(GetPayload(), DeliveryMethod.ReliableOrdered);
            }
        }

        public void Dispose()
        {
        }

    }
}
