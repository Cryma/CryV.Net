using System.Collections.Concurrent;
using Autofac;
using CryV.Net.Client.Common.Events;
using CryV.Net.Client.Common.Interfaces;
using CryV.Net.Elements;
using CryV.Net.Shared.Common.Interfaces;
using CryV.Net.Shared.Common.Payloads;
using CryV.Net.Shared.Events.Types;

namespace CryV.Net.Client.Players
{
    public class PlayerManager : IPlayerManager, IStartable
    {

        private readonly IEventHandler _eventHandler;
        private readonly IVehicleManager _vehicleManager;

        private readonly ConcurrentDictionary<int, IPlayer> _players = new ConcurrentDictionary<int, IPlayer>();

        public PlayerManager(IEventHandler eventHandler, IVehicleManager vehicleManager)
        {
            _eventHandler = eventHandler;
            _vehicleManager = vehicleManager;
        }

        public void Start()
        {
            _eventHandler.Subscribe<NetworkEvent<BootstrapPayload>>(OnBootstrap);
            _eventHandler.Subscribe<NetworkEvent<PlayerAddPayload>>(OnAddPlayer);
            _eventHandler.Subscribe<NetworkEvent<PlayerRemovePayload>>(OnRemovePlayer);

            _eventHandler.Subscribe<LocalPlayerDisconnectedEvent>(OnLocalPlayerDisconnect);
        }

        private void OnLocalPlayerDisconnect(LocalPlayerDisconnectedEvent obj)
        {
            foreach (var player in _players.Keys)
            {
                RemovePlayer(player);
            }
        }

        public void AddPlayer(PlayerUpdatePayload payload)
        {
            var player = new Player(_eventHandler, _vehicleManager, payload);

            _players.TryAdd(payload.Id, player);

            _eventHandler.Publish(new PlayerConnectedEvent(player));
        }

        public void RemovePlayer(int playerId)
        {
            if (_players.TryRemove(playerId, out var player) == false)
            {
                return;
            }

            _eventHandler.Publish(new PlayerDisconnectedEvent(player));

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

        private void OnAddPlayer(NetworkEvent<PlayerAddPayload> obj)
        {
            AddPlayer(obj.Payload.Data);
        }

        private void OnRemovePlayer(NetworkEvent<PlayerRemovePayload> obj)
        {
            RemovePlayer(obj.Payload.Id);
        }

    }
}
