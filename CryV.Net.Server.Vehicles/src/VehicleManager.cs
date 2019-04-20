using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using Autofac;
using CryV.Net.Server.Common.Interfaces;
using CryV.Net.Shared.Common.Interfaces;

namespace CryV.Net.Server.Vehicles
{
    public class VehicleManager : IVehicleManager, IStartable
    {

        public IPlayerManager PlayerManager { get; set; }

        private readonly IEventHandler _eventHandler;

        private readonly ConcurrentDictionary<int, IVehicle> _vehicles = new ConcurrentDictionary<int, IVehicle>();

        public VehicleManager(IEventHandler eventHandler)
        {
            _eventHandler = eventHandler;
        }

        public void Start()
        {
        }

        public IVehicle AddVehicle(Vector3 position, Vector3 rotation, ulong model)
        {
            var id = GetFreeId();

            var vehicle = new Vehicle(this, _eventHandler, PlayerManager, id, position, rotation, model);

            _vehicles.TryAdd(id, vehicle);

            return vehicle;
        }

        public void RemoveVehicle(int vehicleId)
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

        public ICollection<IVehicle> GetVehicles()
        {
            return _vehicles.Values;
        }

        private int GetFreeId()
        {
            return Enumerable.Range(0, int.MaxValue)
                .Except(_vehicles.Keys.ToArray())
                .First();
        }

    }
}
