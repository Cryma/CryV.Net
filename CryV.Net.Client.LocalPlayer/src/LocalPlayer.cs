using System;
using System.Numerics;
using System.Threading;
using System.Threading.Tasks;
using Autofac;
using CryV.Net.Client.Common.Events;
using CryV.Net.Client.Common.Helpers;
using CryV.Net.Client.Common.Interfaces;
using CryV.Net.Client.Helpers;
using CryV.Net.Elements;
using CryV.Net.Enums;
using CryV.Net.Helpers;
using CryV.Net.Shared.Common.Interfaces;
using CryV.Net.Shared.Common.Payloads;
using CryV.Net.Shared.Events.Types;
using LiteNetLib;

namespace CryV.Net.Client.LocalPlayer
{
    public class LocalPlayer : IStartable
    {

        public int Id
        {
            get => LocalPlayerHelper.LocalId;
            set => LocalPlayerHelper.LocalId = value;
        }

        private CancellationTokenSource _cancellationTokenSource;

        private PlayerUpdatePayload _lastPlayerPayload;
        private VehicleUpdatePayload _lastVehiclePayload;

        private readonly IEventHandler _eventHandler;
        private readonly INetworkManager _networkManager;
        private readonly IVehicleManager _vehicleManager;

        public LocalPlayer(IEventHandler eventHandler, INetworkManager networkManager, IVehicleManager vehicleManager)
        {
            _eventHandler = eventHandler;
            _networkManager = networkManager;
            _vehicleManager = vehicleManager;
        }

        public void Start()
        {
            _eventHandler.Subscribe<NetworkEvent<BootstrapPayload>>(OnBootstrap);
            _eventHandler.Subscribe<LocalPlayerConnectedEvent>(OnLocalPlayerConnected);
            _eventHandler.Subscribe<LocalPlayerDisconnectedEvent>(OnLocalPlayerDisconnected);
        }

        private void OnLocalPlayerConnected(LocalPlayerConnectedEvent obj)
        {
        }

        private void OnLocalPlayerDisconnected(LocalPlayerDisconnectedEvent obj)
        {
            _cancellationTokenSource?.Cancel();
        }

        private void OnBootstrap(NetworkEvent<BootstrapPayload> obj)
        {
            var payload = obj.Payload;
            Id = payload.LocalId;

            ThreadHelper.Run(() =>
            {
                var rotation = Elements.LocalPlayer.Character.Rotation;

                Elements.LocalPlayer.Character.Position = payload.StartPosition;
                Elements.LocalPlayer.Model = payload.StartModel;
                Elements.LocalPlayer.Character.Rotation = new Vector3(rotation.X, rotation.Y, payload.StartHeading);

                _cancellationTokenSource = new CancellationTokenSource();
                Task.Run(Sync, _cancellationTokenSource.Token);
            });
        }

        private async Task Sync()
        {
            while (_cancellationTokenSource.IsCancellationRequested == false)
            {
                await Task.Delay(TimeSpan.FromMilliseconds(50), _cancellationTokenSource.Token);

                ThreadHelper.Run(() =>
                {
                    SyncLocalPlayer();
                    SyncVehicle();
                });
            }
        }

        private void SyncVehicle()
        {
            if (LocalPlayerHelper.VehicleId == -1 || Elements.LocalPlayer.Character.Seat != VehicleSeat.Driver)
            {
                return;
            }

            var vehicle = LocalPlayerHelper.Vehicle;

            var id = LocalPlayerHelper.VehicleId;
            var model = vehicle.Model;
            var position = vehicle.Position;
            var velocity = vehicle.Velocity;
            var rotation = vehicle.Rotation;
            var engineState = vehicle.GetIsVehicleEngineRunning();

            var currentGear = vehicle.CurrentGear;
            var currentRPM = vehicle.CurrentRPM;
            var clutch = vehicle.Clutch;
            var turbo = vehicle.Turbo;
            var acceleration = vehicle.Acceleration;
            var brake = vehicle.Brake;
            var steeringAngle = vehicle.SteeringAngle;
            vehicle.GetVehicleColours(out var colorPrimary, out var colorSecondary);
            var roofState = vehicle.GetConvertibleRoofState();

            var transformPayload = new VehicleUpdatePayload(id, position, velocity, rotation, vehicle.EngineHealth, vehicle.NumberPlate,
                model, engineState, currentGear, currentRPM, clutch, turbo, acceleration, brake, steeringAngle, colorPrimary, colorSecondary,
                Elements.LocalPlayer.IsPlayerPressingHorn(), vehicle.IsVehicleInBurnout(), roofState == 0, roofState == 1, roofState == 2, roofState == 3);

            if (_lastVehiclePayload != null && transformPayload.IsDifferent(_lastVehiclePayload) == false)
            {
                return;
            }

            _lastVehiclePayload = transformPayload;

            _networkManager.Send(transformPayload, DeliveryMethod.Unreliable);
        }

        private void SyncLocalPlayer()
        {
            var ped = Elements.LocalPlayer.Character;

            var position = ped.Position;
            var rotation = ped.Rotation;
            var velocity = ped.Velocity;
            var aimTarget = Gameplay.GetGameplayCamCoord() + Utility.GetDirection(Gameplay.GetGameplayCamRot());
            var model = Elements.LocalPlayer.Model;
            var weaponModel = ped.GetCurrentPedWeapon();
            var isAiming = ped.GetIsTaskActive(290);
            var isEnteringVehicle = ped.IsEnteringVehicle();
            var isInVehicle = ped.IsInAnyVehicle();
            var isLeavingVehicle = ped.IsLeavingVehicle();
            var vehicleId = GetDesiredVehicleId();
            var seat = isEnteringVehicle ? ped.GetSeatPedIsTryingToEnter() : ped.Seat;

            var transformPayload = new PlayerUpdatePayload(Id, position, velocity, rotation.Z, aimTarget, Elements.LocalPlayer.Character.Speed(),
                model, weaponModel, ped.IsPedJumping(), ped.IsPedClimbing(), ped.IsClimbingLadder(), ped.IsPedRagdoll(), isAiming, isEnteringVehicle,
                isInVehicle, vehicleId, (int) seat, isLeavingVehicle);

            if (_lastPlayerPayload != null && transformPayload.IsDifferent(_lastPlayerPayload) == false)
            {
                return;
            }

            _lastPlayerPayload = transformPayload;

            _networkManager.Send(transformPayload, DeliveryMethod.Unreliable);
        }

        private int GetDesiredVehicleId()
        {
            var ped = Elements.LocalPlayer.Character;

            if (ped.IsEnteringVehicle())
            {
                var vehicle = _vehicleManager.GetVehicle(ped.GetVehiclePedIsTryingToEnter());
                if (vehicle != null)
                {
                    if (vehicle.GetVehicle().GetIsVehicleEngineRunning() == false)
                    {
                        vehicle.GetVehicle().SetVehicleEngineOn(true, true);
                    }

                    LocalPlayerHelper.SetVehicle(vehicle);

                    return vehicle.Id;
                }
            }
            else if (ped.IsInAnyVehicle())
            {
                var vehicle = _vehicleManager.GetVehicle(ped.GetVehiclePedIsIn());
                if (vehicle != null)
                {
                    LocalPlayerHelper.SetVehicle(vehicle);

                    return vehicle.Id;
                }
            }
            else if (ped.IsLeavingVehicle())
            {
                var vehicle = _vehicleManager.GetVehicle(ped.GetLastVehiclePedIsIn());
                if (vehicle != null)
                {
                    LocalPlayerHelper.SetVehicle(vehicle);

                    return vehicle.Id;
                }
            }

            LocalPlayerHelper.SetVehicle(null);

            return -1;
        }

    }
}
