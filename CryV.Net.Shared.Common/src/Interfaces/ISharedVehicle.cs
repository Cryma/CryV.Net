using CryV.Net.Shared.Common.Payloads;

namespace CryV.Net.Shared.Common.Interfaces;

public interface ISharedVehicle : ISharedEntity
{
    float EngineHealth { get; set; }
    string? NumberPlate { get; set; }
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

    void ReadPayload(VehicleUpdatePayload payload);

}
