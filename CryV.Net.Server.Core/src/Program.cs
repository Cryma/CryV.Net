using System;
using System.IO;
using System.Threading;
using Microsoft.Extensions.Hosting;
using Serilog;
using System.Threading.Tasks;
using Serilog.Events;
using Microsoft.Extensions.DependencyInjection;
using Micky5991.EventAggregator.Interfaces;
using Micky5991.EventAggregator.Services;
using CryV.Net.Server.Api;
using CryV.Net.Server.Common.Interfaces;
using CryV.Net.Server.Vehicles;
using CryV.Net.Server.Sync;
using CryV.Net.Server.Players;
using CryV.Net.Server.Networking;

namespace CryV.Net.Server.Core;

public class Program
{

    public static async Task Main(string[] args)
    {
        var serilogLogger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
            .Enrich.FromLogContext()
            .WriteTo.File(Path.Combine(Directory.GetCurrentDirectory(), "cryv-net.log"))
            .WriteTo.Console()
            .CreateLogger();

        serilogLogger.Information(new string('-', 20));
        serilogLogger.Information("Starting CryV Server..");

        var builder = new HostBuilder();

        builder.ConfigureServices(services =>
        {
            services.AddSingleton<IEventAggregator, EventAggregatorService>();

            services.AddSingleton<INetworkManager, NetworkManager>();
            services.AddHostedService(p => p.GetRequiredService<INetworkManager>());

            services.AddSingleton<IPlayerManager, PlayerManager>();
            services.AddHostedService(p => p.GetRequiredService<IPlayerManager>());

            services.AddSingleton<IVehicleManager, VehicleManager>();
            services.AddHostedService(p => p.GetRequiredService<IVehicleManager>());

            services.AddSingleton<ISyncManager, SyncManager>();
            services.AddHostedService(p => p.GetRequiredService<ISyncManager>());

            services.AddHostedService<GamemodeLoader>();
        });

        builder.ConfigureLogging(logging =>
        {
            logging.AddSerilog(serilogLogger);
        });

        var host = builder.Build();

        await host.RunAsync();
    }
}
