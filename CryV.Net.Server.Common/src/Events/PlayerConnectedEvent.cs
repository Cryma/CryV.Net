using CryV.Net.Server.Common.Interfaces;
using Micky5991.EventAggregator.Interfaces;

namespace CryV.Net.Server.Common.Events;

public class PlayerConnectedEvent : IEvent
{

    public IServerPlayer Player { get; set; }

    // Empty construct is needed due to reflection
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public PlayerConnectedEvent()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
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
