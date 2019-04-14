using CryV.Net.Client.Common.Interfaces;
using CryV.Net.Shared.Common.Interfaces;

namespace CryV.Net.Client.Common.Events
{
    public class PlayerConnectedEvent : IEvent
    {
        
        public IPlayer Player { get; set; }

        public PlayerConnectedEvent(IPlayer player)
        {
            Player = player;
        }

    }
}
