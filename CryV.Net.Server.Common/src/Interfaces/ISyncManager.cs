﻿using System.Collections.Generic;

namespace CryV.Net.Server.Common.Interfaces
{
    public interface ISyncManager
    {

        bool IsEntitySyncedByPlayer(IServerVehicle vehicle, IServerPlayer player);

    }
}
