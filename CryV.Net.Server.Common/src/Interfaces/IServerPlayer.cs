using System;
using CryV.Net.Shared.Common.Interfaces;
using CryV.Net.Shared.Common.Payloads;
using LiteNetLib;
using ConnectionState = CryV.Net.Server.Common.Enums.ConnectionState;

namespace CryV.Net.Server.Common.Interfaces
{
    public interface IServerPlayer : ISharedPlayer, IDisposable
    {
        
        ConnectionState ConnectionState { get; set; }

        IServerVehicle Vehicle { get; set; }

        PlayerUpdatePayload GetPayload();
        void ReadPayload(PlayerUpdatePayload payload);

        void Send(IPayload payload, DeliveryMethod deliveryMethod);

        NetPeer GetPeer();

    }
}
