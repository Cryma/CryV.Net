﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using CryV.Net.Client.Common.Events;
using CryV.Net.Client.Common.Interfaces;
using CryV.Net.Elements;
using CryV.Net.Helpers;
using CryV.Net.Shared.Common.Interfaces;
using CryV.Net.Shared.Common.Payloads;
using CryV.Net.Shared.Events.Types;
using LiteNetLib;

namespace CryV.Net.Client.Sync
{
    public class SyncManager : ISyncManager, IStartable
    {

        public IVehicleManager VehicleManager { get; set; }

        private readonly List<IVehicle> _syncVehicles = new List<IVehicle>();

        private readonly IEventHandler _eventHandler;
        private readonly INetworkManager _networkManager;

        public SyncManager(IEventHandler eventHandler, INetworkManager networkManager)
        {
            _eventHandler = eventHandler;
            _networkManager = networkManager;
        }

        public void Start()
        {
            _eventHandler.Subscribe<LocalPlayerDisconnectedEvent>(OnLocalPlayerDisconnected);

            _eventHandler.Subscribe<NetworkEvent<AddSyncPayload>>(OnSyncAdd);
            _eventHandler.Subscribe<NetworkEvent<RemoveSyncPayload>>(OnSyncRemove);

            Task.Run(SyncLoop);
        }

        private void OnLocalPlayerDisconnected(LocalPlayerDisconnectedEvent obj)
        {
            _syncVehicles.Clear();
        }

        private void OnSyncAdd(NetworkEvent<AddSyncPayload> obj)
        {
            var vehicle = VehicleManager.GetVehicle(obj.Payload.EntityId);

            if (_syncVehicles.Contains(vehicle))
            {
                Utility.Log($"Tried to add vehicle {vehicle.Id} to sync list that is already in it!");

                return;
            }

            _syncVehicles.Add(vehicle);
        }

        private void OnSyncRemove(NetworkEvent<RemoveSyncPayload> obj)
        {
            var vehicle = VehicleManager.GetVehicle(obj.Payload.EntityId);

            if (_syncVehicles.Contains(vehicle) == false)
            {
                Utility.Log($"Tried to remove vehicle {vehicle.Id} from sync list that is not in it!");

                return;
            }

            _syncVehicles.Remove(vehicle);
        }

        private async Task SyncLoop()
        {
            while (true)
            {
                await Task.Delay(TimeSpan.FromMilliseconds(50));

                ThreadHelper.Run(() =>
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

            var transformPayload = new VehicleUpdatePayload(id, position, velocity, rotation, nativeVehicle.EngineHealth, nativeVehicle.NumberPlate,
                model, engineState, currentGear, currentRPM, clutch, turbo, acceleration, brake, steeringAngle, colorPrimary, colorSecondary,
                LocalPlayer.IsPlayerPressingHorn(), nativeVehicle.IsVehicleInBurnout(), roofState == 0, roofState == 1, roofState == 2, roofState == 3, siren);
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
