using System.Collections.Generic;
using System.Numerics;

namespace CryV.Net.Server.Common.Interfaces.Api;

public interface IVehiclePool
{

    ICollection<IServerVehicle> GetVehicles();

    IServerVehicle CreateVehicle(Vector3 position, Vector3 rotation, ulong model, string? numberPlate = null);

}
