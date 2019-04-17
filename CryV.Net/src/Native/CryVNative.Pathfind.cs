using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CryV.Net.Native
{
    internal static partial class CryVNative
    {
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Pathfind_AddNavmeshBlockingObject(IntPtr plugin, float p0, float p1, float p2, float p3, float p4, float p5, float p6, bool p7, ulong p8);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Pathfind_AddNavmeshRequiredRegion(IntPtr plugin, float x, float y, float radius);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Pathfind_AreAllNavmeshRegionsLoaded(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Pathfind_CalculateTravelDistanceBetweenPoints(IntPtr plugin, float x1, float y1, float z1, float x2, float y2, float z2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Pathfind_DisableNavmeshInArea(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4, ulong p5, ulong p6);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Pathfind_DoesNavmeshBlockingObjectExist(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Pathfind_GenerateDirectionsToCoord(IntPtr plugin, float x, float y, float z, bool p3, ref int direction, ref float vehicle, ref float distToNxJunction);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Pathfind_GetIsSlowRoadFlag(IntPtr plugin, int nodeID);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Pathfind_GetNthClosestVehicleNodeId(IntPtr plugin, float x, float y, float z, int nth, int nodetype, float p5, float p6);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Pathfind_GetStreetNameAtCoord(IntPtr plugin, float x, float y, float z, ref ulong streetName, ref ulong crossingRoad);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Pathfind_GetSupportsGpsRouteFlag(IntPtr plugin, int nodeID);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Pathfind_GetVehicleNodeProperties(IntPtr plugin, float x, float y, float z, ref int density, ref int flags);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Pathfind_IsNavmeshLoadedInArea(IntPtr plugin, float x1, float y1, float z1, float x2, float y2, float z2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Pathfind_IsPointOnRoad(IntPtr plugin, float x, float y, float z, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Pathfind_IsVehicleNodeIdValid(IntPtr plugin, int vehicleNodeId);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Pathfind_LoadAllPathNodes(IntPtr plugin, bool keepInMemory);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Pathfind__0x01708E8DD3FF8C65(IntPtr plugin, float p0, float p1, float p2, float p3, float p4, float p5);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Pathfind__0x07FB139B592FA687(IntPtr plugin, float p0, float p1, float p2, float p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Pathfind__0x0B919E1FB47CC4E0(IntPtr plugin, float p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Pathfind__0x16F46FB18C8009E4(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Pathfind__0x1FC289A0C3FF470F(IntPtr plugin, bool p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Pathfind__0x228E5C6AD4D74BFD(IntPtr plugin, bool p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Pathfind__0x2801D0012266DF07(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Pathfind__0x29C24BFBED8AB8FB(IntPtr plugin, float p0, float p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Pathfind__0x336511A34F2E5185(IntPtr plugin, float left, float right);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Pathfind__0x3599D741C9AC6310(IntPtr plugin, float p0, float p1, float p2, float p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Pathfind__0x705A844002B39DC0(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Pathfind__0x869DAACBBE9FA006(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Pathfind__0x8ABE8608576D9CE3(IntPtr plugin, float p0, float p1, float p2, float p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Pathfind__0xA0F8A7517A273C05(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Pathfind__0xAA76052DDA9BFC3E(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4, ulong p5, ulong p6);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Pathfind__0xBBB45C3CF5C8AA85(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Pathfind__0xD0BC1C6FB18EE154(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4, ulong p5, ulong p6);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Pathfind__0xD3A6A0EF48823A8C(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Pathfind__0xF3162836C28F9DA5(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Pathfind__0xF7B79A50B905A30D(IntPtr plugin, float p0, float p1, float p2, float p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Pathfind_RemoveNavmeshBlockingObject(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Pathfind_RemoveNavmeshRequiredRegions(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Pathfind_SetGpsDisabledZone(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4, ulong p5);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Pathfind_SetIgnoreNoGpsFlag(IntPtr plugin, bool ignore);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Pathfind_SetPedPathsBackToOriginal(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4, ulong p5);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Pathfind_SetPedPathsInArea(IntPtr plugin, float x1, float y1, float z1, float x2, float y2, float z2, bool unknown);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Pathfind_SetRoadsBackToOriginal(IntPtr plugin, float p0, float p1, float p2, float p3, float p4, float p5);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Pathfind_SetRoadsBackToOriginalInAngledArea(IntPtr plugin, float x1, float y1, float z1, float x2, float y2, float z2, float p6);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Pathfind_SetRoadsInAngledArea(IntPtr plugin, float x1, float y1, float z1, float x2, float y2, float z2, float angle, bool unknown1, bool unknown2, bool unknown3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Pathfind_SetRoadsInArea(IntPtr plugin, float x1, float y1, float z1, float x2, float y2, float z2, bool unknown1, bool unknown2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Pathfind_UpdateNavmeshBlockingObject(IntPtr plugin, ulong p0, float p1, float p2, float p3, float p4, float p5, float p6, float p7, ulong p8);
    }
}
