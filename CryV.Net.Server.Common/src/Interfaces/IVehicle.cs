using System;
using System.Numerics;
using CryV.Net.Shared.Common.Payloads;

namespace CryV.Net.Server.Common.Interfaces
{
    public interface IVehicle : IDisposable
    {

        int Id { get; }

        Vector3 Position { get; set; }
        Vector3 Velocity { get; set; }
        Vector3 Rotation { get; set; }
        float EngineHealth { get; set; }
        string NumberPlate { get; set; }
        ulong Model { get; }
        bool EngineState { get; set; }
        byte CurrentGear { get; set; }
        float CurrentRPM { get; set; }
        float Clutch { get; set; }
        float Turbo { get; set; }
        float Acceleration { get; set; }
        float Brake { get; set; }
        int ColorPrimary { get; set; }
        int ColorSecondary { get; set; }
        bool IsHornActive { get; }
        bool IsBurnout { get; }
        bool IsRoofUp { get; }
        bool IsRoofLowering { get; }
        bool IsRoofDown { get; }
        bool IsRoofRaising { get; }
        int TrailerId { get; }

        VehicleUpdatePayload GetPayload();
        void ReadPayload(VehicleUpdatePayload payload);

        void ForceSync();

    }
}
