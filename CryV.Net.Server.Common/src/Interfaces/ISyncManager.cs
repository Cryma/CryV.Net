using Microsoft.Extensions.Hosting;

namespace CryV.Net.Server.Common.Interfaces;

public interface ISyncManager : IHostedService
{

    bool IsEntitySyncedByPlayer(IServerVehicle vehicle, IServerPlayer player);

}
