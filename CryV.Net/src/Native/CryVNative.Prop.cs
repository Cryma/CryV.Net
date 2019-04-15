using System;
using System.Runtime.InteropServices;

namespace CryV.Net.Native
{
    internal static partial class CryVNative
    {

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Prop_CreateObject(IntPtr plugin, ulong hash, float x, float y, float z, bool isNetwork, bool thisScriptCheck, bool dynamic);

    }
}
