using System;
using System.Reflection;
using System.Runtime.Serialization;
using System.Threading;
using System.Threading.Tasks;
using CryV.Net.Server.Common.Interfaces;
using CryV.Net.Shared.Common.Enums;
using CryV.Net.Shared.Common.Events;
using CryV.Net.Shared.Common.Payloads.Helpers;
using LiteNetLib;
using Micky5991.EventAggregator.Interfaces;
using Microsoft.Extensions.Logging;

namespace CryV.Net.Server.Networking;

public class NetworkManager : INetworkManager
{

    private readonly EventBasedNetListener _listener = new();
    private readonly NetManager _netManager;

    private const int _maxPlayers = 32;

    private readonly IPlayerManager _playerManager;
    private readonly IEventAggregator _eventAggregator;
    private readonly ILogger _logger;

    public NetworkManager(IPlayerManager playerManager, IEventAggregator eventAggregator, ILogger<NetworkManager> logger)
    {
        _playerManager = playerManager;
        _eventAggregator = eventAggregator;
        _logger = logger;

        _listener.ConnectionRequestEvent += OnConectionRequest;
        _listener.NetworkReceiveEvent += OnNetworkReceive;
        _listener.PeerConnectedEvent += OnPeerConnected;
        _listener.PeerDisconnectedEvent += OnPeerDisconnected;

        _netManager = new NetManager(_listener);
    }

    public Task StartAsync(CancellationToken cancellationToken)
    {
        _netManager.Start(1337);

        Task.Run(Tick);

        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }

    private void OnPeerConnected(NetPeer peer)
    {
        _playerManager.AddPlayer(peer);
    }

    private void OnPeerDisconnected(NetPeer peer, DisconnectInfo disconnectinfo)
    {
        _playerManager.RemovePlayer(peer);
    }

    private void OnNetworkReceive(NetPeer peer, NetPacketReader reader, byte channel, DeliveryMethod deliverymethod)
    {
        var type = (PayloadType) reader.GetByte();

        var payloadObjectType = PayloadHandler.GetPayloadByType(type);
        var payload = PayloadHandler.DeserializePayload(payloadObjectType, reader.GetRemainingBytes());

        var eventType = typeof(NetworkEvent<>).MakeGenericType(payloadObjectType);
        var eventInstance = (IEvent) FormatterServices.GetUninitializedObject(eventType);

        var payloadProperty = eventType.GetProperty("Payload", BindingFlags.Public | BindingFlags.Instance);
        if (payloadProperty == null)
        {
            return;
        }

        var senderProperty = eventType.GetProperty("Sender", BindingFlags.Public | BindingFlags.Instance);
        if (senderProperty == null)
        {
            return;
        }

        payloadProperty.SetValue(eventInstance, payload);
        senderProperty.SetValue(eventInstance, peer);

        _eventAggregator.Publish(eventInstance);
    }

    private void OnConectionRequest(ConnectionRequest request)
    {
        if (_netManager.GetPeersCount(ConnectionState.Any) >= _maxPlayers)
        {
            request.Reject();

            return;
        }

        request.AcceptIfKey("cryv-0.1.1");
    }

    private async Task Tick()
    {
        while (true)
        {
            try
            {
                await Task.Delay(TimeSpan.FromMilliseconds(1));

                _netManager.PollEvents();
            }
            catch (TaskCanceledException)
            {
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, "Exception in NetworkManager tick thread");
            }
        }
    }
}
