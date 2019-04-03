using System;
using System.Runtime.InteropServices;

namespace CryV.Net.Client.Native
{
    public static partial class CryVNative
    {

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_World_SetWeather(IntPtr plugin, IntPtr weather);

    }
}
