using System.Collections.Generic;

namespace CryV.Net.Server.Common.Interfaces
{
    public interface IVehicleManager
    {

        IVehicle GetVehicle(int vehicleId);
        ICollection<IVehicle> GetVehicles();

    }
}
