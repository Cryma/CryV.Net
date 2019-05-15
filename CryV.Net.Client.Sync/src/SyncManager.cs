﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Autofac;
using CryV.Net.Client.Common.Interfaces;
using CryV.Net.Elements;
using CryV.Net.Helpers;
using CryV.Net.Shared.Common.Interfaces;
using CryV.Net.Shared.Common.Payloads;
using CryV.Net.Shared.Events.Types;
using LiteNetLib;

namespace CryV.Net.Client.Sync.src
{
    public class SyncManager : IStartable
    {

        private readonly List<IVehicle> _syncVehicles = new List<IVehicle>();

        private readonly IEventHandler _eventHandler;
        private readonly IVehicleManager _vehicleManager;
        private readonly INetworkManager _networkManager;

        public SyncManager(IEventHandler eventHandler, IVehicleManager vehicleManager, INetworkManager networkManager)
        {
            _eventHandler = eventHandler;
            _vehicleManager = vehicleManager;
            _networkManager = networkManager;
        }

        public void Start()
        {
            _eventHandler.Subscribe<NetworkEvent<AddSyncPayload>>(OnSyncAdd);
            _eventHandler.Subscribe<NetworkEvent<RemoveSyncPayload>>(OnSyncRemove);

            Task.Run(SyncLoop);
        }

        private void OnSyncAdd(NetworkEvent<AddSyncPayload> obj)
        {
            var vehicle = _vehicleManager.GetVehicle(obj.Payload.EntityId);

            Utility.Log("Now syncing " + obj.Payload.EntityId);

            if (_syncVehicles.Contains(vehicle))
            {
                Utility.Log($"Tried to add vehicle {vehicle.Id} to sync list that is already in it!");

                return;
            }

            _syncVehicles.Add(vehicle);
        }

        private void OnSyncRemove(NetworkEvent<RemoveSyncPayload> obj)
        {
            var vehicle = _vehicleManager.GetVehicle(obj.Payload.EntityId);

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
            Utility.Log("Sync " + vehicle.Id);

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

            var transformPayload = new VehicleUpdatePayload(id, position, velocity, rotation, nativeVehicle.EngineHealth, nativeVehicle.NumberPlate,
                model, engineState, currentGear, currentRPM, clutch, turbo, acceleration, brake, steeringAngle, colorPrimary, colorSecondary,
                LocalPlayer.IsPlayerPressingHorn(), nativeVehicle.IsVehicleInBurnout(), roofState == 0, roofState == 1, roofState == 2, roofState == 3);
            // TODO: Sync horn correctly and reimplement difference check

            //if (_lastVehiclePayload != null && transformPayload.IsDifferent(_lastVehiclePayload) == false)
            //{
            //    return;
            //}

            vehicle.ReadPayload(transformPayload);

            //_lastVehiclePayload = transformPayload;

            _networkManager.Send(transformPayload, DeliveryMethod.Unreliable);

        }

    }
}