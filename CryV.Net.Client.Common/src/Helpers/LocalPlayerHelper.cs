using CryV.Net.Client.Common.Interfaces;
using CryV.Net.Elements;
using CryV.Net.Enums;

namespace CryV.Net.Client.Common.Helpers
{
    public static class LocalPlayerHelper
    {
        
        public static int LocalId { get; set; }

        public static int VehicleId { get; set; } = -1;

        public static Vehicle Vehicle { get; set; }

        public static void SetVehicle(IVehicle vehicle)
        {
            if (vehicle == null)
            {
                VehicleId = -1;
                Vehicle = null;

                return;
            }

            VehicleId = vehicle.Id;
            Vehicle = vehicle.NativeVehicle;
        }

    }
}
