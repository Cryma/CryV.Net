using System;
using CryV.Net.Elements;
using CryV.Net.Shared.Common.Payloads;

namespace CryV.Net.Client.Common.Interfaces
{
    public interface IVehicle : IDisposable
    {

        int Id { get; }

        ulong Model { get; set; }

        Vehicle NativeVehicle { get; }

        bool IsAttachedTrailer { get; set; }

        VehicleUpdatePayload LastSentUpdatePayload { get; set; }

        void ReadPayload(VehicleUpdatePayload payload);

    }
}
