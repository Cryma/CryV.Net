﻿using System;
using System.Collections.Generic;
using System.Numerics;

namespace CryV.Net.Server.Common.Interfaces
{
    public interface IVehicleManager
    {

        event EventHandler<IVehicle> OnVehicleAdded;

        IVehicle AddVehicle(Vector3 position, Vector3 rotation, ulong model, string numberPlate);
        IVehicle GetVehicle(int vehicleId);
        ICollection<IVehicle> GetVehicles();

    }
}
