using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Numerics;
using System.Threading;
using System.Threading.Tasks;
using CryV.Net.Server.Common.Events;
using CryV.Net.Server.Common.Interfaces;
using CryV.Net.Shared.Common.Enums;
using CryV.Net.Shared.Common.Payloads;
using LiteNetLib;
using Micky5991.EventAggregator.Interfaces;
using Microsoft.Extensions.Logging;

namespace CryV.Net.Server.Sync;

public class SyncManager : ISyncManager
{

    private readonly ConcurrentDictionary<IServerVehicle, IServerPlayer?> _vehicleSyncMapping = new();

    private readonly IEventAggregator _eventAggregator;
    private readonly IPlayerManager _playerManager;
    private readonly IVehicleManager _vehicleManager;
    private readonly ILogger _logger;

    public SyncManager(IEventAggregator eventAggregator, IPlayerManager playerManager, IVehicleManager vehicleManager, ILogger<SyncManager> logger)
    {
        _eventAggregator = eventAggregator;
        _playerManager = playerManager;
        _vehicleManager = vehicleManager;
        _logger = logger;
    }

    public Task StartAsync(CancellationToken cancellationToken)
    {
        _vehicleManager.OnVehicleAdded += OnVehicleAdded;

        _eventAggregator.Subscribe<PlayerEntersVehicleEvent>(OnPlayerEntersVehicle);
        _eventAggregator.Subscribe<PlayerDisconnectedEvent>(OnPlayerDisconnected);

        _eventAggregator.Subscribe<VehicleTrailerAttachedEvent>(OnVehicleTrailerAttached);

        Task.Run(SyncLoop);

        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }

    private void OnVehicleTrailerAttached(VehicleTrailerAttachedEvent eventdata)
    {
        if (eventdata.Vehicle.TrailerId == null)
        {
            throw new InvalidOperationException("TrailerId is null in VehicleTrailerAttachedEvent!");
        }

        var trailer = _vehicleManager.GetVehicle(eventdata.Vehicle.TrailerId.Value);
        if (trailer == null)
        {
            _logger.LogWarning("Could not find attached trailer {TrailerId} in vehicle manager!", eventdata.Vehicle.TrailerId);

            return;
        }

        var player = _playerManager.GetPlayers().FirstOrDefault(x => x.Vehicle == eventdata.Vehicle && x.Seat == -1);
        if (player == null)
        {
            _logger.LogWarning("No player sitting in vehicle {VehicleId} that the trailer {TrailerId}", eventdata.Vehicle.Id, eventdata.Vehicle.TrailerId);

            return;
        }

        ChangeSyncer(trailer, player);
    }

    private Task OnPlayerEntersVehicle(PlayerEntersVehicleEvent obj)
    {
        if (obj.Seat != VehicleSeat.Driver)
        {
            return Task.CompletedTask;
        }

        ChangeSyncer(obj.Vehicle, obj.Player);

        if (obj.Vehicle.TrailerId != null)
        {
            var trailer = _vehicleManager.GetVehicle(obj.Vehicle.TrailerId.Value);
            if (trailer == null)
            {
                _logger.LogWarning("Tried to find trailer {TrailerId} for vehicle {VehicleId} in vehicle manager but found none!", obj.Vehicle.TrailerId, obj.Vehicle.Id);

                return Task.CompletedTask;
            }

            ChangeSyncer(trailer, obj.Player);
        }

        return Task.CompletedTask;
    }

    private Task OnPlayerDisconnected(PlayerDisconnectedEvent obj)
    {
        foreach (var syncedVehicles in _vehicleSyncMapping.Where(x => x.Value == obj.Player))
        {
            ChangeSyncer(syncedVehicles.Key, null);
        }

        return Task.CompletedTask;
    }

    private void OnVehicleAdded(object? sender, IServerVehicle vehicle)
    {
        var nearestPlayer = GetNearestPlayer(vehicle.Position);

        _vehicleSyncMapping.TryAdd(vehicle, null);
        ChangeSyncer(vehicle, nearestPlayer);
    }

    private void ChangeSyncer(IServerVehicle vehicle, IServerPlayer? newSyncer)
    {
        var oldSyncer = _vehicleSyncMapping[vehicle];
        if (oldSyncer == newSyncer)
        {
            return;
        }

        oldSyncer?.Send(new RemoveSyncPayload(vehicle.Id), DeliveryMethod.ReliableOrdered);

        _vehicleSyncMapping[vehicle] = newSyncer;
        newSyncer?.Send(new AddSyncPayload(vehicle.Id), DeliveryMethod.ReliableOrdered);
    }

    private async Task SyncLoop()
    {
        while (true)
        {
            await Task.Delay(TimeSpan.FromSeconds(5));

            // Go through each vehicle that does not have a syncer
            foreach (var vehicle in _vehicleSyncMapping.Where(x => x.Value == null).ToList())
            {
                var nearestPlayer = GetNearestPlayer(vehicle.Key.Position);
                if (nearestPlayer == null)
                {
                    // Found no player near vehicle
                    continue;
                }

                ChangeSyncer(vehicle.Key, nearestPlayer);
            }
        }
    }

    private IServerPlayer? GetNearestPlayer(Vector3 position)
    {
        return _playerManager
            .GetPlayers()
            .OrderBy(x => Vector3.DistanceSquared(x.Position, position))
            .FirstOrDefault();
    }

    public bool IsEntitySyncedByPlayer(IServerVehicle vehicle, IServerPlayer player)
    {
        return _vehicleSyncMapping[vehicle] == player;
    }
}
