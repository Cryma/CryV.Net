using System;
using System.Runtime.InteropServices;

namespace CryV.Net.Native
{
    internal static partial class CryVNative
    {
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Memory_IsPedInVehicle(IntPtr plugin, int pedId);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Memory_GetVehiclePedIsIn(IntPtr plugin, int pedId);
    }
}
