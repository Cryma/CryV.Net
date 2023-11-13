using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using CryV.Net.Client.Api.Context;
using CryV.Net.Client.Common.Events;
using CryV.Net.Client.Common.Interfaces.Api;
using Micky5991.EventAggregator.Interfaces;

namespace CryV.Net.Client.Api;

public class AssemblyLoader
{

    private HostAssemblyLoadContext _context = new HostAssemblyLoadContext();

    private List<IGamemode> _instantiatedAssemblies = new List<IGamemode>();

    private readonly IEventAggregator _eventAggregator;

    public AssemblyLoader(IEventAggregator eventAggregator)
    {
        _eventAggregator = eventAggregator;

        _eventAggregator.Subscribe<LocalPlayerDisconnectedEvent>(OnLocalPlayerDisconnected);
    }

    private Task OnLocalPlayerDisconnected(LocalPlayerDisconnectedEvent obj)
    {
        if (_context == null)
        {
            return Task.CompletedTask;
        }

        foreach (var gamemode in _instantiatedAssemblies)
        {
            gamemode.Dispose();
        }

        _instantiatedAssemblies.Clear();

        _context.Unload();
        _context = null;

        _context = new HostAssemblyLoadContext();

        return Task.CompletedTask;
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
