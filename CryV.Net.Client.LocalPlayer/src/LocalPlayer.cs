using System;
using System.Numerics;
using System.Threading;
using System.Threading.Tasks;
using Autofac;
using CryV.Net.Client.Common.Events;
using CryV.Net.Client.Common.Helpers;
using CryV.Net.Client.Common.Interfaces;
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

        private Vector3 _lastPosition;
        private Vector3 _lastVelocity;
        private float _lastHeading;
        private Vector3 _lastAimTarget;
        private ulong _lastModel;
        private ulong _lastWeapon;
        private bool _lastAiming;

        private readonly IEventHandler _eventHandler;
        private readonly INetworkManager _networkManager;
        private readonly IEntityPool _entityPool;
        private readonly IVehicleManager _vehicleManager;

        public LocalPlayer(IEventHandler eventHandler, INetworkManager networkManager, IEntityPool entityPool, IVehicleManager vehicleManager)
        {
            _eventHandler = eventHandler;
            _networkManager = networkManager;
            _entityPool = entityPool;
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
            _entityPool.Clear();
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
            if (LocalPlayerHelper.VehicleId == -1)
            {
                return;
            }

            var vehicle = LocalPlayerHelper.Vehicle;

            var id = LocalPlayerHelper.VehicleId;
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

            var transformPayload = new VehicleUpdatePayload(id, position, velocity, rotation, 1274868363, engineState, currentGear, currentRPM, clutch,
                turbo, acceleration, brake, steeringAngle); // TODO: fix model

            _networkManager.Send(transformPayload, DeliveryMethod.Unreliable);
        }

        private void SyncLocalPlayer()
        {
            var position = Elements.LocalPlayer.Character.Position;
            var rotation = Elements.LocalPlayer.Character.Rotation;
            var velocity = Elements.LocalPlayer.Character.Velocity;
            var aimTarget = Gameplay.GetGameplayCamCoord() + Utility.GetDirection(Gameplay.GetGameplayCamRot());
            var model = Elements.LocalPlayer.Model;
            var weaponModel = Elements.LocalPlayer.Character.GetCurrentPedWeapon();
            var isAiming = Elements.LocalPlayer.Character.GetIsTaskActive(290);
            var isEnteringVehicle = Elements.LocalPlayer.Character.GetIsTaskActive(160) || Elements.LocalPlayer.Character.GetIsTaskActive(161) 
                || Elements.LocalPlayer.Character.GetIsTaskActive(162) || Elements.LocalPlayer.Character.GetIsTaskActive(163)
                || Elements.LocalPlayer.Character.GetIsTaskActive(164);
            var isInVehicle = Elements.LocalPlayer.Character.IsInAnyVehicle();

            var vehicleId = -1;
            if (isEnteringVehicle)
            {
                var vehicle = _vehicleManager.GetVehicle(Elements.LocalPlayer.Character.GetVehiclePedIsTryingToEnter());
                if (vehicle != null)
                {
                    vehicleId = vehicle.Id;
                }
            }

            var currentVehicle = Elements.LocalPlayer.Character.GetVehiclePedIsIn();

            var success = currentVehicle.DoesExist();
            if (success)
            {
                var remoteVehicle = _vehicleManager.GetVehicle(currentVehicle);

                success = remoteVehicle != null;
                if (success)
                {
                    LocalPlayerHelper.VehicleId = remoteVehicle.Id;
                    LocalPlayerHelper.Vehicle = currentVehicle;
                }
            }

            if (success == false)
            {
                LocalPlayerHelper.VehicleId = -1;
                LocalPlayerHelper.Vehicle = null;
            }

            // TODO: Better detection if something changed
            if ((position - _lastPosition).Length() < 0.05f && (velocity - _lastVelocity).Length() < 0.05f && Math.Abs(rotation.Z - _lastHeading) < 0.05f &&
                _lastModel == model && _lastWeapon == weaponModel && _lastAiming == isAiming && (aimTarget - _lastAimTarget).Length() < 0.05f)
            {
                return;
            }

            _lastPosition = position;
            _lastVelocity = velocity;
            _lastHeading = rotation.Z;
            _lastModel = model;
            _lastWeapon = weaponModel;
            _lastAiming = isAiming;
            _lastAimTarget = aimTarget;

            var transformPayload = new PlayerUpdatePayload(Id, position, velocity, rotation.Z, aimTarget, Elements.LocalPlayer.Character.Speed(),
                model, weaponModel, Elements.LocalPlayer.Character.IsPedJumping(), Elements.LocalPlayer.Character.IsPedClimbing(),
                Elements.LocalPlayer.Character.GetIsTaskActive(47), Elements.LocalPlayer.Character.IsPedRagdoll(), isAiming, isEnteringVehicle, isInVehicle, vehicleId);

            _networkManager.Send(transformPayload, DeliveryMethod.Unreliable);
        }

    }
}
