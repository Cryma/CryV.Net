using CryV.Net.Client.Common.Interfaces;
using CryV.Net.Shared.Common.Interfaces;

namespace CryV.Net.Client.Common.Events
{
    public class PlayerDisconnectedEvent : IEvent
    {
        
        public IPlayer Player { get; set; }

        public PlayerDisconnectedEvent(IPlayer player)
        {
            Player = player;
        }

    }
}
