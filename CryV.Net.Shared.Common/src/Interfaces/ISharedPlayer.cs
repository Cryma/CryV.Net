using System.Numerics;

namespace CryV.Net.Shared.Common.Interfaces
{
    public interface ISharedPlayer : ISharedEntity
    {

        Vector3 AimTarget { get; set; }
        int Seat { get; set; }
        int Speed { get; }
        ulong WeaponModel { get; set; }
        bool IsJumping { get; }
        bool IsClimbing { get; }
        bool IsClimbingLadder { get; }
        bool IsRagdoll { get; }
        bool IsAiming { get; }
        bool IsEnteringVehicle { get; }
        bool IsInVehicle { get; }
        bool IsLeavingVehicle { get; }

    }
}
