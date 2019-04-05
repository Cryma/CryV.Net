using System;
using System.Runtime.InteropServices;

namespace CryV.Net.Client.Native
{
    public static partial class CryVNative
    {

        public static IntPtr Plugin { get; set; }

        private const string _dllLocation = @"C:\CryV\CryV-Native";

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Utility_Log(IntPtr plugin, IntPtr message);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Utility_FreeArray(IntPtr array);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Utility_FreeObject(IntPtr array);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Utility_IsKeyReleased(IntPtr plugin, ulong key);

    }
}
