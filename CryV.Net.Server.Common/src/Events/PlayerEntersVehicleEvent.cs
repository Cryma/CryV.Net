using CryV.Net.Enums;
using CryV.Net.Server.Common.Interfaces;
using CryV.Net.Shared.Common.Interfaces;

namespace CryV.Net.Server.Common.Events
{
    public class PlayerEntersVehicleEvent : IEvent
    {
        
        public IPlayer Player { get; set; }
        public IVehicle Vehicle { get; set; }

        public VehicleSeat Seat { get; set; }

        public PlayerEntersVehicleEvent()
        {
        }

        public PlayerEntersVehicleEvent(IPlayer player, IVehicle vehicle, VehicleSeat seat)
        {
            Player = player;
            Vehicle = vehicle;
            Seat = seat;
        }

    }
}
