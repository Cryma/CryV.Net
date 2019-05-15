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


        public Elements.Vehicle NativeVehicle { get; private set; }

        private VehicleUpdatePayload _lastPayload;

        private readonly List<ISubscription> _eventSubscriptions = new List<ISubscription>();

        private readonly IEventHandler _eventHandler;

        public Vehicle(IEventHandler eventHandler, VehicleUpdatePayload payload)
        {
            _eventHandler = eventHandler;
            _lastPayload = payload;

            Id = payload.Id;
            
            ReadPayload(payload);

            _eventSubscriptions.Add(_eventHandler.Subscribe<NetworkEvent<VehicleUpdatePayload>>(update =>
            {
                ReadPayload(update.Payload);

                if (LocalPlayerHelper.Vehicle == NativeVehicle && LocalPlayer.Character.Seat == VehicleSeat.Driver)
                {
                    ForceSync();
                }
            }, x => x.Payload.Id == Id));

            ThreadHelper.Run(() =>
            {
                NativeVehicle = new Elements.Vehicle(Model, Position, Rotation, Velocity, payload.ColorPrimary, payload.ColorSecondary, payload.NumberPlate)
                {
                    EngineHealth = EngineHealth
                };

                if (EngineHealth < 0.0f)
                {
                    NativeVehicle.Explode(false, true);
                }
            });

            NativeHelper.OnNativeTick += Tick;
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

            _lastPayload = payload;
        }

        private void CheckForChanges()
        {
            if (EngineState != _lastPayload.EngineState)
            {
                NativeVehicle.SetVehicleEngineOn(_lastPayload.EngineState, true);

                EngineState = _lastPayload.EngineState;
            }

            if (ColorPrimary != _lastPayload.ColorPrimary || ColorSecondary != _lastPayload.ColorSecondary)
            {
                NativeVehicle.SetVehicleColours(_lastPayload.ColorPrimary, _lastPayload.ColorSecondary);

                ColorPrimary = _lastPayload.ColorPrimary;
                ColorSecondary = _lastPayload.ColorSecondary;
            }

            if (NumberPlate != _lastPayload.NumberPlate)
            {
                NativeVehicle.NumberPlate = _lastPayload.NumberPlate;

                NumberPlate = _lastPayload.NumberPlate;
            }
        }

        public VehicleUpdatePayload GetPayload()
        {
            return new VehicleUpdatePayload(Id, Position, NativeVehicle.Velocity, Rotation, EngineHealth, NumberPlate, Model, EngineState, CurrentGear,
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
            CheckForChanges();

            NativeVehicle.Rotation = Interpolation.LerpRotation(NativeVehicle.Rotation, Rotation, deltaTime * 5);

            if (Vector3.DistanceSquared(NativeVehicle.Position, Position) > 9.0f)
            {
                NativeVehicle.Position = Position;
            }

            var positionDifference = Position - NativeVehicle.Position;
            NativeVehicle.Velocity = Velocity + positionDifference;

            NativeVehicle.CurrentGear = CurrentGear;
            NativeVehicle.CurrentRPM = CurrentRPM;
            NativeVehicle.Clutch = Clutch;
            NativeVehicle.Turbo = Turbo;
            NativeVehicle.Acceleration = Acceleration;
            NativeVehicle.Brake = Brake;
            NativeVehicle.SteeringAngle = Interpolation.Lerp(NativeVehicle.SteeringAngle, TargetSteeringAngle, deltaTime * 5);

            ExecutionHelper.ExecuteOnce($"VEHICLE_{Id}_RAISEROOF", IsRoofRaising, () =>
            {
                NativeVehicle.RaiseConvertibleRoof(false);
            });

            ExecutionHelper.ExecuteOnce($"VEHICLE_{Id}_LOWERROOF", IsRoofLowering, () =>
            {
                NativeVehicle.LowerConvertibleRoof(false);
            });

            ExecutionHelper.ExecuteOnce($"VEHICLE_{Id}_HORN", IsHornActive, () =>
            {
                NativeVehicle.StartVehicleHorn(9999);
            }, () =>
            {
                NativeVehicle.StartVehicleHorn(1);
            });

            ExecutionHelper.ExecuteOnce($"VEHICLE_{Id}_BURNOUT", IsBurnout, () =>
            {
                var driver = NativeVehicle.GetPedOnSeat(-1);
                driver?.TaskVehicleTempAction(NativeVehicle, 23, 9999);

                NativeVehicle.SetVehicleBurnout(true);
            }, () =>
            {
                var driver = NativeVehicle.GetPedOnSeat(-1);
                driver?.TaskVehicleTempAction(NativeVehicle, 6, 1);
                driver?.ClearPedTasks();

                NativeVehicle.SetVehicleBurnout(false);
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
                NativeVehicle?.Delete();
            });
        }

    }
}
