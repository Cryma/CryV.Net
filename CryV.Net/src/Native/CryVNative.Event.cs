using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CryV.Net.Native
{
    internal static partial class CryVNative
    {
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Event_BlockDecisionMakerEvent(IntPtr plugin, ulong name, int type);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Event_ClearDecisionMakerEventResponse(IntPtr plugin, ulong name, int type);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Event_IsShockingEventInSphere(IntPtr plugin, int type, float x, float y, float z, float radius);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Event_RemoveAllShockingEvents(IntPtr plugin, bool p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Event_RemoveShockingEventSpawnBlockingAreas(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Event_SetDecisionMaker(IntPtr plugin, int ped, ulong name);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Event_SuppressAgitationEventsNextFrame(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Event_SuppressShockingEventsNextFrame(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Event_SuppressShockingEventTypeNextFrame(IntPtr plugin, int type);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Event_UnblockDecisionMakerEvent(IntPtr plugin, ulong name, int type);
    }
}
