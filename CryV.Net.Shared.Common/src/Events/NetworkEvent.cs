using CryV.Net.Shared.Common.Payloads;
using LiteNetLib;
using Micky5991.EventAggregator.Interfaces;

namespace CryV.Net.Shared.Common.Events
{
    public class NetworkEvent<TPayload> : IEvent where TPayload : IPayload
    {
        
        public NetPeer Sender { get; set; }

        public TPayload Payload { get; set; }

        public NetworkEvent()
        {
        }

        public NetworkEvent(NetPeer sender, TPayload payload)
        {
            Sender = sender;
            Payload = payload;
        }

    }
}
