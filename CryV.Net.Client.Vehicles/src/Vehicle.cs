using System.Collections.Generic;
using System.Numerics;
using System.Threading.Tasks;
using CryV.Net.Client.Common.Helpers;
using CryV.Net.Client.Common.Interfaces;
using CryV.Net.Helpers;
using CryV.Net.Shared.Common.Events;
using CryV.Net.Shared.Common.Flags;
using CryV.Net.Shared.Common.Payloads;
using Micky5991.EventAggregator.Interfaces;
using Microsoft.Extensions.Logging;

namespace CryV.Net.Client.Vehicles
{
    public class Vehicle : IClientVehicle
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

        public bool IsSirenActive { get; set; }

        public IClientVehicle Trailer { get; set; }

        public Elements.Vehicle NativeVehicle { get; private set; }

        public bool IsAttachedTrailer
        {
            get => _isAttachedTrailer;
            set
            {
                if (value)
                {
                    NativeHelper.OnNativeTick += TrailerTick;
                }
                else
                {
                    NativeHelper.OnNativeTick -= TrailerTick;
                }

                _isAttachedTrailer = value;
            }
        }

        private bool _isAttachedTrailer;

        public VehicleUpdatePayload LastSentUpdatePayload { get; set; }

        private VehicleUpdatePayload _lastPayload;

        private readonly List<ISubscription> _eventSubscriptions = new List<ISubscription>();

        private readonly ILogger _logger;
        private readonly IEventAggregator _eventAggregator;
        private readonly ISyncManager _syncManager;
        private readonly IVehicleManager _vehicleManager;

        public Vehicle(ILogger logger, IEventAggregator eventAggregator, ISyncManager syncManager, IVehicleManager vehicleManager, VehicleUpdatePayload payload)
        {
            _logger = logger;
            _eventAggregator = eventAggregator;
            _syncManager = syncManager;
            _vehicleManager = vehicleManager;
            _lastPayload = payload;

            Id = payload.Id;
            
            ReadPayload(payload);

            _eventSubscriptions.Add(_eventAggregator.Subscribe<NetworkEvent<VehicleUpdatePayload>>(async update =>
            {
                ReadPayload(update.Payload);

                if (_syncManager.IsSyncingEntity(this))
                {
                    await ForceSync();
                }
            }, x => Task.FromResult(x.Payload.Id == Id)));

            ThreadHelper.RunAsync(() =>
            {
                NativeVehicle = new Elements.Vehicle(Model, Position, Rotation, Velocity, payload.ColorPrimary, payload.ColorSecondary, payload.NumberPlate)
                {
                    EngineHealth = EngineHealth
                };

                if (IsRoofDown || IsRoofLowering)
                {
                    NativeVehicle.LowerConvertibleRoof(true);
                }

                if (IsSirenActive)
                {
                    NativeVehicle.Siren = true;
                }
            }).Wait();

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
            IsSirenActive = (payload.VehicleData & (int) VehicleData.IsSirenActive) > 0;

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

            if (Trailer == null && _lastPayload.TrailerId != -1)
            {
                Trailer = _vehicleManager.GetVehicle(_lastPayload.TrailerId);
                if (Trailer == null)
                {
                    _logger.LogWarning("Could not find trailer {TrailerId} for vehicle {VehicleId} in vehicle manager!", _lastPayload.TrailerId, Id);
                }
                else
                {
                    // TODO: Use ATTACH_VEHICLE_ON_TO_TRAILER native to attach with a specific offset
                    NativeVehicle.AttachToTrailer(Trailer.NativeVehicle);
                    Trailer.IsAttachedTrailer = true;
                }
            }

            if (Trailer != null && _lastPayload.TrailerId == -1)
            {
                NativeVehicle.DetachFromTrailer();
                Trailer.NativeVehicle.SetTrailerLegsLowered();
                Trailer.IsAttachedTrailer = false;

                Trailer = null;
            }
        }

        public VehicleUpdatePayload GetPayload()
        {
            return new VehicleUpdatePayload(Id, Position, NativeVehicle.Velocity, Rotation, EngineHealth, NumberPlate, Model, EngineState, CurrentGear,
                CurrentRPM, Clutch, Turbo, Acceleration, Brake, TargetSteeringAngle, ColorPrimary, ColorSecondary, IsHornActive, IsBurnout, IsRoofUp, IsRoofLowering,
                IsRoofDown, IsRoofRaising, IsSirenActive, Trailer.Id);
        }

        private void Tick(float deltatime)
        {
            if (_syncManager.IsSyncingEntity(this))
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

            Trailer?.NativeVehicle?.SetTrailerLegsRaised();

            ExecutionHelper.Execute($"VEHICLE_{Id}_RAISEROOF", IsRoofRaising, () =>
            {
                NativeVehicle.RaiseConvertibleRoof(false);
            });

            ExecutionHelper.Execute($"VEHICLE_{Id}_LOWERROOF", IsRoofLowering, () =>
            {
                NativeVehicle.LowerConvertibleRoof(false);
            });

            ExecutionHelper.Execute($"VEHICLE_{Id}_HORN", IsHornActive, () =>
            {
                NativeVehicle.StartVehicleHorn(9999);
            }, onReset: () =>
            {
                NativeVehicle.StartVehicleHorn(1);
            });

            ExecutionHelper.Execute($"VEHICLE_{Id}_BURNOUT", IsBurnout, () =>
            {
                var driver = NativeVehicle.GetPedOnSeat(-1);
                driver?.TaskVehicleTempAction(NativeVehicle, 23, 9999);

                NativeVehicle.SetVehicleBurnout(true);
            }, onReset: () =>
            {
                var driver = NativeVehicle.GetPedOnSeat(-1);
                driver?.TaskVehicleTempAction(NativeVehicle, 6, 1);
                driver?.ClearPedTasks();

                NativeVehicle.SetVehicleBurnout(false);
            });

            ExecutionHelper.Execute($"VEHICLE_{Id}_SIREN", IsSirenActive,
                () => NativeVehicle.Siren = true,
                onReset: () => NativeVehicle.Siren = false
            );
        }

        private void TrailerTick(float deltaTime)
        {
            NativeVehicle.SetTrailerLegsRaised();
        }

        private Task ForceSync()
        {
            return ThreadHelper.RunAsync(() => Sync(1.0f));
        }

        public void Dispose()
        {
            foreach (var subscription in _eventSubscriptions)
            {
                subscription.Dispose();
            }

            NativeHelper.OnNativeTick -= Tick;

            ThreadHelper.RunAsync(() => NativeVehicle?.Delete()).Wait();
        }

    }
}
