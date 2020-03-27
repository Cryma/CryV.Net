using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using Autofac;
using CryV.Net.Enums;
using CryV.Net.Server.Common.Events;
using CryV.Net.Server.Common.Interfaces;
using CryV.Net.Shared.Common.Payloads;
using LiteNetLib;
using Micky5991.EventAggregator.Interfaces;

namespace CryV.Net.Server.Sync
{
    public class SyncManager : ISyncManager, IStartable
    {

        private readonly ConcurrentDictionary<IVehicle, IPlayer> _vehicleSyncMapping = new ConcurrentDictionary<IVehicle, IPlayer>();

        private readonly IEventAggregator _eventAggregator;
        private readonly IPlayerManager _playerManager;
        private readonly IVehicleManager _vehicleManager;

        public SyncManager(IEventAggregator eventAggregator, IPlayerManager playerManager, IVehicleManager vehicleManager)
        {
            _eventAggregator = eventAggregator;
            _playerManager = playerManager;
            _vehicleManager = vehicleManager;
        }

        public void Start()
        {
            _vehicleManager.OnVehicleAdded += OnVehicleAdded;

            _eventAggregator.Subscribe<PlayerEntersVehicleEvent>(OnPlayerEntersVehicle);
            _eventAggregator.Subscribe<PlayerDisconnectedEvent>(OnPlayerDisconnected);

            Task.Run(SyncLoop);
        }

        private Task OnPlayerEntersVehicle(PlayerEntersVehicleEvent obj)
        {
            if (obj.Seat != VehicleSeat.Driver)
            {
                return Task.CompletedTask;
            }

            ChangeSyncer(obj.Vehicle, obj.Player);

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

        private void OnVehicleAdded(object sender, IVehicle vehicle)
        {
            var nearestPlayer = GetNearestPlayer(vehicle.Position);

            _vehicleSyncMapping.TryAdd(vehicle, null);
            ChangeSyncer(vehicle, nearestPlayer);
        }

        private void ChangeSyncer(IVehicle vehicle, IPlayer newSyncer)
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

        private IPlayer GetNearestPlayer(Vector3 position)
        {
            return _playerManager.GetPlayers().OrderBy(x => Vector3.DistanceSquared(x.Position, position)).FirstOrDefault();
        }

        public bool IsEntitySyncedByPlayer(IVehicle vehicle, IPlayer player)
        {
            return _vehicleSyncMapping[vehicle] == player;
        }
    }
}
