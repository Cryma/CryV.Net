using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CryV.Net.Native;

internal static partial class CryVNative
{
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Physics_ActivatePhysics(IntPtr plugin, int entity);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Physics_AddRope(IntPtr plugin, float x, float y, float z, float rotX, float rotY, float rotZ, float length, int ropeType, float maxLength, float minLength, float p10, bool p11, bool p12, bool rigid, float p14, bool breakWhenShot, ref ulong unkPtr);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Physics_ApplyImpulseToCloth(IntPtr plugin, float posX, float posY, float posZ, float vecX, float vecY, float vecZ, float impulse);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Physics_AttachEntitiesToRope(IntPtr plugin, int rope, int ent1, int ent2, float ent1_x, float ent1_y, float ent1_z, float ent2_x, float ent2_y, float ent2_z, float length, bool p10, bool p11, IntPtr boneName1, IntPtr boneName2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Physics_AttachRopeToEntity(IntPtr plugin, int rope, int entity, float x, float y, float z, bool p5);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Physics_BreakEntityGlass(IntPtr plugin, ulong p0, float p1, float p2, float p3, float p4, float p5, float p6, float p7, float p8, ulong p9, bool p10);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Physics_DeleteChildRope(IntPtr plugin, int rope);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Physics_DeleteRope(IntPtr plugin, ref int rope);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Physics_DetachRopeFromEntity(IntPtr plugin, int rope, int entity);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Physics_DoesRopeExist(IntPtr plugin, ref int rope);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern IntPtr Native_Physics_GetCgoffset(IntPtr plugin, int rope);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Physics_GetRopeLastVertexCoord(IntPtr plugin, int rope);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern float Native_Physics_GetRopeLength(IntPtr plugin, int rope);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern IntPtr Native_Physics_GetRopeVertexCoord(IntPtr plugin, int rope, int vertex);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Physics_GetRopeVertexCount(IntPtr plugin, int rope);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Physics_LoadRopeData(IntPtr plugin, int rope, IntPtr rope_preset);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Physics__0x0C112765300C7E1E(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Physics__0x15F944730C832252(IntPtr plugin, ulong p0, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Physics__0x271C9D3ACA5D6409(IntPtr plugin, int rope);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Physics__0x36CCB9BE67B970FD(IntPtr plugin, ulong p0, bool p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Physics__0x84DE3B5FB3E666F0(IntPtr plugin, ref ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Physics__0x9EBD751E5787BAF2(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Physics__0xB1B6216CA2E7B55E(IntPtr plugin, ulong p0, bool p1, bool p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Physics__0xB743F735C03D7810(IntPtr plugin, ulong p0, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Physics__0xBC0CE682D4D05650(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4, ulong p5, ulong p6, ulong p7, ulong p8, ulong p9, ulong p10, ulong p11, ulong p12, ulong p13);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Physics__0xCC6E963682533882(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Physics__0xDC57A637A20006ED(IntPtr plugin, ulong p0, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Physics_PinRopeVertex(IntPtr plugin, int rope, int vertex, float x, float y, float z);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Physics_RopeAreTexturesLoaded(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Physics_RopeConvertToSimple(IntPtr plugin, int rope);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Physics_RopeDrawShadowEnabled(IntPtr plugin, ref int rope, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Physics_RopeForceLength(IntPtr plugin, int rope, float length);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Physics_RopeLoadTextures(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Physics_RopeResetLength(IntPtr plugin, int rope, float length);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Physics_RopeSetUpdatePinverts(IntPtr plugin, int rope);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Physics_RopeUnloadTextures(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Physics_SetCgAtBoundcenter(IntPtr plugin, int rope);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Physics_SetCgoffset(IntPtr plugin, int rope, float x, float y, float z);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Physics_SetDamping(IntPtr plugin, int rope, int vertex, float value);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Physics_SetDisableBreaking(IntPtr plugin, int rope, bool enabled);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Physics_SetDisableFragDamage(IntPtr plugin, int @object, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Physics_StartRopeUnwindingFront(IntPtr plugin, int rope);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Physics_StartRopeWinding(IntPtr plugin, int rope);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Physics_StopRopeUnwindingFront(IntPtr plugin, int rope);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Physics_StopRopeWinding(IntPtr plugin, int rope);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Physics_UnpinRopeVertex(IntPtr plugin, int rope, int vertex);
}
