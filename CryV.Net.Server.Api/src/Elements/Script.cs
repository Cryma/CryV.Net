using System;
using CryV.Net.Server.Common.Interfaces;
using CryV.Net.Server.Common.Interfaces.Api;
using Micky5991.EventAggregator.Interfaces;

namespace CryV.Net.Server.Api.Elements;

public class Script
{
    public ILogging Logging { get; }
    public IEvents Events { get; }
    public IPlayerPool PlayerPool { get; }
    public IVehiclePool VehiclePool { get; }
    public ICommandHandler CommandHandler { get; }

    private readonly IServiceProvider _serviceProvider;
    private readonly IEventAggregator _eventAggregator;
    private readonly IPlayerManager _playerManager;
    private readonly IVehicleManager _vehicleManager;

    public Script(IServiceProvider serviceProvider, IEventAggregator eventAggregator, IPlayerManager playerManager, IVehicleManager vehicleManager)
    {
        _serviceProvider = serviceProvider;
        _eventAggregator = eventAggregator;
        _playerManager = playerManager;
        _vehicleManager = vehicleManager;

        Logging = new Logging(_serviceProvider);
        Events = new Events(_eventAggregator);
        PlayerPool = new PlayerPool(playerManager);
        VehiclePool = new VehiclePool(vehicleManager);
        CommandHandler = new CommandHandler(_eventAggregator, playerManager);
    }

}
