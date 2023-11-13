using System;

namespace CryV.Net.Shared.Common.Flags;

[Flags]
public enum PedData
{
    None = 1 << 0,
    IsJumping = 1 << 1,
    IsClimbing = 1 << 2,
    IsClimbingLadder = 1 << 3,
    IsRagdoll = 1 << 4,
    IsAiming = 1 << 5,
    IsEnteringVehicle = 1 << 6,
    IsInVehicle = 1 << 7,
    IsLeavingVehicle = 1 << 8,
    IsFingerPointing = 1 << 9,
}
