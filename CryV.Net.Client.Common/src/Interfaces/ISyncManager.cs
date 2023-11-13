using System.Collections.Generic;
using Microsoft.Extensions.Hosting;

namespace CryV.Net.Client.Common.Interfaces;

public interface ISyncManager : IHostedService
{
    bool IsSyncingEntity(IClientVehicle entity);

    ICollection<IClientVehicle> GetSyncedEntities();

}
