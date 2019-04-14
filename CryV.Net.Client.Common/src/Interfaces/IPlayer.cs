using System;
using CryV.Net.Elements;

namespace CryV.Net.Client.Common.Interfaces
{
    public interface IPlayer : IDisposable
    {

        int Id { get; }
        Ped GetPed();

    }
}
