using System;
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
        IPlayer GetPlayer(NetPeer peer);
        ICollection<IPlayer> GetPlayers(Func<IPlayer, bool> filter = null, bool onlyConnected = true);

    }
}
