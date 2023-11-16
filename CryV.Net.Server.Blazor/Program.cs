using CryV.Net.Server.Common.Interfaces;
using Micky5991.EventAggregator.Interfaces;
using Micky5991.EventAggregator.Services;
using CryV.Net.Server.Networking;
using CryV.Net.Server.Players;
using CryV.Net.Server.Vehicles;
using CryV.Net.Server.Sync;
using CryV.Net.Server.Api;
using Serilog;
using Serilog.Events;

var serilogLogger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
            .Enrich.FromLogContext()
            .WriteTo.File(Path.Combine(Directory.GetCurrentDirectory(), "cryv-net.log"))
            .WriteTo.Console()
            .CreateLogger();

serilogLogger.Information(new string('-', 20));
serilogLogger.Information("Starting CryV Server..");

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddControllers();

builder.Services.AddSingleton<IEventAggregator, EventAggregatorService>();

builder.Services.AddSingleton<INetworkManager, NetworkManager>();
builder.Services.AddHostedService(p => p.GetRequiredService<INetworkManager>());

builder.Services.AddSingleton<IPlayerManager, PlayerManager>();
builder.Services.AddHostedService(p => p.GetRequiredService<IPlayerManager>());

builder.Services.AddSingleton<IVehicleManager, VehicleManager>();
builder.Services.AddHostedService(p => p.GetRequiredService<IVehicleManager>());

builder.Services.AddSingleton<ISyncManager, SyncManager>();
builder.Services.AddHostedService(p => p.GetRequiredService<ISyncManager>());

builder.Services.AddHostedService<GamemodeLoader>();

builder.Logging.AddSerilog(serilogLogger);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapControllers();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
