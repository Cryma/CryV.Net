using CryV.Net.Server.Common.Interfaces;
using CryV.Net.Server.Common.Interfaces.Api;
using CryV.Net.Shared.Common.Interfaces;

namespace CryV.Net.Server.Api.Elements
{
    public class Script
    {
        public IEvents Events { get; }
        public IPlayerPool PlayerPool { get; }
        public IVehiclePool VehiclePool { get; }

        private readonly IEventHandler _eventHandler;
        private readonly IPlayerManager _playerManager;
        private readonly IVehicleManager _vehicleManager;

        public Script(IEventHandler eventHandler, IPlayerManager playerManager, IVehicleManager vehicleManager)
        {
            _eventHandler = eventHandler;
            _playerManager = playerManager;
            _vehicleManager = vehicleManager;

            Events = new Events(eventHandler);
            PlayerPool = new PlayerPool(playerManager);
            VehiclePool = new VehiclePool(vehicleManager);
        }

    }
}
