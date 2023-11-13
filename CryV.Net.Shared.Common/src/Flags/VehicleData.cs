using System;

namespace CryV.Net.Shared.Common.Flags;

[Flags]
public enum VehicleData
{
    None = 1 << 0,
    IsHornActive = 1 << 1,
    IsBurnout = 1 << 2,
    RoofUp = 1 << 3,
    RoofLowering = 1 << 4,
    RoofDown = 1 << 5,
    RoofRaising = 1 << 6,
    IsSirenActive = 1 << 7
}
