using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CryV.Net.Native;

internal static partial class CryVNative
{
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Shapetest_ShapeTestResultEntity(IntPtr plugin, int entityHit);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Shapetest_StartShapeTestBound(IntPtr plugin, int entity, int flags1, int flags2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Shapetest_StartShapeTestBoundingBox(IntPtr plugin, int entity, int flags1, int flags2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Shapetest_StartShapeTestBox(IntPtr plugin, float x, float y, float z, float x1, float y2, float z2, float rotX, float rotY, float rotZ, ulong p9, ulong p10, ulong entity, ulong p12);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Shapetest_StartShapeTestCapsule(IntPtr plugin, float x1, float y1, float z1, float x2, float y2, float z2, float radius, int flags, int entity, int p9);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Shapetest_StartShapeTestCapsule2(IntPtr plugin, float x1, float y1, float z1, float x2, float y2, float z2, float radius, int flags, int entity, ulong p9);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Shapetest_StartShapeTestLosProbe(IntPtr plugin, float x1, float y1, float z1, float x2, float y2, float z2, int flags, int ent, int p8);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Shapetest_StartShapeTestRay(IntPtr plugin, float x1, float y1, float z1, float x2, float y2, float z2, int flags, int entity, int p8);
}
