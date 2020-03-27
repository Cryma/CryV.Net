﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using Autofac;
using CryV.Net.Server.Api.Elements;
using CryV.Net.Server.Api.Gamemode;
using CryV.Net.Server.Api.Http;
using CryV.Net.Server.Api.Scripting;
using CryV.Net.Server.Common.Interfaces;
using CryV.Net.Server.Common.Interfaces.Api;
using Micky5991.EventAggregator.Interfaces;

namespace CryV.Net.Server.Api
{
    public class GamemodeLoader : IStartable, IDisposable
    {

        private Script _script;

        private readonly IEventAggregator _eventAggregator;
        private readonly IPlayerManager _playerManager;
        private readonly IVehicleManager _vehicleManager;

        private readonly Dictionary<string, GamemodeEntry> _gamemodes = new Dictionary<string, GamemodeEntry>();

        private readonly DownloadServer _downloadServer;

        public GamemodeLoader(IEventAggregator eventAggregator, IPlayerManager playerManager, IVehicleManager vehicleManager)
        {
            _eventAggregator = eventAggregator;
            _playerManager = playerManager;
            _vehicleManager = vehicleManager;

            _downloadServer = new DownloadServer();
        }

        public void Start()
        {
            _script = new Script(_eventAggregator, _playerManager, _vehicleManager);
            MP.Setup(_script);

            LoadGamemodes();
            DownloadModule.Gamemodes = _gamemodes;
        }

        private void LoadGamemodes()
        {
            var potentialGamemodes = Directory.GetDirectories(Path.Combine(Environment.CurrentDirectory, "gamemode"));
            foreach (var potentialGamemode in potentialGamemodes)
            {
                var assemblyFolder = Path.Combine(potentialGamemode, "server");
                if (Directory.Exists(assemblyFolder) == false)
                {
                    continue;
                }

                var gamemodeName = Path.GetFileName(potentialGamemode);

                var potentialGamemodeAssemblies = Directory.GetFiles(assemblyFolder, "*.dll");
                foreach (var potentialGamemodeAssembly in potentialGamemodeAssemblies)
                {
                    var assembly = Assembly.LoadFrom(potentialGamemodeAssembly);

                    foreach (var type in assembly.GetTypes())
                    {
                        if (type.IsClass == false || type.IsAbstract || typeof(IGamemode).IsAssignableFrom(type) == false)
                        {
                            continue;
                        }

                        var gamemode = (IGamemode) Activator.CreateInstance(type, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, null, null);

                        _gamemodes.Add(gamemodeName, new GamemodeEntry(gamemode, potentialGamemode));
                    }
                }
            }
        }

        public void Dispose()
        {
            _downloadServer?.Dispose();
        }

    }
}
