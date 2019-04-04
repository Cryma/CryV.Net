using System;
using System.Runtime.InteropServices;

namespace CryV.Net.Client.Native
{
    public static partial class CryVNative
    {

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Ped_SetPedDefaultComponentVariation(IntPtr plugin, int pedId);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Ped_CreatePed(IntPtr plugin, int pedType, ulong modelHash, float x, float y, float z, float heading, bool isNetwork, bool thisScriptCheck);

    }
}
