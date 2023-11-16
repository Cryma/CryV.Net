using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CryV.Net.Server.Common.Events;
using CryV.Net.Server.Common.Interfaces;
using CryV.Net.Shared.Common.Events;
using CryV.Net.Shared.Common.Payloads;
using LiteNetLib;
using Micky5991.EventAggregator.Interfaces;
using Microsoft.Extensions.Logging;
using ConnectionState = CryV.Net.Server.Common.Enums.ConnectionState;

namespace CryV.Net.Server.Players;

public class PlayerManager : IPlayerManager
{

    private readonly IEventAggregator _eventAggregator;
    private readonly IVehicleManager _vehicleManager;
    private readonly ILogger _logger;

    private readonly ConcurrentDictionary<int, IServerPlayer> _players = new();

    public PlayerManager(IEventAggregator eventAggregator, IVehicleManager vehicleManager, ILogger<PlayerManager> logger)
    {
        _eventAggregator = eventAggregator;
        _vehicleManager = vehicleManager;
        _logger = logger;
    }

    public Task StartAsync(CancellationToken cancellationToken)
    {
        _eventAggregator.Subscribe<NetworkEvent<PlayerUpdatePayload>>(OnPlayerUpdate);
        _eventAggregator.Subscribe<NetworkEvent<BootstrapFinishedPayload>>(OnBootstrapFinished);

        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }

    private void OnBootstrapFinished(NetworkEvent<BootstrapFinishedPayload> obj)
    {
        var payload = obj.Payload;

        if (_players.TryGetValue(payload.Id, out var targetPlayer) == false)
        {
            _logger.LogWarning("Received finished bootstrap from player {PlayerId}, but could not find it in PlayerManager!", payload.Id);

            return;
        }

        targetPlayer.ConnectionState = ConnectionState.Connected;

        _logger.LogDebug("Received bootstrap finished payload from player {PlayerId}", payload.Id);
    }

    public void AddPlayer(NetPeer peer)
    {
        var player = new Player(_eventAggregator, _vehicleManager, _logger, peer);
        _players.TryAdd(peer.Id, player);

        BootstrapPlayer(player);
        PropagatePlayerAddition(player);

        _eventAggregator.Publish(new PlayerConnectedEvent(player));
    }

    public void RemovePlayer(NetPeer peer)
    {
        if (_players.TryRemove(peer.Id, out var player) == false)
        {
            return;
        }

        player.Dispose();
        PropagatePlayerRemoval(player);

        _eventAggregator.Publish(new PlayerDisconnectedEvent(player));
    }

    public IServerPlayer GetPlayer(int playerId)
    {
        if (_players.TryGetValue(playerId, out var player) == false)
        {
            return null;
        }

        return player;
    }

    public IServerPlayer GetPlayer(NetPeer peer)
    {
        foreach (var player in _players.Values)
        {
            if (player.Peer != peer)
            {
                continue;
            }

            return player;
        }

        return null;
    }

    public ICollection<IServerPlayer> GetPlayers(Func<IServerPlayer, bool> filter = null, bool onlyConnected = true)
    {
        var onlyConnectedFilter = onlyConnected
            ? new Func<IServerPlayer, bool>(x => x.ConnectionState == ConnectionState.Connected)
            : _ => true;

        if (filter == null)
        {
            filter = _ => true;
        }

        return _players.Values.Where(onlyConnectedFilter).Where(filter).ToList();
    }

    private Task OnPlayerUpdate(NetworkEvent<PlayerUpdatePayload> obj)
    {
        var payload = obj.Payload;

        if (_players.TryGetValue(payload.Id, out var targetPlayer) == false)
        {
            _logger.LogWarning("Received update from player {PlayerId}, but could not find it in PlayerManager!", payload.Id);

            return Task.CompletedTask;
        }

        targetPlayer.ReadPayload(payload);

        foreach (var player in GetPlayers())
        {
            if (player == targetPlayer)
            {
#if PEDMIRROR
                payload.Id = 1;
                payload.Position.X -= 4.0f;

                player.Send(payload, DeliveryMethod.Unreliable);
#endif
                continue;
            }

            player.Send(payload, DeliveryMethod.Unreliable);
        }

        return Task.CompletedTask;
    }

    private void BootstrapPlayer(IServerPlayer player)
    {
        var existingPlayerPayloads = GetPlayers(onlyConnected: false).Where(x => x != player).Select(x => x.GetPayload()).ToList();
        var existingVehiclePaylaods = _vehicleManager.GetVehicles().Select(x => x.GetPayload()).ToList();

#if PEDMIRROR
        var payload = player.GetPayload();

        payload.Id = 1;
        payload.Position.X -= 5.0f;

        existingPlayerPayloads.Add(payload);
#endif

        _logger.LogDebug("Sending bootstrap payload to player {PlayerId}", player.Id);

        var bootstrapPayload = new BootstrapPayload(player.Id, player.Position, player.Rotation.Z, player.Model, existingPlayerPayloads, existingVehiclePaylaods);

        player.Send(bootstrapPayload, DeliveryMethod.ReliableOrdered);
    }

    private void PropagatePlayerAddition(IServerPlayer player)
    {
        foreach (var existingPlayer in GetPlayers(onlyConnected: false))
        {
            if (existingPlayer == player)
            {
                continue;
            }

            existingPlayer.Send(player.GetPayload(), DeliveryMethod.ReliableOrdered);
            existingPlayer.Send(new PlayerAddPayload(player.GetPayload()), DeliveryMethod.ReliableOrdered);
        }
    }

    private void PropagatePlayerRemoval(IServerPlayer player)
    {
        foreach (var existingPlayer in GetPlayers(onlyConnected: false))
        {
            if (existingPlayer == player)
            {
                continue;
            }

            existingPlayer.Send(new PlayerRemovePayload(player.Id), DeliveryMethod.ReliableOrdered);
        }
    }
}
