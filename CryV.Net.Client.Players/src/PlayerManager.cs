using System.Collections.Concurrent;
using System.Threading.Tasks;
using Autofac;
using CryV.Net.Client.Common.Events;
using CryV.Net.Client.Common.Interfaces;
using CryV.Net.Elements;
using CryV.Net.Shared.Common.Events;
using CryV.Net.Shared.Common.Payloads;
using Micky5991.EventAggregator.Interfaces;

namespace CryV.Net.Client.Players
{
    public class PlayerManager : IPlayerManager, IStartable
    {

        private readonly IEventAggregator _eventAggregator;
        private readonly IVehicleManager _vehicleManager;

        private readonly ConcurrentDictionary<int, IPlayer> _players = new ConcurrentDictionary<int, IPlayer>();

        public PlayerManager(IEventAggregator eventAggregator, IVehicleManager vehicleManager)
        {
            _eventAggregator = eventAggregator;
            _vehicleManager = vehicleManager;
        }

        public void Start()
        {
            _eventAggregator.Subscribe<NetworkEvent<BootstrapPayload>>(OnBootstrap);
            _eventAggregator.Subscribe<NetworkEvent<PlayerAddPayload>>(OnAddPlayer);
            _eventAggregator.Subscribe<NetworkEvent<PlayerRemovePayload>>(OnRemovePlayer);

            _eventAggregator.Subscribe<LocalPlayerDisconnectedEvent>(OnLocalPlayerDisconnect);
        }

        private Task OnLocalPlayerDisconnect(LocalPlayerDisconnectedEvent obj)
        {
            foreach (var player in _players.Values)
            {
                _eventAggregator.Publish(new PlayerDisconnectedEvent(player));

                player.Dispose();
            }

            _players.Clear();

            return Task.CompletedTask;
        }

        public void AddPlayer(PlayerUpdatePayload payload)
        {
            var player = new Player(_eventAggregator, _vehicleManager, payload);

            _players.TryAdd(payload.Id, player);

            _eventAggregator.Publish(new PlayerConnectedEvent(player));
        }

        public void RemovePlayer(int playerId)
        {
            if (_players.TryRemove(playerId, out var player) == false)
            {
                return;
            }

            _eventAggregator.Publish(new PlayerDisconnectedEvent(player));

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

        private Task OnBootstrap(NetworkEvent<BootstrapPayload> obj)
        {
            if (obj.Payload.ExistingPlayers == null)
            {
                return Task.CompletedTask;
            }

            foreach (var player in obj.Payload.ExistingPlayers)
            {
                AddPlayer(player);
            }

            return Task.CompletedTask;
        }

        private Task OnAddPlayer(NetworkEvent<PlayerAddPayload> obj)
        {
            AddPlayer(obj.Payload.Data);

            return Task.CompletedTask;
        }

        private Task OnRemovePlayer(NetworkEvent<PlayerRemovePayload> obj)
        {
            RemovePlayer(obj.Payload.Id);

            return Task.CompletedTask;
        }

    }
}
