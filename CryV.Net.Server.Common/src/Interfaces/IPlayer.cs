using System;
using System.Numerics;
using CryV.Net.Shared.Common.Payloads;
using LiteNetLib;
using ConnectionState = CryV.Net.Server.Common.Enums.ConnectionState;

namespace CryV.Net.Server.Common.Interfaces
{
    public interface IPlayer : IDisposable
    {
        
        int Id { get; }

        ConnectionState ConnectionState { get; set; }

        Vector3 Position { get; set; }
        Vector3 Velocity { get; set; }
        float Heading { get; set; }
        Vector3 AimTarget { get; set; }
        int Speed { get; }
        ulong Model { get; set; }
        ulong WeaponModel { get; set; }
        bool IsJumping { get; }
        bool IsClimbing { get; }
        bool IsClimbingLadder { get; }
        bool IsRagdoll { get; }
        bool IsAiming { get; }
        bool IsEnteringVehicle { get; }
        bool IsInVehicle { get; }
        bool IsLeavingVehicle { get; }
        IVehicle Vehicle { get; set; }
        int Seat { get; set; }

        PlayerUpdatePayload GetPayload();
        void ReadPayload(PlayerUpdatePayload payload);

        void Send(IPayload payload, DeliveryMethod deliveryMethod);

        NetPeer GetPeer();

    }
}
