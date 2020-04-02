using CryV.Net.Client.Common.Interfaces;
using Micky5991.EventAggregator.Interfaces;

namespace CryV.Net.Client.Common.Events
{
    public class PlayerConnectedEvent : IEvent
    {
        
        public IClientPlayer Player { get; set; }

        public PlayerConnectedEvent(IClientPlayer player)
        {
            Player = player;
        }

    }
}
