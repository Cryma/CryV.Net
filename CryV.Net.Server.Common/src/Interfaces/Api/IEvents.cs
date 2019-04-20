using System;

namespace CryV.Net.Server.Common.Interfaces.Api
{
    public interface IEvents
    {

        event EventHandler<IPlayer> OnPlayerConnected;
        event EventHandler<IPlayer> OnPlayerDisconnected;

    }
}
