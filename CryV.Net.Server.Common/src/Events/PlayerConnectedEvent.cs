using CryV.Net.Server.Common.Interfaces;
using CryV.Net.Shared.Common.Interfaces;

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
