using System;
using System.Numerics;
using CryV.Net.Shared.Common.Payloads;

namespace CryV.Net.Server.Common.Interfaces
{
    public interface IVehicle : IDisposable
    {

        int Id { get; }

        Vector3 Position { get; set; }

        VehicleUpdatePayload GetPayload();

        void ForceSync();

    }
}
