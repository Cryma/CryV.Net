using System;
using System.Runtime.InteropServices;

namespace CryV.Net.Client.Native
{
    public static partial class CryVNative
    {

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Gameplay_TerminateAllScriptsWithThisName(IntPtr plugin, IntPtr scriptName);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Gameplay_RequestModel(IntPtr plugin, ulong model);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Gameplay_HasModelLoaded(IntPtr plugin, ulong model);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Gameplay_SetModelAsNoLongerNeeded(IntPtr plugin, ulong model);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Gameplay_Wait(IntPtr plugin, int ms);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Gameplay_GetHashKey(IntPtr plugin, IntPtr model);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Gameplay_UseFreemodeMapBehaviour(IntPtr plugin, bool enabled);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Gameplay_LoadMpDlcMaps(IntPtr plugin);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Gameplay_DisableAllControlActions(IntPtr plugin, int controlGroup);

    }
}
