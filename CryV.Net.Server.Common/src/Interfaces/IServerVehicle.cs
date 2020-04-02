using System;
using System.Numerics;
using CryV.Net.Shared.Common.Interfaces;
using CryV.Net.Shared.Common.Payloads;

namespace CryV.Net.Server.Common.Interfaces
{
    public interface IServerVehicle : ISharedVehicle, IDisposable
    {

        int TrailerId { get; }

        VehicleUpdatePayload GetPayload();

        void ReadPayload(VehicleUpdatePayload payload);

        void ForceSync();

    }
}
