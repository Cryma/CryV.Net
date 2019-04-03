using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CryV.Net.Client.Native
{
    public static partial class CryVNative
    {

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity_SetEntityPosition(IntPtr plugin, int entityHandle, float x, float y, float z);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Entity_DoesEntityExist(IntPtr plugin, int entityHandle);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity_SetEntityAsNoLongerNeeded(IntPtr plugin, int entityHandle);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity_SetEntityAsMissionEntity(IntPtr plugin, int entityHandle, bool p1, bool p2);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity_DeleteEntity(IntPtr plugin, int entityHandle);

    }
}
