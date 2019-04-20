﻿using System.Collections.Generic;
using System.Numerics;

namespace CryV.Net.Server.Common.Interfaces.Api
{
    public interface IVehiclePool
    {

        ICollection<IVehicle> GetVehicles();

        IVehicle CreateVehicle(Vector3 position, Vector3 rotation, ulong model);

    }
}