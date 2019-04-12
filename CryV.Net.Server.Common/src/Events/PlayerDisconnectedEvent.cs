using CryV.Net.Server.Common.Interfaces;
using CryV.Net.Shared.Common.Interfaces;

namespace CryV.Net.Server.Common.Events
{
    public class PlayerDisconnectedEvent : IEvent
    {
        
        public IPlayer Player { get; set; }

        public PlayerDisconnectedEvent()
        {
        }

        public PlayerDisconnectedEvent(IPlayer player)
        {
            Player = player;
        }

    }
}
