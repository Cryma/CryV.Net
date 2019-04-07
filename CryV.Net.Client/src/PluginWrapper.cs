using CryV.Net.Client.Elements;
using CryV.Net.Client.Enums;
using CryV.Net.Client.Native;
using System;
using System.Collections.Concurrent;
using System.Drawing;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using CryV.Net.Client.Console;
using Microsoft.Win32;
using Sentry;

namespace CryV.Net.Client
{
    public static class PluginWrapper
    {

        public static ConcurrentQueue<Action> MainThreadQueue = new ConcurrentQueue<Action>();

        private static GameConsole _console;
        private static GameClient _gameClient;

        public static void Main()
        {
        }

        public static void PluginMain(IntPtr plugin)
        {
            AppDomain.CurrentDomain.UnhandledException += OnUnhandledException;

            SetNativePath();

            CryVNative.Plugin = plugin;

            Gameplay.DestroyAllCams(true);
            Gameplay.SetNoLoadingScreen(true);

            Gameplay.UseFreemodeMapBehaviour(true);
            //Gameplay.LoadMpDlcMaps();

            Cleanup.Initial();
            
            World.SetWeather(WeatherType.Extrasunny);

            LocalPlayer.Character.Position = new Vector3(412.4f, -976.71f, 29.43f);
            LocalPlayer.SetModel("mp_m_freemode_01");

            _gameClient = new GameClient();
            _console  = new GameConsole(_gameClient);

            Task.Run(Cleanup.ClearEntities);
        }

        private static void OnUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
#if RELEASE
            using (SentrySdk.Init("https://8229e99d7e144ed0b94e307e9396f341@sentry.io/1432896"))
            {
                SentrySdk.CaptureException((Exception) e.ExceptionObject);
            }
#endif
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
            if (_console.IsVisible == false)
            {
                UserInterface.DrawText("CryV", new Vector2(0.975f, 0.01f), 0.42f, Color.FromArgb(255, 200, 200, 200), TextFont.ChaletLondon, TextAlignment.Center, 1.0f);
            }

            ThreadHelper.Work();

            Cleanup.Tick();

            _gameClient.Tick();
            _console.Update();

            Gameplay.DisableControlAction(0, 199, true);
            Gameplay.DisableControlAction(0, 200, true);

            if (Gameplay.IsDisabledControlJustPressed(0, 199) || Gameplay.IsDisabledControlJustPressed(0, 200))
            {
                CryVNative.Native_UserInterface_ActivateFrontendMenu(CryVNative.Plugin, 3123948979, false, -1);
            }
        }

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool SetDllDirectory(string path);

        private static void SetNativePath()
        {
            using (var key = Registry.CurrentUser.OpenSubKey("Software\\CryV"))
            {
                if (key == null)
                {
                    return;
                }

                var path = key.GetValue("InstallDir").ToString();
                SetDllDirectory(path);
            }
        }

    }
}
