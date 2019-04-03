using CryV.Net.Client.Elements;
using CryV.Net.Client.Enums;
using CryV.Net.Client.Native;
using System;
using System.Runtime.InteropServices;

namespace CryV.Net.Client
{
    public static class PluginWrapper
    {

        public static IntPtr Plugin;

        public static void Main()
        {
        }

        public static void PluginMain(IntPtr plugin)
        {
            Plugin = plugin;

            World.SetWeather(WeatherType.Thunder);

            LocalPlayer.SetPosition(827.74f, 1295.68f, 364.34f);
        }

        public static void PluginTick()
        {

        }

    }
}
