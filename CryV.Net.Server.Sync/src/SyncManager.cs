using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using Autofac;
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
            _vehicleSyncMapping[obj.Vehicle] = obj.Player;

            obj.Player.Send(new AddSyncPayload(obj.Vehicle.Id), DeliveryMethod.ReliableOrdered);
        }

        private void OnVehicleAdded(object sender, IVehicle e)
        {
            var nearestPlayer = GetNearestPlayer(e.Position);

            _vehicleSyncMapping.Add(e, nearestPlayer);
        }

        private IPlayer GetNearestPlayer(Vector3 position)
        {
            return _playerManager.GetPlayers().OrderBy(x => Vector3.Distance(x.Position, position)).FirstOrDefault();
        }

        private async Task SyncLoop()
        {
            while (true)
            {
                await Task.Delay(TimeSpan.FromSeconds(1));


            }
        }

    }
}
