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

            EntityPool.Clear();
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

                ThreadHelper.Run(SyncLocalPlayer);
            }
        }

        private void SyncLocalPlayer()
        {
            var ped = Elements.LocalPlayer.Character;

            var position = ped.Position;
            var rotation = ped.Rotation;
            var velocity = ped.Velocity;
            var aimTarget = Gameplay.GetGameplayCamCoord() + Utility.GetDirection(Gameplay.GetGameplayCamRot(), 50.0f);
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
                    if (vehicle.NativeVehicle.GetIsVehicleEngineRunning() == false)
                    {
                        vehicle.NativeVehicle.SetVehicleEngineOn(true, true);
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
