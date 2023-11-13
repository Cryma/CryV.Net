using System;
using System.Threading.Tasks;
using CryV.Net.Server.Common.Events;
using CryV.Net.Server.Common.Interfaces;
using CryV.Net.Server.Common.Interfaces.Api;
using Micky5991.EventAggregator.Interfaces;

namespace CryV.Net.Server.Api.Elements;

public class Events : IEvents
{

    public event EventHandler<IServerPlayer> OnPlayerConnected;
    public event EventHandler<IServerPlayer> OnPlayerDisconnected;

    private readonly IEventAggregator _eventAggregator;
    
    public Events(IEventAggregator eventAggregator)
    {
        _eventAggregator = eventAggregator;

        _eventAggregator.Subscribe<PlayerConnectedEvent>(onPlayerConnected =>
        {
            InvokeOnPlayerConnected(onPlayerConnected.Player);

            return Task.CompletedTask;
        });

        eventAggregator.Subscribe<PlayerDisconnectedEvent>(onPlayerDisconnected =>
        {
            InvokeOnPlayerDisconnected(onPlayerDisconnected.Player);

            return Task.CompletedTask;
        });
    }
    
    protected virtual void InvokeOnPlayerConnected(IServerPlayer e)
    {
        OnPlayerConnected?.Invoke(this, e);
    }

    protected virtual void InvokeOnPlayerDisconnected(IServerPlayer e)
    {
        OnPlayerDisconnected?.Invoke(this, e);
    }

}
