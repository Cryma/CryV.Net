using System;
using CryV.Net.Elements;
using CryV.Net.Shared.Common.Interfaces;
using CryV.Net.Shared.Common.Payloads;

namespace CryV.Net.Client.Common.Interfaces;

public interface IClientVehicle : ISharedVehicle, IDisposable
{

    Vehicle NativeVehicle { get; }

    bool IsAttachedTrailer { get; set; }

    VehicleUpdatePayload LastSentUpdatePayload { get; set; }

}
