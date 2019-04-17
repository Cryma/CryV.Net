using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CryV.Net.Native
{
    internal static partial class CryVNative
    {
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Script_BeginEnumeratingThreads(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Script_DoesScriptExist(IntPtr plugin, IntPtr scriptName);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Script_DoesScriptWithNameHashExist(IntPtr plugin, ulong scriptHash);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Script_GetEventAtIndex(IntPtr plugin, int eventGroup, int eventIndex);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Script_GetEventData(IntPtr plugin, int eventGroup, int eventIndex, ref int argStruct, int argStructSize);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Script_GetEventExists(IntPtr plugin, int eventGroup, int eventIndex);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Script_GetHashOfThisScriptName(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Script_GetIdOfNextThreadInEnumeration(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Script_GetIdOfThisThread(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Native_Script_GetNameOfThread(IntPtr plugin, int threadId);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Script_GetNoLoadingScreen(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Script_GetNumberOfEvents(IntPtr plugin, int eventGroup);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Script_GetNumberOfInstancesOfScriptWithNameHash(IntPtr plugin, ulong scriptHash);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Native_Script_GetThisScriptName(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Script_HasScriptLoaded(IntPtr plugin, IntPtr scriptName);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Script_HasScriptWithNameHashLoaded(IntPtr plugin, ulong scriptHash);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Script_IsThreadActive(IntPtr plugin, int threadId);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Script__0xA40CC53DF8E50837(IntPtr plugin, bool p0, ulong args, int argCount, int bit);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Script__0xB1577667C3708F9B(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Script_RequestScript(IntPtr plugin, IntPtr scriptName);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Script_RequestScriptWithNameHash(IntPtr plugin, ulong scriptHash);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Script_SetNoLoadingScreen(IntPtr plugin, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Script_SetScriptAsNoLongerNeeded(IntPtr plugin, IntPtr scriptName);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Script_SetScriptWithNameHashAsNoLongerNeeded(IntPtr plugin, ulong scriptHash);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Script_ShutdownLoadingScreen(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Script_TerminateThisThread(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Script_TerminateThread(IntPtr plugin, int threadId);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Script_TriggerScriptEvent(IntPtr plugin, int eventGroup, ref int args, int argCount, int bit);
    }
}
