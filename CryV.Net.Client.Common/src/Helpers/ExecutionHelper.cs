using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace CryV.Net.Client.Common.Helpers
{
    public static class ExecutionHelper
    {

        private static readonly ConcurrentDictionary<string, Action> _executions = new ConcurrentDictionary<string, Action>();

        public static void ExecuteOnce(string key, bool state, Action onBegin, Action onReset = null)
        {
            if (state)
            {
                if (_executions.ContainsKey(key))
                {
                    return;
                }

                onBegin();

                _executions.TryAdd(key, onReset);

                return;
            }

            if (_executions.TryRemove(key, out var resetAction))
            {
                if (resetAction == null)
                {
                    return;
                }

                resetAction();
            }
        }

    }
}
