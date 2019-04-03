using System;
using System.Collections.Concurrent;

namespace CryV.Net.Client
{
    public static class ThreadHelper
    {

        private static readonly ConcurrentQueue<Action> _mainThreadQueue = new ConcurrentQueue<Action>();

        public static void Run(Action action)
        {
            _mainThreadQueue.Enqueue(action);
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