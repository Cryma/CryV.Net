using System.Collections.Concurrent;
using Autofac;
using CryV.Net.Client.Common.Events;
using CryV.Net.Client.Common.Interfaces;
using CryV.Net.Elements;
using CryV.Net.Shared.Common.Interfaces;
using CryV.Net.Shared.Common.Payloads;
using CryV.Net.Shared.Events.Types;

namespace CryV.Net.Client.Vehicles
{
    public class VehicleManager : IVehicleManager, IStartable
    {

        private readonly IEventHandler _eventHandler;

        private readonly ConcurrentDictionary<int, IVehicle> _vehicles = new ConcurrentDictionary<int, IVehicle>();

        public VehicleManager(IEventHandler eventHandler)
        {
            _eventHandler = eventHandler;
        }

        public void Start()
        {
            _eventHandler.Subscribe<NetworkEvent<BootstrapPayload>>(OnBootstrap);

            _eventHandler.Subscribe<NetworkEvent<VehicleAddPayload>>(OnAddVehicle);
            _eventHandler.Subscribe<NetworkEvent<VehicleRemovePayload>>(OnRemoveVehicle);

            _eventHandler.Subscribe<LocalPlayerDisconnectedEvent>(OnLocalPlayerDisconnected);
        }

        private void OnBootstrap(NetworkEvent<BootstrapPayload> obj)
        {
            if (obj.Payload.ExistingVehicles == null)
            {
                return;
            }

            foreach (var vehicle in obj.Payload.ExistingVehicles)
            {
                AddVehicle(vehicle);
            }
        }

        private void OnAddVehicle(NetworkEvent<VehicleAddPayload> obj)
        {
            AddVehicle(obj.Payload.Data);
        }

        private void OnRemoveVehicle(NetworkEvent<VehicleRemovePayload> obj)
        {
            RemoveVehicle(obj.Payload.Id);
        }

        private void OnLocalPlayerDisconnected(LocalPlayerDisconnectedEvent obj)
        {
            foreach (var vehicle in _vehicles.Values)
            {
                vehicle.Dispose();
            }

            _vehicles.Clear();
        }

        private void AddVehicle(VehicleUpdatePayload payload)
        {
            var vehicle = new Vehicle(_eventHandler, payload);
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
                if (veh.GetVehicle().Handle != vehicle.Handle)
                {
                    continue;
                }

                return veh;
            }

            return null;
        }

    }
}
