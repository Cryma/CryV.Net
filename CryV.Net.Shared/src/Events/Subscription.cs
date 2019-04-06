using System;

namespace CryV.Net.Shared.Events
{
    public class Subscription<TEvent> : ISubscription where TEvent : IEvent
    {

        private readonly Action<TEvent> _callback;
        private readonly Func<TEvent, bool> _filter;

        public Subscription(Action<TEvent> callback, Func<TEvent, bool> filter)
        {
            _callback = callback;
            _filter = filter;
        }

        public void Invoke(object arguments)
        {
            var eventObject = (TEvent) arguments;

            if (_filter != null && _filter(eventObject) == false)
            {
                return;
            }

            _callback(eventObject);
        }

    }
}
