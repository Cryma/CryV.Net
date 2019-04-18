using System;
using CryV.Net.Elements;

namespace CryV.Net.Client.Common.Interfaces
{
    public interface IVehicle : IDisposable
    {

        int Id { get; }

        ulong Model { get; set; }

        Vehicle GetVehicle();

    }
}