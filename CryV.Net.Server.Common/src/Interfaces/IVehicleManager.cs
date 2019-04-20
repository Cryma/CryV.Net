using System.Collections.Generic;
using System.Numerics;

namespace CryV.Net.Server.Common.Interfaces
{
    public interface IVehicleManager
    {

        IVehicle AddVehicle(Vector3 position, Vector3 rotation, ulong model);
        IVehicle GetVehicle(int vehicleId);
        ICollection<IVehicle> GetVehicles();

    }
}
