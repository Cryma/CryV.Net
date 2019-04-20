using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using CryV.Net.Helpers;
using CryV.Net.Native;
using CryV.Net.Plugins;
using Microsoft.Win32;
#if RELEASE
using Sentry;
#endif

namespace CryV.Net
{
    internal static class PluginWrapper
    {

        private static IPlugin _plugin;

        public static void Main()
        {
        }

        public static void PluginMain(IntPtr plugin)
        {
            AppDomain.CurrentDomain.UnhandledException += OnUnhandledException;

            SetNativePath();

            CryVNative.Plugin = plugin;

            LoadPlugin();
        }

        private static void OnUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
#if RELEASE
            {
                SentrySdk.CaptureException((Exception) e.ExceptionObject);
            }
#endif
        }

        public static void PluginKeyboardCallback(ConsoleKey key, char character, bool isPressed)
        {
            _plugin.OnKeyboard(key, character, isPressed);
        }

        public static void PluginTick()
        {
            ThreadHelper.Work();

            _plugin.Tick();
        }

        private static void LoadPlugin()
        {
            var assembly = Assembly.LoadFrom(Path.Combine(GetInstallDirectory(), "dotnet/resources/CryV.Net.Client.Core.dll"));

            foreach (var type in assembly.GetTypes())
            {
                if (type.IsClass == false || type.IsAbstract || typeof(IPlugin).IsAssignableFrom(type) == false)
                {
                    continue;
                }

                var constructor = type.GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public, null, Type.EmptyTypes, null);

                var plugin = constructor.Invoke(null);

                _plugin = (IPlugin) plugin;

                return;
            }
        }

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool SetDllDirectory(string path);

        private static void SetNativePath()
        {
            SetDllDirectory(GetInstallDirectory());
        }

        public static string GetInstallDirectory()
        {
            using (var key = Registry.CurrentUser.OpenSubKey("Software\\CryV"))
            {
                return key?.GetValue("InstallDir").ToString();
            }
        }

    }
}
