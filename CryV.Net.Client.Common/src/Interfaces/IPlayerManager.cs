using CryV.Net.Shared.Common.Payloads;

namespace CryV.Net.Client.Common.Interfaces
{
    public interface IPlayerManager
    {

        void AddPlayer(PlayerUpdatePayload payload);
        void RemovePlayer(int playerId);
        IClientPlayer GetPlayer(int playerId);

    }
}
