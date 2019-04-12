using CryV.Net.Shared.Common.Payloads;
using LiteNetLib;

namespace CryV.Net.Client.Common.Interfaces
{
    public interface INetworkManager
    {

        bool IsConnected { get; }

        void Connect(string address, int port);

        void Disconnect();

        void Send(IPayload payload, DeliveryMethod deliveryMethod);

    }
}
