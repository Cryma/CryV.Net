using CryV.Net.Server.Common.Interfaces;
using Micky5991.EventAggregator.Interfaces;

namespace CryV.Net.Server.Common.Events;

public class PlayerDisconnectedEvent : IEvent
{
    
    public IServerPlayer Player { get; set; }

    public PlayerDisconnectedEvent(IServerPlayer player)
    {
        Player = player;
    }

    public bool IsCancellable()
    {
        return false;
    }

}
