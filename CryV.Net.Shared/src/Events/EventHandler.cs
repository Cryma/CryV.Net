using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace CryV.Net.Shared.Events
{
    public static class EventHandler
    {
        
        private static readonly ConcurrentDictionary<Type, List<ISubscription>> _subscriptions = new ConcurrentDictionary<Type, List<ISubscription>>();

        public static void Subscribe<TEvent>(Action<TEvent> callback, Func<TEvent, bool> filter = null) where TEvent : IEvent
        {
            AddSubscription(new Subscription<TEvent>(callback, filter));
        }

        private static void AddSubscription<TEvent>(Subscription<TEvent> callback) where TEvent : IEvent
        {
            _subscriptions.AddOrUpdate(typeof(TEvent), new List<ISubscription> { callback }, (type, list) =>
            {
                lock (list)
                {
                    list.Add(callback);

                    return list;
                }
            });
        }

        public static void Publish<TEvent>(TEvent eventInstance) where TEvent : IEvent
        {
            Publish(typeof(TEvent), eventInstance);
        }

        public static void Publish(Type type, IEvent eventInstance)
        {
            if (_subscriptions.TryGetValue(type, out var subscriptions) == false)
            {
                return;
            }

            foreach (var subscription in subscriptions)
            {
                subscription.Invoke(eventInstance);
            }
        }

    }
}
