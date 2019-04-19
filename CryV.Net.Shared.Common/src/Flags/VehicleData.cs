using System;

namespace CryV.Net.Shared.Common.Flags
{
    [Flags]
    public enum VehicleData
    {
        None = 1 << 0,
        IsHornActive = 1 << 1
    }
}
