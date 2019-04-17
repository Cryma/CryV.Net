using System;
using CryV.Net.Shared.Common.Payloads;

namespace CryV.Net.Server.Common.Interfaces
{
    public interface IVehicle : IDisposable
    {

        VehicleUpdatePayload GetPayload();

    }
}
