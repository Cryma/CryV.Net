using CryV.Net.Client.Common.Interfaces;
using Micky5991.EventAggregator.Interfaces;

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
