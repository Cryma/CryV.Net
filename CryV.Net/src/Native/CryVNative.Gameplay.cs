using System;
using System.Runtime.InteropServices;

namespace CryV.Net.Native
{
    internal static partial class CryVNative
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

        //

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Gameplay_HasAnimDictLoaded(IntPtr plugin, IntPtr animDict);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Gameplay_RequestAnimDict(IntPtr plugin, IntPtr animDict);

        //

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Gameplay_DisableAllControlActions(IntPtr plugin, int inputGroup);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Gameplay_DisableControlAction(IntPtr plugin, int inputGroup, int control, bool disable);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Gameplay_IsDisabledControlJustPressed(IntPtr plugin, int inputGroup, int control);

        //

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Gameplay_DestroyAllCams(IntPtr plugin, bool thisScriptCheck);


        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Gameplay_SetNoLoadingScreen(IntPtr plugin, bool toggle);

    }
}
