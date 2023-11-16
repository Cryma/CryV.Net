using CryV.Net.Shared.Common.Payloads;
using Microsoft.Extensions.Hosting;

namespace CryV.Net.Client.Common.Interfaces;

public interface IPlayerManager : IHostedService
{

    void AddPlayer(PlayerUpdatePayload payload);
    void RemovePlayer(int playerId);
    IClientPlayer? GetPlayer(int playerId);

}
