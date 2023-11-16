using CryV.Net.Client.Common.Interfaces;
using CryV.Net.Elements;

namespace CryV.Net.Client.Common.Helpers;

public static class LocalPlayerHelper
{

    public static int LocalId { get; set; }

    public static int? VehicleId { get; set; } = null;

    public static Vehicle? Vehicle { get; set; }

    public static void SetVehicle(IClientVehicle? vehicle)
    {
        if (vehicle == null)
        {
            VehicleId = null;
            Vehicle = null;

            return;
        }

        VehicleId = vehicle.Id;
        Vehicle = vehicle.NativeVehicle;
    }

}
