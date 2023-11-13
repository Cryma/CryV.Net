using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CryV.Net.Native;

internal static partial class CryVNative
{
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Water_AddCurrentRise(IntPtr plugin, float xLow, float yLow, float xHigh, float yHigh, float height);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern float Native_Water_GetCurrentIntensity(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Water_GetWaterHeight(IntPtr plugin, float x, float y, float z, ref float height);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Water_GetWaterHeightNoWaves(IntPtr plugin, float x, float y, float z, ref float height);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Water_ModifyWater(IntPtr plugin, float x, float y, float radius, float height);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Water__0x547237AA71AB44DE(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Water_RemoveCurrentRise(IntPtr plugin, int p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Water_ResetCurrentIntensity(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Water_SetCurrentIntensity(IntPtr plugin, float intensity);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Water_TestProbeAgainstAllWater(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4, ulong p5, ulong p6, ulong p7);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Water_TestVerticalProbeAgainstAllWater(IntPtr plugin, float x, float y, float z, ulong p3, ref float height);
}
