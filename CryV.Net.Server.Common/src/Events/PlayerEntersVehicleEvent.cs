using CryV.Net.Server.Common.Interfaces;
using CryV.Net.Shared.Common.Interfaces;

namespace CryV.Net.Server.Common.Events
{
    public class PlayerEntersVehicleEvent : IEvent
    {
        
        public IPlayer Player { get; set; }
        public IVehicle Vehicle { get; set; }

        public PlayerEntersVehicleEvent()
        {
        }

        public PlayerEntersVehicleEvent(IPlayer player, IVehicle vehicle)
        {
            Player = player;
            Vehicle = vehicle;
        }

    }
}
