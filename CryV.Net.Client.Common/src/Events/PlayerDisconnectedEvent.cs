﻿using CryV.Net.Client.Common.Interfaces;
using Micky5991.EventAggregator.Interfaces;

namespace CryV.Net.Client.Common.Events
{
    public class PlayerDisconnectedEvent : IEvent
    {
        
        public IPlayer Player { get; set; }

        public PlayerDisconnectedEvent(IPlayer player)
        {
            Player = player;
        }

    }
}
