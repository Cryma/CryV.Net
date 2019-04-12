using System.Collections.Concurrent;
using Autofac;
using CryV.Net.Client.Common.Interfaces;
using CryV.Net.Shared.Common.Interfaces;
using CryV.Net.Shared.Common.Payloads;
using CryV.Net.Shared.Events.Types;

namespace CryV.Net.Client.Players
{
    public class PlayerManager : IPlayerManager, IStartable
    {

        private readonly IEventHandler _eventHandler;

        private readonly ConcurrentDictionary<int, IPlayer> _players = new ConcurrentDictionary<int, IPlayer>();

        public PlayerManager(IEventHandler eventHandler)
        {
            _eventHandler = eventHandler;
        }

        public void Start()
        {
            _eventHandler.Subscribe<NetworkEvent<BootstrapPayload>>(OnBootstrap);
        }

        private void OnBootstrap(NetworkEvent<BootstrapPayload> obj)
        {
            foreach (var player in obj.Payload.ExistingPlayers)
            {
                AddPlayer(player);
            }
        }

        public void AddPlayer(ClientUpdatePayload player)
        {
            _players.TryAdd(player.Id, new Player(_eventHandler, player));
        }

        public void RemovePlayer(int playerId)
        {
            if (_players.TryRemove(playerId, out var player) == false)
            {
                return;
            }

            player.Dispose();
        }

    }
}
