using CryV.Net.Elements;

namespace CryV.Net.Client.Common.Interfaces
{
    public interface IVehicleManager
    {

        IVehicle GetVehicle(int vehicleId);
        IVehicle GetVehicle(Vehicle vehicle);

    }
}
