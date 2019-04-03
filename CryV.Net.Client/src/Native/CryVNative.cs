using System;
using System.Runtime.InteropServices;

namespace CryV.Net.Client.Native
{
    public static partial class CryVNative
    {

        public static IntPtr Plugin { get; set; }

        private const string _dllLocation = @"C:\Development\CryV\bin\Release-windows-x86_64\CryV-Launcher\CryV-Native";

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Utility_Log(IntPtr plugin, IntPtr message);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Utility_FreeArray(IntPtr array);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Utility_FreeObject(IntPtr array);

    }
}
