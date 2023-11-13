using CryV.Net.Server.Common.Interfaces;
using Micky5991.EventAggregator.Interfaces;

namespace CryV.Net.Server.Common.Events;

public class PlayerConnectedEvent : IEvent
{

    public IServerPlayer Player { get; set; }

    public PlayerConnectedEvent()
    {
    }

    public PlayerConnectedEvent(IServerPlayer player)
    {
        Player = player;
    }

    public bool IsCancellable()
    {
        return false;
    }
}
