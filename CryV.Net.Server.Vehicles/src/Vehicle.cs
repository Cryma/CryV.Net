using System;
using System.Collections.Generic;
using System.Numerics;
using CryV.Net.Server.Common.Interfaces;
using CryV.Net.Shared.Common.Flags;
using CryV.Net.Shared.Common.Interfaces;
using CryV.Net.Shared.Common.Payloads;
using CryV.Net.Shared.Events.Types;
using LiteNetLib;

namespace CryV.Net.Server.Vehicles
{
    public partial class Vehicle : IVehicle
    {

        private readonly List<ISubscription> _subscriptions = new List<ISubscription>();

        private readonly IVehicleManager _vehicleManager;
        private readonly IEventHandler _eventHandler;
        private readonly IPlayerManager _playerManager;

        public Vehicle(IVehicleManager vehicleManager, IEventHandler eventHandler, IPlayerManager playerManager, int id, Vector3 position, Vector3 rotation, ulong model,
            string numberPlate)
        {
            _vehicleManager = vehicleManager;
            _eventHandler = eventHandler;
            _playerManager = playerManager;

            Id = id;
            _position = position;
            _rotation = rotation;
            _model = model;
            _numberPlate = numberPlate;

            _subscriptions.Add(_eventHandler.Subscribe<NetworkEvent<VehicleUpdatePayload>>(OnNetworkUpdate, x => x.Payload.Id == Id));

            PropagateNewVehicle();
        }

        public VehicleUpdatePayload GetPayload()
        {
            return new VehicleUpdatePayload(Id, Position, Velocity, Rotation, EngineHealth, NumberPlate, Model, EngineState, CurrentGear, CurrentRPM,
                Clutch, Turbo, Acceleration, Brake, SteeringAngle, ColorPrimary, ColorSecondary, IsHornActive, IsBurnout, IsRoofUp, IsRoofLowering, IsRoofDown,
                IsRoofRaising);
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

            _isHornActive = (payload.VehicleData & (int) VehicleData.IsHornActive) > 0;
            _isBurnout = (payload.VehicleData & (int) VehicleData.IsBurnout) > 0;
            _isRoofUp = (payload.VehicleData & (int) VehicleData.RoofUp) > 0;
            _isRoofLowering = (payload.VehicleData & (int) VehicleData.RoofLowering) > 0;
            _isRoofDown = (payload.VehicleData & (int) VehicleData.RoofDown) > 0;
            _isRoofRaising = (payload.VehicleData & (int) VehicleData.RoofRaising) > 0;
        }

        private void PropagateNewVehicle()
        {
            foreach (var player in _playerManager.GetPlayers())
            {
                player.Send(new VehicleAddPayload(GetPayload()), DeliveryMethod.ReliableOrdered);
            }
        }

        private void OnNetworkUpdate(NetworkEvent<VehicleUpdatePayload> obj)
        {
            var payload = obj.Payload;

            ReadPayload(payload);

            foreach (var player in _playerManager.GetPlayers())
            {
#if PEDMIRROR
                payload.Id = 1;
                payload.Position.X -= 6.5f;
                player.Send(payload, DeliveryMethod.Unreliable);
#else
                if (player.Vehicle == this && player.Seat == -1)
                {
                    continue;
                }

                player.Send(payload, DeliveryMethod.Unreliable);
#endif
            }
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
            foreach (var player in _playerManager.GetPlayers())
            {
                player.Send(new VehicleRemovePayload(Id), DeliveryMethod.ReliableOrdered);
            }
        }

    }
}
