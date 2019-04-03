﻿using CryV.Net.Client.Elements;
using CryV.Net.Client.Enums;
using CryV.Net.Client.Native;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace CryV.Net.Client
{
    public static class PluginWrapper
    {

        public static ConcurrentQueue<Action> MainThreadQueue = new ConcurrentQueue<Action>();

        public static void Main()
        {
        }

        public static void PluginMain(IntPtr plugin)
        {
            CryVNative.Plugin = plugin;

            World.SetWeather(WeatherType.Thunder);

            LocalPlayer.SetPosition(827.74f, 1295.68f, 364.34f);

            Task.Run(Cleanup);
        }

        private static async Task Cleanup()
        {
            while (true)
            {
                await Task.Delay(TimeSpan.FromMilliseconds(500));

                MainThreadQueue.Enqueue(() =>
                {
                    Utility.Log($"There are currently {World.GetAllPeds().Count} peds!");
                });
            }
        }

        public static void PluginTick()
        {
            var actions = 0;

            while (MainThreadQueue.TryDequeue(out var action))
            {
                actions++;

                action();
            }

            if (actions != 0)
            {
                Utility.Log($"Completed {actions} this tick!");
            }
        }

    }
}
