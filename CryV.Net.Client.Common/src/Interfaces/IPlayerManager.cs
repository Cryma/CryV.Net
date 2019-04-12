using CryV.Net.Shared.Common.Payloads;

namespace CryV.Net.Client.Common.Interfaces
{
    public interface IPlayerManager
    {

        void AddPlayer(ClientUpdatePayload player);
        void RemovePlayer(int playerId);

    }
}
