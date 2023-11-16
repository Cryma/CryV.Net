using CryV.Net.Elements;
using Microsoft.Extensions.Hosting;

namespace CryV.Net.Client.Common.Interfaces;

public interface IVehicleManager : IHostedService
{

    IClientVehicle? GetVehicle(int vehicleId);
    IClientVehicle? GetVehicle(Vehicle vehicle);

}
