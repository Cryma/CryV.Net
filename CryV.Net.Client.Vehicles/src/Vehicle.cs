using System.Collections.Generic;
using System.Numerics;
using CryV.Net.Client.Common.Helpers;
using CryV.Net.Client.Common.Interfaces;
using CryV.Net.Client.Helpers;
using CryV.Net.Elements;
using CryV.Net.Enums;
using CryV.Net.Helpers;
using CryV.Net.Shared.Common.Flags;
using CryV.Net.Shared.Common.Interfaces;
using CryV.Net.Shared.Common.Payloads;
using CryV.Net.Shared.Events.Types;

namespace CryV.Net.Client.Vehicles
{
    public class Vehicle : IVehicle
    {

        public int Id { get; }

        public Vector3 Position { get; set; }

        public Vector3 Velocity { get; set; }

        public Vector3 Rotation { get; set; }

        public float EngineHealth { get; set; }

        public string NumberPlate { get; set; }

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

        public bool IsRoofUp { get; set; }

        public bool IsRoofLowering { get; set; }

        public bool IsRoofDown { get; set; }

        public bool IsRoofRaising { get; set; }


        private Elements.Vehicle _vehicle;

        private readonly List<ISubscription> _eventSubscriptions = new List<ISubscription>();

        private readonly IEventHandler _eventHandler;

        public Vehicle(IEventHandler eventHandler, VehicleUpdatePayload payload)
        {
            _eventHandler = eventHandler;

            Id = payload.Id;
            
            ReadPayload(payload);

            _eventSubscriptions.Add(_eventHandler.Subscribe<NetworkEvent<VehicleUpdatePayload>>(update =>
            {
                ReadPayload(update.Payload);

                if (LocalPlayerHelper.Vehicle == _vehicle && LocalPlayer.Character.Seat == VehicleSeat.Driver)
                {
                    CheckForChanges(update.Payload);
                    ForceSync();
                }

            }, x => x.Payload.Id == Id));

            ThreadHelper.Run(() =>
            {
                _vehicle = new Elements.Vehicle(Model, Position, Rotation, Velocity, ColorPrimary, ColorSecondary, NumberPlate)
                {
                    EngineHealth = EngineHealth
                };

                if (EngineHealth < 0.0f)
                {
                    _vehicle.Explode(false, true);
                }

                EntityPool.AddEntity(_vehicle);
            });

            NativeHelper.OnNativeTick += Tick;
        }

        public Elements.Vehicle GetVehicle()
        {
            return _vehicle;
        }

        public void ReadPayload(VehicleUpdatePayload payload)
        {
            Position = payload.Position;
            Rotation = payload.Rotation;
            Velocity = payload.Velocity;
            EngineHealth = payload.EngineHealth;
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
            IsRoofUp = (payload.VehicleData & (int) VehicleData.RoofUp) > 0;
            IsRoofLowering = (payload.VehicleData & (int) VehicleData.RoofLowering) > 0;
            IsRoofDown = (payload.VehicleData & (int) VehicleData.RoofDown) > 0;
            IsRoofRaising = (payload.VehicleData & (int) VehicleData.RoofRaising) > 0;
        }

        private void CheckForChanges(VehicleUpdatePayload payload)
        {
            if (EngineState != payload.EngineState)
            {
                ThreadHelper.Run(() =>
                {
                    _vehicle.SetVehicleEngineOn(payload.EngineState, true);

                    EngineState = payload.EngineState;
                });
            }

            if (ColorPrimary != payload.ColorPrimary || ColorSecondary != payload.ColorSecondary)
            {
                ThreadHelper.Run(() =>
                {
                    _vehicle.SetVehicleColours(payload.ColorPrimary, payload.ColorSecondary);

                    ColorPrimary = payload.ColorPrimary;
                    ColorSecondary = payload.ColorSecondary;
                });
            }

            if (NumberPlate != payload.NumberPlate)
            {
                ThreadHelper.Run(() =>
                {
                    _vehicle.NumberPlate = payload.NumberPlate;

                    NumberPlate = payload.NumberPlate;
                });
            }
        }

        public VehicleUpdatePayload GetPayload()
        {
            return new VehicleUpdatePayload(Id, Position, _vehicle.Velocity, Rotation, EngineHealth, NumberPlate, Model, EngineState, CurrentGear,
                CurrentRPM, Clutch, Turbo, Acceleration, Brake, TargetSteeringAngle, ColorPrimary, ColorSecondary, IsHornActive, IsBurnout, IsRoofUp, IsRoofLowering,
                IsRoofDown, IsRoofRaising);
        }

        private void Tick(float deltatime)
        {
            if (Id == LocalPlayerHelper.VehicleId && LocalPlayer.Character.Seat == VehicleSeat.Driver)
            {
                return;
            }

            Sync(deltatime);
        }

        private void Sync(float deltaTime)
        {
            Rotation = Interpolation.LerpRotation(_vehicle.Rotation, Rotation, deltaTime * 5);

            if (Vector3.DistanceSquared(_vehicle.Position, Position) > 9.0f)
            {
                _vehicle.Position = Position;
            }

            var positionDifference = Position - _vehicle.Position;
            _vehicle.Velocity = Velocity + positionDifference;

            _vehicle.CurrentGear = CurrentGear;
            _vehicle.CurrentRPM = CurrentRPM;
            _vehicle.Clutch = Clutch;
            _vehicle.Turbo = Turbo;
            _vehicle.Acceleration = Acceleration;
            _vehicle.Brake = Brake;
            _vehicle.SteeringAngle = Interpolation.Lerp(_vehicle.SteeringAngle, TargetSteeringAngle, deltaTime * 5);

            ExecutionHelper.ExecuteOnce($"VEHICLE_{Id}_RAISEROOF", IsRoofRaising, () =>
            {
                _vehicle.RaiseConvertibleRoof(false);
            });

            ExecutionHelper.ExecuteOnce($"VEHICLE_{Id}_LOWERROOF", IsRoofLowering, () =>
            {
                _vehicle.LowerConvertibleRoof(false);
            });

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

        private void ForceSync()
        {
            ThreadHelper.Run(() =>
            {
                Sync(1.0f);
            });
        }

        public void Dispose()
        {
            foreach (var subscription in _eventSubscriptions)
            {
                _eventHandler.Unsubscribe(subscription);
            }

            NativeHelper.OnNativeTick -= Tick;

            ThreadHelper.Run(() =>
            {
                EntityPool.RemoveEntity(_vehicle);

                _vehicle?.Delete();
            });
        }

    }
}
