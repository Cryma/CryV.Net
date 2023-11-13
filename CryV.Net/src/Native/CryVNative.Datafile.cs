using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CryV.Net.Native;

internal static partial class CryVNative
{
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Datafile_ArrayValueAddBoolean(IntPtr plugin, ref ulong arrayData, bool value);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Datafile_ArrayValueAddFloat(IntPtr plugin, ref ulong arrayData, float value);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Datafile_ArrayValueAddInteger(IntPtr plugin, ref ulong arrayData, int value);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ref ulong Native_Datafile_ArrayValueAddObject(IntPtr plugin, ref ulong arrayData);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Datafile_ArrayValueAddString(IntPtr plugin, ref ulong arrayData, IntPtr value);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Datafile_ArrayValueAddVector3(IntPtr plugin, ref ulong arrayData, float valueX, float valueY, float valueZ);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Datafile_ArrayValueGetBoolean(IntPtr plugin, ref ulong arrayData, int arrayIndex);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern float Native_Datafile_ArrayValueGetFloat(IntPtr plugin, ref ulong arrayData, int arrayIndex);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Datafile_ArrayValueGetInteger(IntPtr plugin, ref ulong arrayData, int arrayIndex);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ref ulong Native_Datafile_ArrayValueGetObject(IntPtr plugin, ref ulong arrayData, int arrayIndex);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Datafile_ArrayValueGetSize(IntPtr plugin, ref ulong arrayData);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern IntPtr Native_Datafile_ArrayValueGetString(IntPtr plugin, ref ulong arrayData, int arrayIndex);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Datafile_ArrayValueGetType(IntPtr plugin, ref ulong arrayData, int arrayIndex);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern IntPtr Native_Datafile_ArrayValueGetVector3(IntPtr plugin, ref ulong arrayData, int arrayIndex);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Datafile_DatafileCreate(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Datafile_DatafileDelete(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern IntPtr Native_Datafile_DatafileGetFileDict(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Datafile_DatafileIsSavePending(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Datafile_LoadUgcFile(IntPtr plugin, IntPtr filename);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Datafile__0x01095C95CD46B624(IntPtr plugin, int p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Datafile__0x15FF52B809DB2353(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Datafile__0x22DA66936E0FFF37(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Datafile__0x2ED61456317B8178(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Datafile__0x4645DE9980999E93(IntPtr plugin, IntPtr p0, IntPtr p1, IntPtr p2, IntPtr p3, IntPtr type);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Datafile__0x4DFDD9EB705F8140(IntPtr plugin, ref bool p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Datafile__0x52818819057F2B40(IntPtr plugin, int p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Datafile__0x648E7A5434AF7969(IntPtr plugin, IntPtr p0, ref ulong p1, bool p2, ref ulong p3, ref ulong p4, ref ulong p5, IntPtr type);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Datafile__0x692D808C34A82143(IntPtr plugin, IntPtr p0, float p1, IntPtr type);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Datafile__0x6CC86E78358D5119(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Datafile__0x83BCCE3224735F05(IntPtr plugin, IntPtr filename);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Datafile__0x8F5EA1C01D65A100(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Datafile__0x9CB0BFA7A9342C3D(IntPtr plugin, int p0, bool p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Datafile__0xA5EFC3E847D60507(IntPtr plugin, IntPtr p0, IntPtr p1, IntPtr p2, IntPtr p3, bool p4);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Datafile__0xA69AC4ADE82B57A4(IntPtr plugin, int p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Datafile__0xAD6875BBC0FC899C(IntPtr plugin, int x);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Datafile__0xC55854C7D7274882(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Datafile__0xC84527E235FCA219(IntPtr plugin, IntPtr p0, bool p1, IntPtr p2, ref ulong p3, ref ulong p4, IntPtr type, bool p6);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Datafile__0xF8CC1EBE0B62E29F(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Datafile__0xFCCAE5B92A830878(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ref ulong Native_Datafile_ObjectValueAddArray(IntPtr plugin, ref ulong objectData, IntPtr key);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Datafile_ObjectValueAddBoolean(IntPtr plugin, ref ulong objectData, IntPtr key, bool value);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Datafile_ObjectValueAddFloat(IntPtr plugin, ref ulong objectData, IntPtr key, float value);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Datafile_ObjectValueAddInteger(IntPtr plugin, ref ulong objectData, IntPtr key, int value);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ref ulong Native_Datafile_ObjectValueAddObject(IntPtr plugin, ref ulong objectData, IntPtr key);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Datafile_ObjectValueAddString(IntPtr plugin, ref ulong objectData, IntPtr key, IntPtr value);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Datafile_ObjectValueAddVector3(IntPtr plugin, ref ulong objectData, IntPtr key, float valueX, float valueY, float valueZ);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ref ulong Native_Datafile_ObjectValueGetArray(IntPtr plugin, ref ulong objectData, IntPtr key);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Datafile_ObjectValueGetBoolean(IntPtr plugin, ref ulong objectData, IntPtr key);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern float Native_Datafile_ObjectValueGetFloat(IntPtr plugin, ref ulong objectData, IntPtr key);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Datafile_ObjectValueGetInteger(IntPtr plugin, ref ulong objectData, IntPtr key);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ref ulong Native_Datafile_ObjectValueGetObject(IntPtr plugin, ref ulong objectData, IntPtr key);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern IntPtr Native_Datafile_ObjectValueGetString(IntPtr plugin, ref ulong objectData, IntPtr key);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Datafile_ObjectValueGetType(IntPtr plugin, ref ulong objectData, IntPtr key);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern IntPtr Native_Datafile_ObjectValueGetVector3(IntPtr plugin, ref ulong objectData, IntPtr key);
}
