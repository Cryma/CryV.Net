using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace CryV.Net.Client.Common.Helpers;

public static class ExecutionHelper
{

    //private static readonly ConcurrentDictionary<string, Action> _executions = new ConcurrentDictionary<string, Action>();
    private static readonly List<string> _executions = new List<string>();

    public static void Execute(string key, bool state, Action onBegin = null, Action onTick = null, Action onReset = null)
    {
        if (state)
        {
            lock (_executions)
            {
                if (_executions.Contains(key) == false)
                {
                    onBegin();

                    _executions.Add(key);
                }
            }

            onTick();

            return;
        }

        lock (_executions)
        {
            if (_executions.Remove(key))
            {
                if (onReset == null)
                {
                    return;
                }

                onReset();
            }
        }
    }

}
