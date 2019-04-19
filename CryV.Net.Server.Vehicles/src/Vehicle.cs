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
    public class Vehicle : IVehicle
    {
        
        public int Id { get; }

        public Vector3 Position { get; set; }

        public Vector3 Velocity { get; set; }

        public Vector3 Rotation { get; set; }

        public ulong Model { get; set; }

        public bool EngineState { get; set; }

        public byte CurrentGear { get; set; }

        public float CurrentRPM { get; set; }

        public float Clutch { get; set; }

        public float Turbo { get; set; }

        public float Acceleration { get; set; }

        public float Brake { get; set; }

        public float SteeringAngle { get; set; }

        public int ColorPrimary { get; set; } = 112;

        public int ColorSecondary { get; set; } = 112;

        public bool IsHornActive { get; set; }

        public bool IsBurnout { get; set; }


        private readonly List<ISubscription> _subscriptions = new List<ISubscription>();

        private readonly IVehicleManager _vehicleManager;
        private readonly IEventHandler _eventHandler;
        private readonly IPlayerManager _playerManager;

        public Vehicle(IVehicleManager vehicleManager, IEventHandler eventHandler, IPlayerManager playerManager, int id, Vector3 position, Vector3 rotation, ulong model)
        {
            _vehicleManager = vehicleManager;
            _eventHandler = eventHandler;
            _playerManager = playerManager;

            Id = id;
            Position = position;
            Rotation = rotation;
            Model = model;

            _subscriptions.Add(_eventHandler.Subscribe<NetworkEvent<VehicleUpdatePayload>>(OnNetworkUpdate, x => x.Payload.Id == Id));

            PropagateNewVehicle();
        }

        public VehicleUpdatePayload GetPayload()
        {
            return new VehicleUpdatePayload(Id, Position, Velocity, Rotation, Model, EngineState, CurrentGear, CurrentRPM, Clutch, Turbo, Acceleration, Brake,
                SteeringAngle, ColorPrimary, ColorSecondary, IsHornActive, IsBurnout);
        }

        public void ReadPayload(VehicleUpdatePayload payload)
        {
            Position = payload.Position;
            Velocity = payload.Velocity;
            Rotation = payload.Rotation;
            Model = payload.Model;
            EngineState = payload.EngineState;
            CurrentGear = payload.CurrentGear;
            CurrentRPM = payload.CurrentRPM;
            Clutch = payload.Clutch;
            Turbo = payload.Turbo;
            Acceleration = payload.Acceleration;
            Brake = payload.Brake;
            SteeringAngle = payload.SteeringAngle;
            ColorPrimary = payload.ColorPrimary;
            ColorSecondary = payload.ColorSecondary;

            IsHornActive = (payload.VehicleData & (int) VehicleData.IsHornActive) > 0;
            IsBurnout = (payload.VehicleData & (int) VehicleData.IsBurnout) > 0;
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
                player.Send(payload, DeliveryMethod.Unreliable);
#if PEDMIRROR
                payload.Id = 1;
                payload.Position.X -= 6.5f;
                player.Send(payload, DeliveryMethod.Unreliable);
#endif
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
