using System;

namespace CryV.Net.Shared.Common.Interfaces
{
    public interface IEventHandler
    {

        ISubscription Subscribe<TEvent>(Action<TEvent> callback, Func<TEvent, bool> filter = null) where TEvent : IEvent;

        void Publish<TEvent>(TEvent eventInstance) where TEvent : IEvent;

        void Publish(Type eventType, IEvent eventInstance);

        void Unsubscribe(ISubscription subscription);

    }
}
