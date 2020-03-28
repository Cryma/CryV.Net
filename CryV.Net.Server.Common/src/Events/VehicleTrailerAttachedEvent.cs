using CryV.Net.Server.Common.Interfaces;
using Micky5991.EventAggregator.Interfaces;

namespace CryV.Net.Server.Common.Events
{
    public class VehicleTrailerAttachedEvent : IEvent
    {

        public IVehicle Vehicle { get; set; }

        public VehicleTrailerAttachedEvent()
        {
        }

        public VehicleTrailerAttachedEvent(IVehicle vehicle)
        {
            Vehicle = vehicle;
        }

    }
}
