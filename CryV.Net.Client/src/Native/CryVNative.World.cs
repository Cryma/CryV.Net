﻿using System;
using System.Runtime.InteropServices;

namespace CryV.Net.Client.Native
{
    public static partial class CryVNative
    {

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_World_SetWeather(IntPtr plugin, IntPtr weather);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Native_World_GetAllPeds(IntPtr plugin);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Native_World_GetAllVehicles(IntPtr plugin);

        //

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Native_World_SetRandomTrains(IntPtr plugin, bool enabled);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Native_World_SetRandomBoats(IntPtr plugin, bool enabled);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Native_World_SetNumberOfParkedVehicles(IntPtr plugin, int amount);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Native_World_SetParkedVehicleDensityMultiplierThisFrame(IntPtr plugin, float multiplier);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Native_World_SetRandomVehicleDensityMultiplierThisFrame(IntPtr plugin, float multiplier);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Native_World_SetVehicleDensityMultiplierThisFrame(IntPtr plugin, float multiplier);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Native_World_SetFarDrawVehicles(IntPtr plugin, bool enabled);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Native_World_SetAllLowPriorityVehicleGeneratorsActive(IntPtr plugin, bool active);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Native_World_DisplayDistantVehicles(IntPtr plugin, bool enabled);

    }
}
