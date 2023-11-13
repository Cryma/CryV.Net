using System;

namespace CryV.Net.Server.Common.Interfaces.Api;

public interface IEvents
{

    event EventHandler<IServerPlayer> OnPlayerConnected;
    event EventHandler<IServerPlayer> OnPlayerDisconnected;

}
