using System.Collections.Generic;
using System.Numerics;
using CryV.Net.Server.Common.Interfaces;
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
            return new VehicleUpdatePayload(Id, Position, Velocity, Rotation, Model);
        }

        public void ReadPayload(VehicleUpdatePayload payload)
        {
            Position = payload.Position;
            Velocity = payload.Velocity;
            Rotation = payload.Rotation;
            Model = payload.Model;
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
