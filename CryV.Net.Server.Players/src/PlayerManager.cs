using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Autofac;
using CryV.Net.Server.Common.Events;
using CryV.Net.Server.Common.Interfaces;
using CryV.Net.Shared.Common.Interfaces;
using CryV.Net.Shared.Common.Payloads;
using CryV.Net.Shared.Events.Types;
using LiteNetLib;

namespace CryV.Net.Server.Players
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
            _eventHandler.Subscribe<NetworkEvent<PlayerUpdatePayload>>(OnPlayerUpdate);
        }

        public void AddPlayer(NetPeer peer)
        {
            var player = new Player(_eventHandler, _vehicleManager, peer);
            _players.TryAdd(peer.Id, player);

            BootstrapPlayer(player);
            PropagatePlayerAddition(player);

            _eventHandler.Publish(new PlayerConnectedEvent(player));
        }

        public void RemovePlayer(NetPeer peer)
        {
            if (_players.TryRemove(peer.Id, out var player) == false)
            {
                return;
            }

            player.Dispose();
            PropagatePlayerRemoval(player);

            _eventHandler.Publish(new PlayerDisconnectedEvent(player));
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

        private void OnPlayerUpdate(NetworkEvent<PlayerUpdatePayload> obj)
        {
            var payload = obj.Payload;

            if (_players.TryGetValue(payload.Id, out var targetPlayer) == false)
            {
                Console.WriteLine($"Received update from player {payload.Id}, but could not find it in PlayerManager!");

                return;
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
