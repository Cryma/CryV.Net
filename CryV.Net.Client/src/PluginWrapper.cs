using CryV.Net.Client.Elements;
using CryV.Net.Client.Enums;
using CryV.Net.Client.Native;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;
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

            Cleanup.Initial();
            
            World.SetWeather(WeatherType.Extrasunny);

            LocalPlayer.SetPosition(412.4f, -976.71f, 29.43f);

            Task.Run(Cleanup.ClearEntities);
        }

        public static void PluginKeyboardCallback(ConsoleKey key, char character, bool isPressed)
        {

        }

        public static void PluginTick()
        {
            UserInterface.DrawText("CryV", new Vector2(0.9f,  0.01f), 0.42f, Color.FromArgb(255, 200, 200, 200), TextFont.ChaletLondon, TextAlignment.Center, 1.0f);

            ThreadHelper.Work();

            Cleanup.Tick();
        }

    }
}
