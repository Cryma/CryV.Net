using Autofac;
using CryV.Net.Client.Common.Interfaces;
using CryV.Net.Shared.Common.Interfaces;
using CryV.Net.Shared.Common.Payloads;
using CryV.Net.Shared.Events.Types;
using LiteNetLib;

namespace CryV.Net.Client.Players
{
    public class PlayerManager : IPlayerManager, IStartable
    {

        private readonly IEventHandler _eventHandler;

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
            
        }

        public void RemovePlayer(int playerId)
        {
            throw new System.NotImplementedException();
        }
    }
}
