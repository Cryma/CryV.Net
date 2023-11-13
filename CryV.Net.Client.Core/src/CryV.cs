using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using CryV.Net.Client.Api;
using CryV.Net.Client.Common.Helpers;
using CryV.Net.Client.Common.Interfaces;
using CryV.Net.Client.Console;
using CryV.Net.Client.Debugging.Menu;
using CryV.Net.Client.Helpers;
using CryV.Net.Client.Networking;
using CryV.Net.Client.Players;
using CryV.Net.Client.Sync;
using CryV.Net.Client.Vehicles;
using CryV.Net.Elements;
using CryV.Net.Plugins;
using Micky5991.EventAggregator.Interfaces;
using Micky5991.EventAggregator.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;

namespace CryV.Net.Client.Core;

public partial class CryV : IPlugin
{

    public CryV()
    {
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .MinimumLevel.Override("Microsoft", Serilog.Events.LogEventLevel.Information)
            .Enrich.FromLogContext()
            .WriteTo.File(Path.Combine(Utility.GetInstallDirectory(), "cryv-net.log"))
#if DEBUG
            .WriteTo.Console()
#endif
            .CreateLogger();

#if DEBUG
        AllocConsole();
#endif

        Log.Logger.Information(new string('-', 20));
        Log.Logger.Information("Starting CryV...");

        var builder = new HostBuilder();

        builder.ConfigureServices(services =>
        {
            services.AddSingleton<IEventAggregator, EventAggregatorService>();

            services.AddSingleton<INetworkManager, NetworkManager>();
            services.AddSingleton(p => new Lazy<INetworkManager>(p.GetRequiredService<INetworkManager>()));
            services.AddHostedService(p => p.GetRequiredService<INetworkManager>());

            services.AddHostedService<Cleanup.Cleanup>();
            services.AddHostedService<DebugKeybinds>();
            services.AddHostedService<DebugMenu>();
            services.AddHostedService<PauseMenuHelper>();

            services.AddSingleton<IScriptManager, ScriptManager>();
            services.AddSingleton(p => new Lazy<IScriptManager>(p.GetRequiredService<IScriptManager>()));
            services.AddHostedService(p => p.GetRequiredService<IScriptManager>());

            services.AddSingleton<ISyncManager, SyncManager>();
            services.AddSingleton(p => new Lazy<ISyncManager>(p.GetRequiredService<ISyncManager>()));
            services.AddHostedService(p => p.GetRequiredService<ISyncManager>());

            services.AddHostedService<GameConsole>();

            services.AddSingleton<IVehicleManager, VehicleManager>();
            services.AddSingleton(p => new Lazy<IVehicleManager>(p.GetRequiredService<IVehicleManager>()));
            services.AddHostedService(p => p.GetRequiredService<IVehicleManager>());

            services.AddSingleton<IPlayerManager, PlayerManager>();
            services.AddSingleton(p => new Lazy<IPlayerManager>(p.GetRequiredService<IPlayerManager>()));
            services.AddHostedService(p => p.GetRequiredService<IPlayerManager>());

            services.AddHostedService<Players.Local.LocalPlayer>();
        });

        builder.ConfigureLogging(logging =>
        {
            logging.AddSerilog(Log.Logger);
        });

        var host = builder.Build();

        Task.Run(host.Run);
    }

    public void Tick()
    {
        NativeHelper.InvokeNativeTick();
    }

    public void OnKeyboard(ConsoleKey key, char character, bool isPressed)
    {
        NativeHelper.InvokeKeyboardTick(key, character, isPressed);
    }

#if DEBUG
    [LibraryImport("kernel32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static partial bool AllocConsole();
#endif

}
