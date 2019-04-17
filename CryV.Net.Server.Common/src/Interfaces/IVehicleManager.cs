using System.Collections.Generic;

namespace CryV.Net.Server.Common.Interfaces
{
    public interface IVehicleManager
    {

        ICollection<IVehicle> GetVehicles();

    }
}
