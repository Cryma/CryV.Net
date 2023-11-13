using Micky5991.EventAggregator.Interfaces;

namespace CryV.Net.Client.Common.Events
{
    public class LocalPlayerDisconnectedEvent : IEvent
    {
        public bool IsCancellable()
        {
            return false;
        }
    }
}
