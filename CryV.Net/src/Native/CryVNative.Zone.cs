using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CryV.Net.Native;

internal static partial class CryVNative
{
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Zone_ClearPopscheduleOverrideVehicleModel(IntPtr plugin, int scheduleId);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Zone_GetHashOfMapAreaAtCoords(IntPtr plugin, float x, float y, float z);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern IntPtr Native_Zone_GetNameOfZone(IntPtr plugin, float x, float y, float z);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Zone_GetZoneAtCoords(IntPtr plugin, float x, float y, float z);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Zone_GetZoneFromNameId(IntPtr plugin, IntPtr zoneName);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Zone_GetZonePopschedule(IntPtr plugin, int zoneId);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Zone_GetZoneScumminess(IntPtr plugin, int zoneId);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Zone_OverridePopscheduleVehicleModel(IntPtr plugin, int scheduleId, ulong vehicleHash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Zone_SetZoneEnabled(IntPtr plugin, int zoneId, bool toggle);
}
