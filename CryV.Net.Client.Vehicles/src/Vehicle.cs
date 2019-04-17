using System.Collections.Generic;
using System.Numerics;
using CryV.Net.Client.Common.Helpers;
using CryV.Net.Client.Common.Interfaces;
using CryV.Net.Helpers;
using CryV.Net.Shared.Common.Interfaces;
using CryV.Net.Shared.Common.Payloads;
using CryV.Net.Shared.Events.Types;

namespace CryV.Net.Client.Vehicles
{
    public class Vehicle : IVehicle
    {

        public int Id { get; }

        public Vector3 Position
        {
            get => _vehicle.Position;
            set => _vehicle.Position = value;
        }

        public Vector3 TargetPosition { get; set; }
        
        public Vector3 Velocity { get; set; }

        public Vector3 Rotation
        {
            get => _vehicle.Rotation;
            set => _vehicle.Rotation = value;
        }

        public Vector3 TargetRotation { get; set; }

        private Elements.Vehicle _vehicle;

        private readonly List<ISubscription> _eventSubscriptions = new List<ISubscription>();

        private readonly IEventHandler _eventHandler;
        private readonly IEntityPool _entityPool;

        public Vehicle(IEventHandler eventHandler, IEntityPool entityPool, VehicleUpdatePayload payload)
        {
            _eventHandler = eventHandler;
            _entityPool = entityPool;

            Id = payload.Id;
            TargetPosition = payload.Position;
            TargetRotation = payload.Rotation;

            _eventSubscriptions.Add(_eventHandler.Subscribe<NetworkEvent<VehicleUpdatePayload>>(update => ReadPayload(update.Payload), x => x.Payload.Id == Id));

            ThreadHelper.Run(() =>
            {
                _vehicle = new Elements.Vehicle(payload.Model, payload.Position, payload.Rotation)
                {
                    Velocity = payload.Velocity
                };

                _entityPool.AddEntity(_vehicle);
            });

            NativeHelper.OnNativeTick += Tick;
        }

        public void ReadPayload(VehicleUpdatePayload payload)
        {
            TargetPosition = payload.Position;
            TargetRotation = payload.Rotation;
            Velocity = payload.Velocity;
        }

        private void Tick(float deltatime)
        {
            
        }

        public void Dispose()
        {
            foreach (var subscription in _eventSubscriptions)
            {
                _eventHandler.Unsubscribe(subscription);
            }

            NativeHelper.OnNativeTick -= Tick;

            _entityPool.RemoveEntity(_vehicle);

            ThreadHelper.Run(() =>
            {
                _vehicle?.Delete();
            });
        }

    }
}
