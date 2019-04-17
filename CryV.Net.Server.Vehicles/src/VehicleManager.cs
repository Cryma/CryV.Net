using System.Collections.Concurrent;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using Autofac;
using CryV.Net.Server.Common.Interfaces;
using CryV.Net.Shared.Common.Interfaces;

namespace CryV.Net.Server.Vehicles
{
    public class VehicleManager : IVehicleManager, IStartable
    {

        private readonly IEventHandler _eventHandler;
        private readonly INetworkManager _networkManager;

        private readonly ConcurrentDictionary<int, IVehicle> _vehicles = new ConcurrentDictionary<int, IVehicle>();

        public VehicleManager(IEventHandler eventHandler, INetworkManager networkManager)
        {
            _eventHandler = eventHandler;
            _networkManager = networkManager;
        }

        public void Start()
        {
            // TODO: Remove debug vehicle
            AddVehicle(new Vector3(165.1652f, -1064.867f, 29.19238f), Vector3.Zero);
        }

        public IVehicle AddVehicle(Vector3 position, Vector3 rotation)
        {
            var id = GetFreeId();

            var vehicle = new Vehicle(id, position, rotation);

            _vehicles.TryAdd(id, vehicle);

            return vehicle;
        }

        private int GetFreeId()
        {
            return Enumerable.Range(0, int.MaxValue)
                .Except(_vehicles.Keys.ToArray())
                .First();
        }

    }
}
