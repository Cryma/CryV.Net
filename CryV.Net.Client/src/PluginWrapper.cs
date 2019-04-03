using CryV.Net.Client.Elements;
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

            World.SetWeather(WeatherType.Extrasunny);

            LocalPlayer.SetPosition(412.4f, -976.71f, 29.43f);

            Task.Run(Cleanup);
        }

        private static async Task Cleanup()
        {
            while (true)
            {
                await Task.Delay(TimeSpan.FromMilliseconds(500));

                ThreadHelper.Run(() =>
                {
                    var deletedPeds = 0;
                    foreach (var ped in World.GetAllPeds())
                    {
                        if (ped.DoesExist() == false)
                        {
                            continue;
                        }

                        ped.SetAsNoLongerNeeded();
                        ped.SetAsMissionEntity();

                        ped.Delete();

                        deletedPeds++;
                    }

                    if (deletedPeds != 0)
                    {
                        Utility.Log($"Deleted {deletedPeds} peds!");
                    }

                    var deletedVehicles = 0;
                    foreach (var vehicle in World.GetAllVehicles())
                    {
                        if (vehicle.DoesExist() == false)
                        {
                            continue;
                        }

                        vehicle.SetAsNoLongerNeeded();
                        vehicle.SetAsMissionEntity();

                        vehicle.Delete();

                        deletedVehicles++;
                    }

                    if (deletedVehicles != 0)
                    {
                        Utility.Log($"Deleted {deletedVehicles} vehicles!");
                    }
                });
            }
        }

        public static void PluginTick()
        {
            ThreadHelper.Work();
        }

    }
}
