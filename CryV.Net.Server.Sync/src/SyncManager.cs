using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using Autofac;
using CryV.Net.Enums;
using CryV.Net.Server.Common.Events;
using CryV.Net.Server.Common.Interfaces;
using CryV.Net.Shared.Common.Interfaces;
using CryV.Net.Shared.Common.Payloads;
using LiteNetLib;

namespace CryV.Net.Server.Sync
{
    public class SyncManager : IStartable
    {

        private readonly Dictionary<IVehicle, IPlayer> _vehicleSyncMapping = new Dictionary<IVehicle, IPlayer>();

        private readonly IEventHandler _eventHandler;
        private readonly IPlayerManager _playerManager;
        private readonly IVehicleManager _vehicleManager;

        public SyncManager(IEventHandler eventHandler, IPlayerManager playerManager, IVehicleManager vehicleManager)
        {
            _eventHandler = eventHandler;
            _playerManager = playerManager;
            _vehicleManager = vehicleManager;
        }

        public void Start()
        {
            _vehicleManager.OnVehicleAdded += OnVehicleAdded;

            _eventHandler.Subscribe<PlayerEntersVehicleEvent>(OnPlayerEntersVehicle);

            Task.Run(SyncLoop);
        }

        private void OnPlayerEntersVehicle(PlayerEntersVehicleEvent obj)
        {
            if (obj.Seat != VehicleSeat.Driver)
            {
                return;
            }

            ChangeSyncer(obj.Vehicle, obj.Player);
        }

        private void OnVehicleAdded(object sender, IVehicle vehicle)
        {
            var nearestPlayer = GetNearestPlayer(vehicle.Position);

            _vehicleSyncMapping.Add(vehicle, null);
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

    }
}
