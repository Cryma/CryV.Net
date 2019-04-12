using System.Collections.Concurrent;
using Autofac;
using CryV.Net.Server.Common.Events;
using CryV.Net.Server.Common.Interfaces;
using CryV.Net.Shared.Common.Interfaces;
using LiteNetLib;

namespace CryV.Net.Server.Players
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
            
        }

        public void AddPlayer(NetPeer peer)
        {
            var player = new Player(peer);
            _players.TryAdd(peer.Id, player);

            _eventHandler.Publish(new PlayerConnectedEvent(player));
        }

        public void RemovePlayer(NetPeer peer)
        {
            if (_players.TryRemove(peer.Id, out var player) == false)
            {
                return;
            }

            _eventHandler.Publish(new PlayerDisconnectedEvent(player));
        }

    }
}