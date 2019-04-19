using System.Collections.Generic;
using System.Numerics;
using System.Threading;
using CryV.Net.Client.Common.Helpers;
using CryV.Net.Client.Common.Interfaces;
using CryV.Net.Elements;
using CryV.Net.Helpers;
using CryV.Net.Shared.Common.Interfaces;
using CryV.Net.Shared.Common.Payloads;
using CryV.Net.Shared.Events.Types;
using LiteNetLib;

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

        public ulong Model { get; set; }

        public bool EngineState { get; set; }

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
            Model = payload.Model;

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

        public Elements.Vehicle GetVehicle()
        {
            return _vehicle;
        }

        public void ReadPayload(VehicleUpdatePayload payload)
        {
            if (Id == LocalPlayerHelper.VehicleId)
            {
                return;
            }

            TargetPosition = payload.Position;
            TargetRotation = payload.Rotation;
            Velocity = payload.Velocity;
            Model = payload.Model;

            if (EngineState != payload.EngineState)
            {
                ThreadHelper.Run(() =>
                {
                    _vehicle.SetVehicleEngineOn(payload.EngineState, false);

                    EngineState = payload.EngineState;
                });
            }
        }

        public VehicleUpdatePayload GetPayload()
        {
            return new VehicleUpdatePayload(Id, Position, _vehicle.Velocity, Rotation, Model, EngineState);
        }

        private void Tick(float deltatime)
        {
            if (Id == LocalPlayerHelper.VehicleId)
            {
                return;
            }

            Position = TargetPosition;
            Rotation = TargetRotation;
            _vehicle.Velocity = Velocity;
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
