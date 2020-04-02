using System;
using CryV.Net.Elements;
using CryV.Net.Shared.Common.Interfaces;

namespace CryV.Net.Client.Common.Interfaces
{
    public interface IClientPlayer : ISharedPlayer, IDisposable
    {

        Ped NativePed { get; }

    }
}
