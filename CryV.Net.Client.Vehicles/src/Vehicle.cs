using System.Collections.Generic;
using System.Numerics;
using System.Threading;
using CryV.Net.Client.Common.Helpers;
using CryV.Net.Client.Common.Interfaces;
using CryV.Net.Elements;
using CryV.Net.Helpers;
using CryV.Net.Shared.Common.Flags;
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

        public byte CurrentGear { get; set; }

        public float CurrentRPM { get; set; }

        public float Clutch { get; set; }

        public float Turbo { get; set; }

        public float Acceleration { get; set; }

        public float Brake { get; set; }

        public float TargetSteeringAngle { get; set; }

        public int ColorPrimary { get; set; }

        public int ColorSecondary { get; set; }
        
        public bool IsHornActive { get; set; }

        public bool IsBurnout { get; set; }

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

                _vehicle.SetVehicleColours(payload.ColorPrimary, payload.ColorSecondary);

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
            TargetPosition = payload.Position;
            TargetRotation = payload.Rotation;
            Velocity = payload.Velocity;
            Model = payload.Model;
            CurrentGear = payload.CurrentGear;
            CurrentRPM = payload.CurrentRPM;
            Clutch = payload.Clutch;
            Turbo = payload.Turbo;
            Acceleration = payload.Acceleration;
            Brake = payload.Brake;
            TargetSteeringAngle = payload.SteeringAngle;

            IsHornActive = (payload.VehicleData & (int) VehicleData.IsHornActive) > 0;
            IsBurnout = (payload.VehicleData & (int) VehicleData.IsBurnout) > 0;

            if (Id == LocalPlayerHelper.VehicleId)
            {
                return;
            }

            if (EngineState != payload.EngineState)
            {
                ThreadHelper.Run(() =>
                {
                    _vehicle.SetVehicleEngineOn(payload.EngineState, true);

                    EngineState = payload.EngineState;
                });
            }

            Utility.Log($"Primary: {ColorPrimary} - Secondary: {ColorSecondary}");

            if (ColorPrimary != payload.ColorPrimary || ColorSecondary != payload.ColorSecondary)
            {
                ThreadHelper.Run(() =>
                {
                    _vehicle.SetVehicleColours(payload.ColorPrimary, payload.ColorSecondary);

                    ColorPrimary = payload.ColorPrimary;
                    ColorSecondary = payload.ColorSecondary;
                });
            }
        }

        public VehicleUpdatePayload GetPayload()
        {
            return new VehicleUpdatePayload(Id, Position, _vehicle.Velocity, Rotation, Model, EngineState, CurrentGear, CurrentRPM, Clutch, Turbo, Acceleration,
                Brake, TargetSteeringAngle, ColorPrimary, ColorSecondary, IsHornActive, IsBurnout);
        }

        private void Tick(float deltatime)
        {
            if (Id == LocalPlayerHelper.VehicleId)
            {
                return;
            }

            Rotation = Interpolation.LerpRotation(Rotation, TargetRotation, deltatime * 5);

            var positionDifference = TargetPosition - Position;
            _vehicle.Velocity = Velocity + positionDifference;

            _vehicle.CurrentGear = CurrentGear;
            _vehicle.CurrentRPM = CurrentRPM;
            _vehicle.Clutch = Clutch;
            _vehicle.Turbo = Turbo;
            _vehicle.Acceleration = Acceleration;
            _vehicle.Brake = Brake;
            _vehicle.SteeringAngle = Interpolation.Lerp(_vehicle.SteeringAngle, TargetSteeringAngle, deltatime * 5);

            ExecutionHelper.ExecuteOnce($"VEHICLE_{Id}_HORN", IsHornActive, () =>
            {
                _vehicle.StartVehicleHorn(9999);
            }, () =>
            {
                _vehicle.StartVehicleHorn(1);
            });
            
            ExecutionHelper.ExecuteOnce($"VEHICLE_{Id}_BURNOUT", IsBurnout, () =>
            {
                var driver = _vehicle.GetPedOnSeat(-1);
                driver?.TaskVehicleTempAction(_vehicle, 23, 9999);

                _vehicle.SetVehicleBurnout(true);
            }, () =>
            {
                var driver = _vehicle.GetPedOnSeat(-1);
                driver?.TaskVehicleTempAction(_vehicle, 6, 1);
                driver?.ClearPedTasks();

                _vehicle.SetVehicleBurnout(false);
            });
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
