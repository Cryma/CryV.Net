using System.Collections.Generic;
using CryV.Net.Server.Common.Interfaces;
using CryV.Net.Server.Common.Interfaces.Api;

namespace CryV.Net.Server.Api.Elements
{
    public class PlayerPool : IPlayerPool
    {

        private readonly IPlayerManager _playerManager;

        public PlayerPool(IPlayerManager playerManager)
        {
            _playerManager = playerManager;
        }

        public ICollection<IServerPlayer> GetPlayers()
        {
            return _playerManager.GetPlayers(onlyConnected: false);
        }

    }
}
