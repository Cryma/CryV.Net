using CryV.Net.Elements;

namespace CryV.Net.Client.Common.Interfaces
{
    public interface IVehicleManager
    {

        IClientVehicle GetVehicle(int vehicleId);
        IClientVehicle GetVehicle(Vehicle vehicle);

    }
}
