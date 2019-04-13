using System.Collections.Concurrent;
using Autofac;
using CryV.Net.Client.Common.Events;
using CryV.Net.Client.Common.Interfaces;
using CryV.Net.Shared.Common.Interfaces;
using CryV.Net.Shared.Common.Payloads;
using CryV.Net.Shared.Events.Types;

namespace CryV.Net.Client.Players
{
    public class PlayerManager : IPlayerManager, IStartable
    {

        private readonly IEventHandler _eventHandler;
        private readonly IEntityPool _entityPool;

        private readonly ConcurrentDictionary<int, IPlayer> _players = new ConcurrentDictionary<int, IPlayer>();

        public PlayerManager(IEventHandler eventHandler, IEntityPool entityPool)
        {
            _eventHandler = eventHandler;
            _entityPool = entityPool;
        }

        public void Start()
        {
            _eventHandler.Subscribe<NetworkEvent<BootstrapPayload>>(OnBootstrap);
            _eventHandler.Subscribe<NetworkEvent<AddClientPayload>>(OnAddClient);
            _eventHandler.Subscribe<NetworkEvent<RemoveClientPayload>>(OnRemoveClient);

            _eventHandler.Subscribe<LocalPlayerDisconnectedEvent>(OnLocalPlayerDisconnect);
        }

        private void OnLocalPlayerDisconnect(LocalPlayerDisconnectedEvent obj)
        {
            foreach (var player in _players.Keys)
            {
                RemovePlayer(player);
            }
        }

        public void AddPlayer(ClientUpdatePayload player)
        {
            _players.TryAdd(player.Id, new Player(_eventHandler, _entityPool, player));
        }

        public void RemovePlayer(int playerId)
        {
            if (_players.TryRemove(playerId, out var player) == false)
            {
                return;
            }

            player.Dispose();
        }

        public IPlayer GetPlayer(int playerId)
        {
            if (_players.TryGetValue(playerId, out var player) == false)
            {
                return null;
            }

            return player;
        }

        private void OnBootstrap(NetworkEvent<BootstrapPayload> obj)
        {
            if (obj.Payload.ExistingPlayers == null)
            {
                return;
            }

            foreach (var player in obj.Payload.ExistingPlayers)
            {
                AddPlayer(player);
            }
        }

        private void OnAddClient(NetworkEvent<AddClientPayload> obj)
        {
            AddPlayer(obj.Payload.Data);
        }

        private void OnRemoveClient(NetworkEvent<RemoveClientPayload> obj)
        {
            RemovePlayer(obj.Payload.Id);
        }

    }
}
