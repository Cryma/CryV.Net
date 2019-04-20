using System;
using CryV.Net.Server.Common.Events;
using CryV.Net.Server.Common.Interfaces;
using CryV.Net.Server.Common.Interfaces.Api;
using CryV.Net.Shared.Common.Interfaces;

namespace CryV.Net.Server.Api.Elements
{
    public class Events : IEvents
    {

        public event EventHandler<IPlayer> OnPlayerConnected;
        public event EventHandler<IPlayer> OnPlayerDisconnected;

        private readonly IEventHandler _eventHandler;
        
        public Events(IEventHandler eventHandler)
        {
            _eventHandler = eventHandler;

            _eventHandler.Subscribe<PlayerConnectedEvent>(onPlayerConnected =>
            {
                InvokeOnPlayerConnected(onPlayerConnected.Player);
            });

            _eventHandler.Subscribe<PlayerDisconnectedEvent>(onPlayerDisconnected =>
            {
                InvokeOnPlayerDisconnected(onPlayerDisconnected.Player);
            });
        }
        
        protected virtual void InvokeOnPlayerConnected(IPlayer e)
        {
            OnPlayerConnected?.Invoke(this, e);
        }

        protected virtual void InvokeOnPlayerDisconnected(IPlayer e)
        {
            OnPlayerDisconnected?.Invoke(this, e);
        }

    }
}
