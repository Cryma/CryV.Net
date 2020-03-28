using CryV.Net.Server.Common.Interfaces;
using Micky5991.EventAggregator.Interfaces;

namespace CryV.Net.Server.Common.Events
{
    public class VehicleTrailerDetachedEvent : IEvent
    {

        public IVehicle Vehicle { get; set; }

        public VehicleTrailerDetachedEvent()
        {
        }

        public VehicleTrailerDetachedEvent(IVehicle vehicle)
        {
            Vehicle = vehicle;
        }

    }
}
