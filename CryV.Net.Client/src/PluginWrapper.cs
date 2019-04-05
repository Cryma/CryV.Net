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
using CryV.Net.Client.Console;
using CryV.Net.Client.Networking;

namespace CryV.Net.Client
{
    public static class PluginWrapper
    {

        public static ConcurrentQueue<Action> MainThreadQueue = new ConcurrentQueue<Action>();

        private static GameConsole _console;

        public static void Main()
        {
        }

        public static void PluginMain(IntPtr plugin)
        {
            CryVNative.Plugin = plugin;

            Gameplay.DestroyAllCams(true);
            Gameplay.SetNoLoadingScreen(true);

            Gameplay.UseFreemodeMapBehaviour(true);
            //Gameplay.LoadMpDlcMaps();

            Cleanup.Initial();
            
            World.SetWeather(WeatherType.Extrasunny);

            LocalPlayer.Character.Position = new Vector3(412.4f, -976.71f, 29.43f);
            LocalPlayer.SetModel("mp_m_freemode_01");

            _console  = new GameConsole();

            Task.Run(Cleanup.ClearEntities);
        }

        public static void PluginKeyboardCallback(ConsoleKey key, char character, bool isPressed)
        {
            _console?.HandleKeyboardCallback(key, character, isPressed);

            if (isPressed && key == ConsoleKey.F3)
            {
                var ped = new Ped("mp_m_freemode_01", new Vector3(412.4f, -976.71f, 29.43f), 0f);
            }
        }

        public static void PluginTick()
        {
            UserInterface.DrawText("CryV", new Vector2(0.9f,  0.01f), 0.42f, Color.FromArgb(255, 200, 200, 200), TextFont.ChaletLondon, TextAlignment.Center, 1.0f);

            ThreadHelper.Work();

            Cleanup.Tick();

            NetworkClient.Tick(); // TODO: Own thread

            _console.Update();
        }

    }
}
