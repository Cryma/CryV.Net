﻿using System;

namespace CryV.Net.Server.Common.Interfaces.Api
{
    public interface ICommandHandler
    {

        void AddCommand(string commandName, Action<IPlayer, string[]> callback);

    }
}
