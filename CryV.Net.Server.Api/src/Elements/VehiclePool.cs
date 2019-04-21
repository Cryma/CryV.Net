using System.Collections.Generic;
using System.Numerics;
using CryV.Net.Server.Common.Interfaces;
using CryV.Net.Server.Common.Interfaces.Api;

namespace CryV.Net.Server.Api.Elements
{
    public class VehiclePool : IVehiclePool
    {

        private readonly IVehicleManager _vehicleManager;

        public VehiclePool(IVehicleManager vehicleManager)
        {
            _vehicleManager = vehicleManager;
        }

        public ICollection<IVehicle> GetVehicles()
        {
            return _vehicleManager.GetVehicles();
        }

        public IVehicle CreateVehicle(Vector3 position, Vector3 rotation, ulong model, string numberPlate = null)
        {
            return _vehicleManager.AddVehicle(position, rotation, model, numberPlate);
        }

    }
}
