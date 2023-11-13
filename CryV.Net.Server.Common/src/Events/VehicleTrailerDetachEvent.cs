using CryV.Net.Server.Common.Interfaces;
using Micky5991.EventAggregator.Interfaces;

namespace CryV.Net.Server.Common.Events
{
    public class VehicleTrailerDetachEvent : IEvent
    {

        public IServerVehicle Vehicle { get; set; }

        public VehicleTrailerDetachEvent()
        {
        }

        public VehicleTrailerDetachEvent(IServerVehicle vehicle)
        {
            Vehicle = vehicle;
        }

        public bool IsCancellable()
        {
            return false;
        }

    }
}
