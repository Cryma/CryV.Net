using System;
using CryV.Net.Shared.Common.Payloads;
using LiteNetLib;

namespace CryV.Net.Server.Common.Interfaces
{
    public interface IPlayer : IDisposable
    {
        
        int Id { get; }

        ClientUpdatePayload GetPayload();

        void Send(IPayload payload, DeliveryMethod deliveryMethod);

    }
}
