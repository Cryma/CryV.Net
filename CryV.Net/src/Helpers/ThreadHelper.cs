using System;
using System.Collections.Concurrent;

namespace CryV.Net.Helpers
{
    public static class ThreadHelper
    {

        private static readonly ConcurrentQueue<Action> _mainThreadQueue = new ConcurrentQueue<Action>();

        public static void Run(Action action)
        {
            _mainThreadQueue.Enqueue(action);
        }

        public static void Run<T>(Func<T> action, Action<T> callback)
        {
            _mainThreadQueue.Enqueue(() =>
            {
                var result = action();

                callback(result);
            });
        }

        public static void Work()
        {
            while (_mainThreadQueue.TryDequeue(out var action))
            {
                action();
            }
        }

    }
}
