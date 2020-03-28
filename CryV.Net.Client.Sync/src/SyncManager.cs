using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using CryV.Net.Client.Common.Events;
using CryV.Net.Client.Common.Interfaces;
using CryV.Net.Elements;
using CryV.Net.Helpers;
using CryV.Net.Shared.Common.Events;
using CryV.Net.Shared.Common.Payloads;
using LiteNetLib;
using Micky5991.EventAggregator.Interfaces;
using Microsoft.Extensions.Logging;

namespace CryV.Net.Client.Sync
{
    public class SyncManager : ISyncManager, IStartable
    {

        public IVehicleManager VehicleManager { get; set; }

        private readonly List<IVehicle> _syncVehicles = new List<IVehicle>();

        private readonly IEventAggregator _eventAggregator;
        private readonly INetworkManager _networkManager;
        private readonly ILogger _logger;

            public SyncManager(IEventAggregator eventAggregator, INetworkManager networkManager, ILogger<SyncManager> logger)
        {
            _eventAggregator = eventAggregator;
            _networkManager = networkManager;
            _logger = logger;
        }

        public void Start()
        {
            _eventAggregator.Subscribe<LocalPlayerDisconnectedEvent>(OnLocalPlayerDisconnected);

            _eventAggregator.Subscribe<NetworkEvent<AddSyncPayload>>(OnSyncAdd);
            _eventAggregator.Subscribe<NetworkEvent<RemoveSyncPayload>>(OnSyncRemove);

            Task.Run(SyncLoop);
        }

        private Task OnLocalPlayerDisconnected(LocalPlayerDisconnectedEvent obj)
        {
            _syncVehicles.Clear();

            return Task.CompletedTask;
        }

        private Task OnSyncAdd(NetworkEvent<AddSyncPayload> obj)
        {
            var vehicle = VehicleManager.GetVehicle(obj.Payload.EntityId);

            if (vehicle == null)
            {
                _logger.LogWarning("Tried to add vehicle {VehicleId} to sync vehicles but it was not found!", obj.Payload.EntityId);

                return Task.CompletedTask;
            }

            if (_syncVehicles.Contains(vehicle))
            {
                _logger.LogInformation("Tried to add vehicle {VehicleId} to sync list that is already in it!", vehicle.Id);

                return Task.CompletedTask;
            }

            _syncVehicles.Add(vehicle);

            return Task.CompletedTask;
        }

        private Task OnSyncRemove(NetworkEvent<RemoveSyncPayload> obj)
        {
            var vehicle = VehicleManager.GetVehicle(obj.Payload.EntityId);

            if (_syncVehicles.Contains(vehicle) == false)
            {
                _logger.LogInformation("Tried to remove vehicle {VehicleId} from sync list that is not in it!", vehicle.Id);

                return Task.CompletedTask;
            }

            _syncVehicles.Remove(vehicle);
            
            return Task.CompletedTask;
        }

        private async Task SyncLoop()
        {
            while (true)
            {
                await Task.Delay(TimeSpan.FromMilliseconds(50));

                await ThreadHelper.RunAsync(() =>
                {
                    foreach (var vehicle in _syncVehicles)
                    {
                        SyncVehicle(vehicle);
                    }
                });
            }
        }

        private void SyncVehicle(IVehicle vehicle)
        {
            if (vehicle == null)
            {
                _logger.LogWarning("Trying to sync null vehicle!");

                return;
            }

            var nativeVehicle = vehicle.NativeVehicle;

            var id = vehicle.Id;
            var model = vehicle.Model;
            var position = nativeVehicle.Position;
            var velocity = nativeVehicle.Velocity;
            var rotation = nativeVehicle.Rotation;
            var engineState = nativeVehicle.GetIsVehicleEngineRunning();

            var currentGear = nativeVehicle.CurrentGear;
            var currentRPM = nativeVehicle.CurrentRPM;
            var clutch = nativeVehicle.Clutch;
            var turbo = nativeVehicle.Turbo;
            var acceleration = nativeVehicle.Acceleration;
            var brake = nativeVehicle.Brake;
            var steeringAngle = nativeVehicle.SteeringAngle;
            nativeVehicle.GetVehicleColours(out var colorPrimary, out var colorSecondary);
            var roofState = nativeVehicle.GetConvertibleRoofState();
            var siren = nativeVehicle.Siren;

            var trailerId = -1;
            var nativeTrailer = nativeVehicle.GetTrailer();
            if (nativeTrailer != null)
            {
                var trailer = VehicleManager.GetVehicle(nativeTrailer);
                if (trailer != null)
                {
                    trailerId = trailer.Id;
                }
            }

            var transformPayload = new VehicleUpdatePayload(id, position, velocity, rotation, nativeVehicle.EngineHealth, nativeVehicle.NumberPlate,
                model, engineState, currentGear, currentRPM, clutch, turbo, acceleration, brake, steeringAngle, colorPrimary, colorSecondary,
                LocalPlayer.IsPlayerPressingHorn(), nativeVehicle.IsVehicleInBurnout(), roofState == 0, roofState == 1, roofState == 2, roofState == 3, siren,
                trailerId);
            // TODO: Sync horn correctly

            if (vehicle.LastSentUpdatePayload != null && transformPayload.IsDifferent(vehicle.LastSentUpdatePayload) == false)
            {
                return;
            }

            vehicle.ReadPayload(transformPayload);

            vehicle.LastSentUpdatePayload = transformPayload;

            _networkManager.Send(transformPayload, DeliveryMethod.Unreliable);

        }

        public bool IsSyncingEntity(IVehicle entity)
        {
            return _syncVehicles.Contains(entity);
        }

        public ICollection<IVehicle> GetSyncedEntities()
        {
            return _syncVehicles.ToList();
        }
    }
}
