using CryV.Net.Shared.Common.Interfaces;

namespace CryV.Net.Shared.Events.Types
{
    public class PlayerDisconnectedEvent : IEvent
    {
        
        public int Id { get; set; }

        public PlayerDisconnectedEvent()
        {
        }

        public PlayerDisconnectedEvent(int id)
        {
            Id = id;
        }

    }
}
