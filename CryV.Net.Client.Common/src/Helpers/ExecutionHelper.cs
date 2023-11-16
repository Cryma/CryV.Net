using System;
using System.Collections.Generic;

namespace CryV.Net.Client.Common.Helpers;

public static class ExecutionHelper
{

    //private static readonly ConcurrentDictionary<string, Action> _executions = new ConcurrentDictionary<string, Action>();
    private static readonly List<string> _executions = [];

    public static void Execute(string key, bool state, Action? onBegin = null, Action? onTick = null, Action? onReset = null)
    {
        if (state)
        {
            lock (_executions)
            {
                if (_executions.Contains(key) == false)
                {
                    onBegin?.Invoke();

                    _executions.Add(key);
                }
            }

            onTick?.Invoke();

            return;
        }

        lock (_executions)
        {
            if (_executions.Remove(key))
            {
                onReset?.Invoke();
            }
        }
    }

}
