using System.Collections.Generic;

namespace CryV.Net.Client.Common.Interfaces
{
    public interface ISyncManager
    {
        bool IsSyncingEntity(IClientVehicle entity);

        ICollection<IClientVehicle> GetSyncedEntities();

    }
}
