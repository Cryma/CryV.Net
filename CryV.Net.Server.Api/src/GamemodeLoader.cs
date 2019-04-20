using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using Autofac;
using CryV.Net.Server.Api.Elements;
using CryV.Net.Server.Api.Scripting;
using CryV.Net.Server.Common.Interfaces;
using CryV.Net.Server.Common.Interfaces.Api;
using CryV.Net.Shared.Common.Interfaces;

namespace CryV.Net.Server.Api
{
    public class GamemodeLoader : IStartable
    {

        private Script _script;

        private readonly IEventHandler _eventHandler;
        private readonly IPlayerManager _playerManager;
        private readonly IVehicleManager _vehicleManager;

        public GamemodeLoader(IEventHandler eventHandler, IPlayerManager playerManager, IVehicleManager vehicleManager)
        {
            _eventHandler = eventHandler;
            _playerManager = playerManager;
            _vehicleManager = vehicleManager;
        }

        public void Start()
        {
            _script = new Script(_eventHandler, _playerManager, _vehicleManager);
            MP.Setup(_script);

            LoadGamemodes();
        }

        private void LoadGamemodes()
        {
            var files = Directory.GetFiles(Path.Combine(Environment.CurrentDirectory, "gamemode"));
            Console.WriteLine(Environment.CurrentDirectory);
            foreach (var file in files.Where(x => x.EndsWith(".dll")))
            {
                var assembly = Assembly.LoadFrom(file);

                foreach (var type in assembly.GetTypes())
                {
                    if (type.IsClass == false || type.IsAbstract || typeof(IGamemode).IsAssignableFrom(type) == false)
                    {
                        continue;
                    }

                    Activator.CreateInstance(type, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, null, null);
                }
            }
        }

    }
}
