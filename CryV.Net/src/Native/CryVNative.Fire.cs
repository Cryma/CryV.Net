using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CryV.Net.Native;

internal static partial class CryVNative
{
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Fire_AddExplosion(IntPtr plugin, float x, float y, float z, int explosionType, float damageScale, bool isAudible, bool isInvisible, float cameraShake);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Fire_AddExplosionWithUserVfx(IntPtr plugin, float x, float y, float z, int explosionType, ulong explosionFx, float damageScale, bool isAudible, bool isInvisible, float cameraShake);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Fire_AddOwnedExplosion(IntPtr plugin, int ped, float x, float y, float z, int explosionType, float damageScale, bool isAudible, bool isInvisible, float cameraShake);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Fire_GetNumberOfFiresInRange(IntPtr plugin, float x, float y, float z, float radius);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Fire_GetPedInsideExplosionArea(IntPtr plugin, int explosionType, float x1, float y1, float z1, float x2, float y2, float z2, float radius);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Fire_IsEntityOnFire(IntPtr plugin, int entity);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Fire_IsExplosionInAngledArea(IntPtr plugin, int explosionType, float x1, float y1, float z1, float x2, float y2, float z2, float angle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Fire_IsExplosionInArea(IntPtr plugin, int explosionType, float x1, float y1, float z1, float x2, float y2, float z2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Fire_IsExplosionInSphere(IntPtr plugin, int explosionType, float x, float y, float z, float radius);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Fire__0x6070104B699B2EF4(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4, ulong p5, ulong p6);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Fire_RemoveScriptFire(IntPtr plugin, int fireHandle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Fire_StartEntityFire(IntPtr plugin, int entity);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Fire_StartScriptFire(IntPtr plugin, float X, float Y, float Z, int maxChildren, bool isGasFire);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Fire_StopEntityFire(IntPtr plugin, int entity);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Fire_StopFireInRange(IntPtr plugin, float x, float y, float z, float radius);
}
