using System.Net;
using CryV.Net.Shared.Common.Payloads;
using LiteNetLib;
using Microsoft.Extensions.Hosting;

namespace CryV.Net.Client.Common.Interfaces;

public interface INetworkManager : IHostedService
{

    bool IsConnected { get; }

    NetStatistics? Statistics { get; }

    IPEndPoint? EndPoint { get; }

    int Ping { get; }

    void Connect(string address, int port);

    void Disconnect();

    void Send(IPayload payload, DeliveryMethod deliveryMethod);

}
