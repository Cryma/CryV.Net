using CryV.Net.Server.Common.Interfaces;
using CryV.Net.Shared.Common.Enums;
using Micky5991.EventAggregator.Interfaces;

namespace CryV.Net.Server.Common.Events;

public class PlayerEntersVehicleEvent : IEvent
{
    
    public IServerPlayer Player { get; set; }
    public IServerVehicle Vehicle { get; set; }

    public VehicleSeat Seat { get; set; }

    // Empty construct is needed due to reflection
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public PlayerEntersVehicleEvent()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    {
    }

    public PlayerEntersVehicleEvent(IServerPlayer player, IServerVehicle vehicle, VehicleSeat seat)
    {
        Player = player;
        Vehicle = vehicle;
        Seat = seat;
    }

    public bool IsCancellable()
    {
        return false;
    }

}
