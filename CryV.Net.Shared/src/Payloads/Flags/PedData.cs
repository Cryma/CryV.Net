using System;

namespace CryV.Net.Shared.Payloads.Flags
{
    [Flags]
    public enum PedData
    {
        None = 1 << 0,
        IsJumping = 1 << 1,
        IsClimbing = 1 << 2
    }
}
