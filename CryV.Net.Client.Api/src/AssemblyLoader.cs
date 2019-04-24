using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using CryV.Net.Client.Common.Events;
using CryV.Net.Client.Common.Interfaces.Api;
using CryV.Net.Client.Http.Context;
using CryV.Net.Elements;
using CryV.Net.Shared.Common.Interfaces;

namespace CryV.Net.Client.Http
{
    public class AssemblyLoader
    {

        private HostAssemblyLoadContext _context = new HostAssemblyLoadContext();

        private List<IGamemode> _instantiatedAssemblies = new List<IGamemode>();

        private readonly IEventHandler _eventHandler;

        public AssemblyLoader(IEventHandler eventHandler)
        {
            _eventHandler = eventHandler;

            _eventHandler.Subscribe<LocalPlayerDisconnectedEvent>(OnLocalPlayerDisconnected);
        }

        private void OnLocalPlayerDisconnected(LocalPlayerDisconnectedEvent obj)
        {
            if (_context == null)
            {
                return;
            }

            foreach (var gamemode in _instantiatedAssemblies)
            {
                gamemode.Dispose();
            }

            _instantiatedAssemblies.Clear();

            _context.Unload();
            _context = null;

            _context = new HostAssemblyLoadContext();
        }

        public void LoadAssembly(string path)
        {
            using (var memoryStream = File.OpenRead(path))
            {
                var assembly = _context.LoadFromStream(memoryStream);

                foreach (var type in assembly.GetTypes())
                {
                    if (type.IsClass == false || type.IsAbstract || typeof(IGamemode).IsAssignableFrom(type) == false)
                    {
                        continue;
                    }

                    var gamemode = (IGamemode) Activator.CreateInstance(type, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, null, null);

                    _instantiatedAssemblies.Add(gamemode);
                }
            }
        }

    }
}
