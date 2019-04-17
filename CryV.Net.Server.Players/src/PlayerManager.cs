using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using Autofac;
using CryV.Net.Server.Common.Events;
using CryV.Net.Server.Common.Interfaces;
using CryV.Net.Shared.Common.Interfaces;
using CryV.Net.Shared.Common.Payloads;
using CryV.Net.Shared.Common.Payloads.Helpers;
using CryV.Net.Shared.Events.Types;
using LiteNetLib;

namespace CryV.Net.Server.Players
{
    public class PlayerManager : IPlayerManager, IStartable
    {

        public INetworkManager NetworkManager { get; }

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
            
        }

        public void AddPlayer(NetPeer peer)
        {
            var player = new Player(this, _eventHandler, _vehicleManager, peer);
            _players.TryAdd(peer.Id, player);

            _eventHandler.Publish(new PlayerConnectedEvent(player));
        }

        public void RemovePlayer(NetPeer peer)
        {
            if (_players.TryRemove(peer.Id, out var player) == false)
            {
                return;
            }

            player.Dispose();

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

        public ICollection<IPlayer> GetPlayers()
        {
            return _players.Values.ToList();
        }

    }
}
