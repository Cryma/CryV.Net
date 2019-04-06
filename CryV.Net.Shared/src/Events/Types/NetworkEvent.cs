using CryV.Net.Shared.Payloads;

namespace CryV.Net.Shared.Events.Types
{
    public class NetworkEvent<TPayload> : IEvent where TPayload : IPayload
    {
        
        public TPayload Payload { get; set; }

        public NetworkEvent()
        {
        }

        public NetworkEvent(TPayload payload)
        {
            Payload = payload;
        }

    }
}
