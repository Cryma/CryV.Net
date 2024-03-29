﻿using CryV.Net.Enums;
using CryV.Net.Server.Common.Interfaces;
using Micky5991.EventAggregator.Interfaces;

namespace CryV.Net.Server.Common.Events
{
    public class PlayerEntersVehicleEvent : IEvent
    {
        
        public IServerPlayer Player { get; set; }
        public IServerVehicle Vehicle { get; set; }

        public VehicleSeat Seat { get; set; }

        public PlayerEntersVehicleEvent()
        {
        }

        public PlayerEntersVehicleEvent(IServerPlayer player, IServerVehicle vehicle, VehicleSeat seat)
        {
            Player = player;
            Vehicle = vehicle;
            Seat = seat;
        }

    }
}
