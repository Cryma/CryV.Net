using System;
using System.Collections.Generic;
using System.Numerics;

namespace CryV.Net.Server.Common.Interfaces
{
    public interface IVehicleManager
    {

        event EventHandler<IServerVehicle> OnVehicleAdded;

        IServerVehicle AddVehicle(Vector3 position, Vector3 rotation, ulong model, string numberPlate);
        IServerVehicle GetVehicle(int vehicleId);
        ICollection<IServerVehicle> GetVehicles();

    }
}
