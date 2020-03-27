﻿using System.Collections.Concurrent;
using System.Threading.Tasks;
using Autofac;
using CryV.Net.Client.Common.Events;
using CryV.Net.Client.Common.Interfaces;
using CryV.Net.Elements;
using CryV.Net.Shared.Common.Events;
using CryV.Net.Shared.Common.Payloads;
using Micky5991.EventAggregator.Interfaces;
using Microsoft.Extensions.Logging;

namespace CryV.Net.Client.Vehicles
{
    public class VehicleManager : IVehicleManager, IStartable
    {

        private readonly IEventAggregator _eventAggregator;
        private readonly ISyncManager _syncManager;

        private readonly ConcurrentDictionary<int, IVehicle> _vehicles = new ConcurrentDictionary<int, IVehicle>();

        public VehicleManager(IEventAggregator eventAggregator, ISyncManager syncManager)
        {
            _eventAggregator = eventAggregator;
            _syncManager = syncManager;
        }

        public void Start()
        {
            _eventAggregator.Subscribe<NetworkEvent<BootstrapPayload>>(OnBootstrap);

            _eventAggregator.Subscribe<NetworkEvent<VehicleAddPayload>>(OnAddVehicle);
            _eventAggregator.Subscribe<NetworkEvent<VehicleRemovePayload>>(OnRemoveVehicle);

            _eventAggregator.Subscribe<LocalPlayerDisconnectedEvent>(OnLocalPlayerDisconnected);
        }

        private Task OnBootstrap(NetworkEvent<BootstrapPayload> obj)
        {
            if (obj.Payload.ExistingVehicles == null)
            {
                return Task.CompletedTask;
            }

            foreach (var vehicle in obj.Payload.ExistingVehicles)
            {
                AddVehicle(vehicle);
            }

            return Task.CompletedTask;
        }

        private Task OnAddVehicle(NetworkEvent<VehicleAddPayload> obj)
        {
            AddVehicle(obj.Payload.Data);

            return Task.CompletedTask;
        }

        private Task OnRemoveVehicle(NetworkEvent<VehicleRemovePayload> obj)
        {
            RemoveVehicle(obj.Payload.Id);

            return Task.CompletedTask;
        }

        private Task OnLocalPlayerDisconnected(LocalPlayerDisconnectedEvent obj)
        {
            foreach (var vehicle in _vehicles.Values)
            {
                vehicle.Dispose();
            }

            _vehicles.Clear();

            return Task.CompletedTask;
        }

        private void AddVehicle(VehicleUpdatePayload payload)
        {
            var vehicle = new Vehicle(_eventAggregator, _syncManager, payload);
            _vehicles.TryAdd(payload.Id, vehicle);
        }

        private void RemoveVehicle(int vehicleId)
        {
            if (_vehicles.TryRemove(vehicleId, out var vehicle) == false)
            {
                return;
            }

            vehicle.Dispose();
        }

        public IVehicle GetVehicle(int vehicleId)
        {
            if (_vehicles.TryGetValue(vehicleId, out var vehicle) == false)
            {
                return null;
            }

            return vehicle;
        }

        public IVehicle GetVehicle(Elements.Vehicle vehicle)
        {
            foreach (var veh in _vehicles.Values)
            {
                if (veh.NativeVehicle != vehicle)
                {
                    continue;
                }

                return veh;
            }

            return null;
        }

    }
}
