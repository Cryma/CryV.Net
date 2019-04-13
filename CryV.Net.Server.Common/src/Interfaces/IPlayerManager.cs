using System.Collections.Generic;
using CryV.Net.Shared.Common.Payloads;
using LiteNetLib;

namespace CryV.Net.Server.Common.Interfaces
{
    public interface IPlayerManager
    {

        void AddPlayer(NetPeer peer);
        void RemovePlayer(NetPeer peer);
        IPlayer GetPlayer(int playerId);
        ICollection<IPlayer> GetPlayers();

    }
}
