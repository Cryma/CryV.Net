using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CryV.Net.Client.Native
{
    public static partial class CryVNative
    {

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_LocalPlayer_PlayerId(IntPtr plugin);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_LocalPlayer_PedId(IntPtr plugin);

    }
}
