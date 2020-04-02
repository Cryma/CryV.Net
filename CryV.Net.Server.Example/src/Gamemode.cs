using System;
using System.Numerics;
using CryV.Net.Server.Api.Scripting;
using CryV.Net.Server.Common.Interfaces;
using CryV.Net.Server.Common.Interfaces.Api;
using Microsoft.Extensions.Logging;

namespace CryV.Net.Server.Example
{
    public class Gamemode : IGamemode
    {

        private readonly ILogger _logger;

        public Gamemode()
        {
            _logger = MP.Logging.GetLogger<Gamemode>();

            MP.Events.OnPlayerConnected += OnPlayerConnected;
            MP.Events.OnPlayerDisconnected += OnPlayerDisconnected;

            MP.VehiclePool.CreateVehicle(new Vector3(165.1652f, -1077.867f, 28.433891f), Vector3.Zero, 1274868363, "ehre");
            MP.VehiclePool.CreateVehicle(new Vector3(161.1652f, -1077.867f, 28.433891f), Vector3.Zero, 2364918497, "1337");
            MP.VehiclePool.CreateVehicle(new Vector3(157.1652f, -1077.867f, 28.433891f), Vector3.Zero, 4180675781);
            MP.VehiclePool.CreateVehicle(new Vector3(154.1652f, -1077.867f, 28.433891f), Vector3.Zero, 0xCBB2BE0E);
            //MP.VehiclePool.CreateVehicle(new Vector3(151.1652f, -1077.867f, 28.433891f), Vector3.Zero, 1912215274);
            MP.VehiclePool.CreateVehicle(new Vector3(148.1652f, -1077.867f, 28.433891f), Vector3.Zero, 0x21EEE87D);

            _logger.LogInformation("Started example gamemode!");
        }

        private void OnPlayerConnected(object sender, IServerPlayer e)
        {
            _logger.LogInformation("Player {PlayerId} connected!", e.Id);
        }

        private void OnPlayerDisconnected(object sender, IServerPlayer e)
        {
            _logger.LogInformation("Player {PlayerId} disconnected!", e.Id);
        }

    }
}
