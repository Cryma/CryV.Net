using CryV.Net.Server.Common.Interfaces;
using Micky5991.EventAggregator.Interfaces;

namespace CryV.Net.Server.Common.Events
{
    public class PlayerConnectedEvent : IEvent
    {

        public IPlayer Player { get; set; }

        public PlayerConnectedEvent()
        {
        }

        public PlayerConnectedEvent(IPlayer player)
        {
            Player = player;
        }

    }
}
