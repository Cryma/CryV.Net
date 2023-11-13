using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;
using CryV.Net.Client.Common.Events;
using CryV.Net.Client.Common.Interfaces;
using CryV.Net.Shared.Common.Events;
using CryV.Net.Shared.Common.Payloads;
using LiteNetLib;
using Micky5991.EventAggregator.Interfaces;
using Microsoft.Extensions.Logging;

namespace CryV.Net.Client.Players
{
    public class PlayerManager : IPlayerManager
    {

        private readonly ILogger _logger;
        private readonly IEventAggregator _eventAggregator;
        private readonly IVehicleManager _vehicleManager;
        private readonly INetworkManager _networkManager;

        private readonly ConcurrentDictionary<int, IClientPlayer> _players = new ConcurrentDictionary<int, IClientPlayer>();

        public PlayerManager(ILogger<PlayerManager> logger, IEventAggregator eventAggregator, IVehicleManager vehicleManager, INetworkManager networkManager)
        {
            _logger = logger;
            _eventAggregator = eventAggregator;
            _vehicleManager = vehicleManager;
            _networkManager = networkManager;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _eventAggregator.Subscribe<NetworkEvent<BootstrapPayload>>(HandleBootstrap);
            _eventAggregator.Subscribe<NetworkEvent<PlayerAddPayload>>(OnAddPlayer);
            _eventAggregator.Subscribe<NetworkEvent<PlayerRemovePayload>>(OnRemovePlayer);

            _eventAggregator.Subscribe<LocalPlayerDisconnectedEvent>(OnLocalPlayerDisconnect);
            _eventAggregator.Subscribe<LocalPlayerBootstrapEvent>(OnBootstrap);

            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
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

        public IClientPlayer GetPlayer(int playerId)
        {
            if (_players.TryGetValue(playerId, out var player) == false)
            {
                return null;
            }

            return player;
        }

        private void HandleBootstrap(NetworkEvent<BootstrapPayload> obj)
        {
            _logger.LogDebug("Bootstrapping local player...");

            var payload = obj.Payload;

            _eventAggregator.Publish(
                new LocalPlayerBootstrapEvent(payload.LocalId, payload.StartPosition, payload.StartHeading, payload.StartModel, payload.ExistingPlayers, payload.ExistingVehicles)
            );

            _logger.LogDebug("Bootstrapping complete.");

            _networkManager.Send(new BootstrapFinishedPayload
            {
                Id = payload.LocalId
            }, DeliveryMethod.ReliableOrdered);
        }

        private Task OnBootstrap(LocalPlayerBootstrapEvent obj)
        {
            if (obj.ExistingPlayers == null)
            {
                return Task.CompletedTask;
            }

            foreach (var player in obj.ExistingPlayers)
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
