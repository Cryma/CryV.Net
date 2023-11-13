using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CryV.Net.Native;

internal static partial class CryVNative
{
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Interior_AddPickupToInteriorRoomByName(IntPtr plugin, int pickup, IntPtr roomName);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Interior_AreCoordsCollidingWithExterior(IntPtr plugin, float x, float y, float z);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Interior_CapInterior(IntPtr plugin, int interiorID, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Interior_ClearRoomForEntity(IntPtr plugin, int entity);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Interior_DisableInterior(IntPtr plugin, int interiorID, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Interior_DisableInteriorProp(IntPtr plugin, int interiorID, IntPtr propName);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Interior_EnableInteriorProp(IntPtr plugin, int interiorID, IntPtr propName);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Interior_ForceRoomForEntity(IntPtr plugin, int entity, int interiorID, ulong roomHashKey);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Interior_GetInteriorAtCoords(IntPtr plugin, float x, float y, float z);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Interior_GetInteriorAtCoordsWithType(IntPtr plugin, float x, float y, float z, IntPtr interiorType);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Interior_GetInteriorFromCollision(IntPtr plugin, float x, float y, float z);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Interior_GetInteriorFromEntity(IntPtr plugin, int entity);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Interior_GetInteriorGroupId(IntPtr plugin, int interiorID);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Interior_GetKeyForEntityInRoom(IntPtr plugin, int entity);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern IntPtr Native_Interior_GetOffsetFromInteriorInWorldCoords(IntPtr plugin, int interiorID, float x, float y, float z);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Interior_GetRoomKeyFromEntity(IntPtr plugin, int entity);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Interior_GetRoomKeyFromGameplayCam(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Interior_HideMapObjectThisFrame(IntPtr plugin, ulong mapObjectHash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Interior_IsInteriorCapped(IntPtr plugin, int interiorID);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Interior_IsInteriorDisabled(IntPtr plugin, int interiorID);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Interior_IsInteriorPropEnabled(IntPtr plugin, int interiorID, IntPtr propName);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Interior_IsInteriorReady(IntPtr plugin, int interiorID);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Interior_IsInteriorScene(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Interior_IsValidInterior(IntPtr plugin, int interiorID);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Interior_LoadInterior(IntPtr plugin, int interiorID);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Interior__0x23B59D8912F94246(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Interior__0x405DC2AEF6AF95B9(IntPtr plugin, ulong roomHashKey);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Interior__0x483ACA1176CA93F1(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Interior__0x4C2330E61D3DEB56(IntPtr plugin, int interiorID);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Interior__0x50C375537449F369(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Interior__0x7241CCB7D020DB69(IntPtr plugin, ulong p0, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Interior__0x82EBB79E258FA2B7(IntPtr plugin, int entity, int interiorID);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Interior__0x920D853F3E17F1DA(IntPtr plugin, int interiorID, ulong roomHashKey);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Interior__0x9E6542F0CE8E70A3(IntPtr plugin, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Interior__0xAF348AFCB575A441(IntPtr plugin, IntPtr roomName);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Interior_RefreshInterior(IntPtr plugin, int interiorID);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Interior_SetInteriorPropColor(IntPtr plugin, int interiorID, IntPtr propName, int color);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Interior_UnkGetInteriorAtCoords(IntPtr plugin, float x, float y, float z, int unk);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Interior_UnpinInterior(IntPtr plugin, int interiorID);
}
