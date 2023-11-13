using System;
using System.Threading;
using System.Threading.Tasks;
using CryV.Net.Client.Common.Helpers;
using CryV.Net.Client.Common.Interfaces;
using CryV.Net.Elements;
using Microsoft.Extensions.Hosting;

namespace CryV.Net.Client.Debugging.Menu;

public class DebugKeybinds : IHostedService
{

    private readonly INetworkManager _networkManager;

    public DebugKeybinds(INetworkManager networkManager)
    {
        _networkManager = networkManager;
    }

    public Task StartAsync(CancellationToken cancellationToken)
    {
        NativeHelper.OnNativeTick += Tick;

        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }

    private void Tick(float deltatime)
    {
        if (_networkManager.IsConnected == false && Utility.IsKeyReleased(ConsoleKey.F5))
        {
            _networkManager.Connect("127.0.0.1", 1337);
        }

    }
}
