using CryV.Net.Server.Common.Interfaces;
using Micky5991.EventAggregator.Interfaces;

namespace CryV.Net.Server.Common.Events
{
    public class VehicleTrailerDetachEvent : IEvent
    {

        public IVehicle Vehicle { get; set; }

        public VehicleTrailerDetachEvent()
        {
        }

        public VehicleTrailerDetachEvent(IVehicle vehicle)
        {
            Vehicle = vehicle;
        }

    }
}
