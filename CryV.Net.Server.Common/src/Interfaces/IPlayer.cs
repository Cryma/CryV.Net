using System;
using System.Numerics;
using CryV.Net.Shared.Common.Payloads;
using LiteNetLib;

namespace CryV.Net.Server.Common.Interfaces
{
    public interface IPlayer : IDisposable
    {
        
        int Id { get; }

        Vector3 Position { get; set; }

        float Heading { get; set; }

        IVehicle Vehicle { get; set; }

        int Seat { get; set; }

        PlayerUpdatePayload GetPayload();

        void Send(IPayload payload, DeliveryMethod deliveryMethod);

        NetPeer GetPeer();

    }
}
