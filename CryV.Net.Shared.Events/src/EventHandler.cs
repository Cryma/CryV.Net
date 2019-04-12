using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using CryV.Net.Shared.Common.Interfaces;
using CryV.Net.Shared.Events.Subscriptions;

namespace CryV.Net.Shared.Events
{
    public class EventHandler : IEventHandler
    {

        private static readonly ConcurrentDictionary<Type, List<ISubscription>> _subscriptions = new ConcurrentDictionary<Type, List<ISubscription>>();

        public ISubscription Subscribe<TEvent>(Action<TEvent> callback, Func<TEvent, bool> filter = null) where TEvent : IEvent
        {
            return AddSubscription<TEvent>(new Subscription<TEvent>(callback, filter));
        }

        private ISubscription AddSubscription<TEvent>(Subscription<TEvent> callback) where TEvent : IEvent
        {
            _subscriptions.AddOrUpdate(typeof(TEvent), new List<ISubscription> { callback }, (type, list) =>
            {
                lock (list)
                {
                    list.Add(callback);

                    return list;
                }
            });

            return callback;
        }

        public void Publish<TEvent>(TEvent eventInstance) where TEvent : IEvent
        {
            Publish(typeof(TEvent), eventInstance);
        }

        public void Publish(Type eventType, IEvent eventInstance)
        {
            if (_subscriptions.TryGetValue(eventType, out var subscriptions) == false)
            {
                return;
            }

            foreach (var subscription in subscriptions)
            {
                subscription.Invoke(eventInstance);
            }
        }

        public void Unsubscribe(ISubscription subscription)
        {
            if (_subscriptions.TryGetValue(subscription.EventType, out var subscriptions) == false)
            {
                return;
            }

            lock (subscriptions)
            {
                subscriptions.Remove(subscription);

                if (subscriptions.Any())
                {
                    return;
                }

                _subscriptions.TryRemove(subscription.EventType, out _);
            }
        }

    }
}
