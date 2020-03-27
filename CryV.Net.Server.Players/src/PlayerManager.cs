using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Autofac;
using CryV.Net.Server.Common.Events;
using CryV.Net.Server.Common.Interfaces;
using CryV.Net.Shared.Common.Events;
using CryV.Net.Shared.Common.Payloads;
using LiteNetLib;
using Micky5991.EventAggregator.Interfaces;
using Microsoft.Extensions.Logging;

namespace CryV.Net.Server.Players
{
    public class PlayerManager : IPlayerManager, IStartable
    {

        private readonly IEventAggregator _eventAggregator;
        private readonly IVehicleManager _vehicleManager;
        private readonly ILogger _logger;

        private readonly ConcurrentDictionary<int, IPlayer> _players = new ConcurrentDictionary<int, IPlayer>();

        public PlayerManager(IEventAggregator eventAggregator, IVehicleManager vehicleManager, ILogger<PlayerManager> logger)
        {
            _eventAggregator = eventAggregator;
            _vehicleManager = vehicleManager;
            _logger = logger;
        }

        public void Start()
        {
            _eventAggregator.Subscribe<NetworkEvent<PlayerUpdatePayload>>(OnPlayerUpdate);
        }

        public void AddPlayer(NetPeer peer)
        {
            var player = new Player(_eventAggregator, _vehicleManager, _logger, peer);
            _players.TryAdd(peer.Id, player);

            BootstrapPlayer(player);
            PropagatePlayerAddition(player);

            _eventAggregator.Publish(new PlayerConnectedEvent(player));
        }

        public void RemovePlayer(NetPeer peer)
        {
            if (_players.TryRemove(peer.Id, out var player) == false)
            {
                return;
            }

            player.Dispose();
            PropagatePlayerRemoval(player);

            _eventAggregator.Publish(new PlayerDisconnectedEvent(player));
        }

        public IPlayer GetPlayer(int playerId)
        {
            if (_players.TryGetValue(playerId, out var player) == false)
            {
                return null;
            }

            return player;
        }

        public IPlayer GetPlayer(NetPeer peer)
        {
            foreach (var player in _players.Values)
            {
                if (player.GetPeer() != peer)
                {
                    continue;
                }

                return player;
            }

            return null;
        }

        public ICollection<IPlayer> GetPlayers()
        {
            return _players.Values.ToList();
        }

        private Task OnPlayerUpdate(NetworkEvent<PlayerUpdatePayload> obj)
        {
            var payload = obj.Payload;

            if (_players.TryGetValue(payload.Id, out var targetPlayer) == false)
            {
                _logger.LogWarning("Received update from player {PlayerId}, but could not find it in PlayerManager!", payload.Id);

                return Task.CompletedTask;
            }

            targetPlayer.ReadPayload(payload);

            foreach (var player in GetPlayers())
            {
                if (player == targetPlayer)
                {
#if PEDMIRROR
                    payload.Id = 1;
                    payload.Position.X -= 4.0f;

                    player.Send(payload, DeliveryMethod.Unreliable);
#endif
                    continue;
                }

                player.Send(payload, DeliveryMethod.Unreliable);
            }

            return Task.CompletedTask;
        }

        private void BootstrapPlayer(IPlayer player)
        {
            var existingPlayerPayloads = GetPlayers().Where(x => x != player).Select(x => x.GetPayload()).ToList();
            var existingVehiclePaylaods = _vehicleManager.GetVehicles().Select(x => x.GetPayload()).ToList();

#if PEDMIRROR
            var payload = player.GetPayload();

            payload.Id = 1;
            payload.Position.X -= 5.0f;

            existingPlayerPayloads.Add(payload);
#endif

            var bootstrapPayload = new BootstrapPayload(player.GetPeer().Id, player.Position, player.Heading, player.Model, existingPlayerPayloads, existingVehiclePaylaods);

            player.Send(bootstrapPayload, DeliveryMethod.ReliableOrdered);
        }

        private void PropagatePlayerAddition(IPlayer player)
        {
            foreach (var existingPlayer in GetPlayers())
            {
                if (existingPlayer == player)
                {
                    continue;
                }

                existingPlayer.Send(player.GetPayload(), DeliveryMethod.ReliableOrdered);
                existingPlayer.Send(new PlayerAddPayload(player.GetPayload()), DeliveryMethod.ReliableOrdered);
            }
        }

        private void PropagatePlayerRemoval(IPlayer player)
        {
            foreach (var existingPlayer in GetPlayers())
            {
                if (existingPlayer == player)
                {
                    continue;
                }

                existingPlayer.Send(new PlayerRemovePayload(player.Id), DeliveryMethod.ReliableOrdered);
            }
        }

    }
}
