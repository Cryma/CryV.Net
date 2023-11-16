using CryV.Net.Shared.Common.Payloads;
using LiteNetLib;
using Micky5991.EventAggregator.Interfaces;

namespace CryV.Net.Shared.Common.Events;

public class NetworkEvent<TPayload> : IEvent where TPayload : IPayload
{
    
    public NetPeer Sender { get; set; }

    public TPayload Payload { get; set; }

    // Empty construct is needed due to reflection
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public NetworkEvent()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    {
    }

    public NetworkEvent(NetPeer sender, TPayload payload)
    {
        Sender = sender;
        Payload = payload;
    }

    public bool IsCancellable()
    {
        return false;
    }
}
