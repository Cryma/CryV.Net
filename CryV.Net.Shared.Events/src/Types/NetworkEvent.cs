﻿using CryV.Net.Shared.Common.Interfaces;
using CryV.Net.Shared.Common.Payloads;
using LiteNetLib;

namespace CryV.Net.Shared.Events.Types
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
