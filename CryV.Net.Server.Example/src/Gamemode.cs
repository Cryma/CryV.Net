using System;
using System.Numerics;
using CryV.Net.Server.Api.Scripting;
using CryV.Net.Server.Common.Interfaces;
using CryV.Net.Server.Common.Interfaces.Api;

namespace CryV.Net.Server.Example
{
    public class Gamemode : IGamemode
    {

        public Gamemode()
        {
            MP.Events.OnPlayerConnected += OnPlayerConnected;
            MP.Events.OnPlayerDisconnected += OnPlayerDisconnected;

            MP.VehiclePool.CreateVehicle(new Vector3(165.1652f, -1077.867f, 28.433891f), Vector3.Zero, 1274868363, "ehre");
            //MP.VehiclePool.CreateVehicle(new Vector3(161.1652f, -1077.867f, 28.433891f), Vector3.Zero, 2364918497, "1337");
            //MP.VehiclePool.CreateVehicle(new Vector3(157.1652f, -1077.867f, 28.433891f), Vector3.Zero, 4180675781);

            Console.WriteLine("Started example gamemode!");
        }

        private void OnPlayerConnected(object sender, IPlayer e)
        {
            Console.WriteLine($"Player {e.Id} connected!");
        }

        private void OnPlayerDisconnected(object sender, IPlayer e)
        {
            Console.WriteLine($"Player {e.Id} disconnected!");
        }

    }
}
