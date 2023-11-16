using System;
using System.Numerics;
using CryV.Net.Server.Api.Scripting;
using CryV.Net.Server.Common.Interfaces;
using CryV.Net.Server.Common.Interfaces.Api;
using Microsoft.Extensions.Logging;

namespace CryV.Net.Server.Example;

public class Gamemode : IGamemode
{

    private readonly ILogger _logger;

    public Gamemode()
    {
        _logger = MP.Logging.GetLogger<Gamemode>();

        MP.Events.OnPlayerConnected += OnPlayerConnected;
        MP.Events.OnPlayerDisconnected += OnPlayerDisconnected;

        MP.VehiclePool.CreateVehicle(new Vector3(104.39481f, -1078.5488f, 28.43744f), new Vector3(0.0f, 0.0f, -19.036509f), 1274868363, "EHRE");
        MP.VehiclePool.CreateVehicle(new Vector3(107.84033f, -1079.7783f, 28.64444f), new Vector3(0.0f, 0.0f, -19.036509f), 2364918497, "1337");
        MP.VehiclePool.CreateVehicle(new Vector3(111.060104f, -1049.2864f, 28.566235f), new Vector3(0.0f, 0.0f, -114.83127f), 4180675781);
        MP.VehiclePool.CreateVehicle(new Vector3(107.0332f, -1063.8341f, 29.297525f), new Vector3(0.0f, 0.0f, -113.37058f), 0x21EEE87D);
        //MP.VehiclePool.CreateVehicle(new Vector3(151.1652f, -1077.867f, 28.433891f), Vector3.Zero, 1912215274);
        MP.VehiclePool.CreateVehicle(new Vector3(157.44566f, -1081.4004f, 31.05618f), new Vector3(0.0f, 0.0f, 90.253784f), 0xCBB2BE0E);

        _logger.LogInformation("Started example gamemode!");
    }

    private void OnPlayerConnected(object? sender, IServerPlayer e)
    {
        _logger.LogInformation("Player {PlayerId} connected!", e.Id);
    }

    private void OnPlayerDisconnected(object? sender, IServerPlayer e)
    {
        _logger.LogInformation("Player {PlayerId} disconnected!", e.Id);
    }

}
