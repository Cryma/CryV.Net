using System;
using CryV.Net.Elements;
using CryV.Net.Shared.Common.Payloads;

namespace CryV.Net.Client.Common.Interfaces
{
    public interface IVehicle : IDisposable
    {

        int Id { get; }

        ulong Model { get; set; }

        Vehicle GetVehicle();

        void ReadPayload(VehicleUpdatePayload payload, bool forceSync = false);

    }
}