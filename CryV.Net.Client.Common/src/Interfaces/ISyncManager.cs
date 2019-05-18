using System.Collections.Generic;

namespace CryV.Net.Client.Common.Interfaces
{
    public interface ISyncManager
    {
        bool IsSyncingEntity(IVehicle entity);

        ICollection<IVehicle> GetSyncedEntities();

    }
}
