using CryV.Net.Shared.Common.Interfaces;

namespace CryV.Net.Shared.Events.Types
{
    public class PlayerConnectedEvent : IEvent
    {

        public int Id { get; set; }
        public PlayerConnectedEvent()
        {
        }

        public PlayerConnectedEvent(int id)
        {
            Id = id;
        }

    }
}