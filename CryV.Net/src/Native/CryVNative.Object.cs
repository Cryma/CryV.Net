using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CryV.Net.Native;

internal static partial class CryVNative
{
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object_AddDoorToSystem(IntPtr plugin, ulong doorHash, ulong modelHash, float x, float y, float z, bool p5, bool p6, bool p7);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object_AttachPortablePickupToPed(IntPtr plugin, int ped, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Object_CreateAmbientPickup(IntPtr plugin, ulong pickupHash, float posX, float posY, float posZ, int p4, int value, ulong modelHash, bool returnHandle, bool p8);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object_CreateMoneyPickups(IntPtr plugin, float x, float y, float z, int value, int amount, ulong model);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Object_CreateObject(IntPtr plugin, int modelHash, float x, float y, float z, bool isNetwork, bool thisScriptCheck, bool dynamic);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Object_CreateObjectNoOffset(IntPtr plugin, ulong modelHash, float x, float y, float z, bool isNetwork, bool thisScriptCheck, bool dynamic);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Object_CreatePickup(IntPtr plugin, ulong pickupHash, float posX, float posY, float posZ, int p4, int value, bool p6, ulong modelHash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Object_CreatePickupRotate(IntPtr plugin, ulong pickupHash, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, int flag, int amount, ulong p9, bool p10, ulong modelHash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Object_CreatePortablePickup(IntPtr plugin, ulong pickupHash, float x, float y, float z, bool placeOnGround, ulong modelHash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Object_CreatePortablePickup2(IntPtr plugin, ulong pickupHash, float x, float y, float z, bool placeOnGround, ulong modelHash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object_DeleteObject(IntPtr plugin, ref int @object);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object_DetachPortablePickupFromPed(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Object_DoesDesObjectExist(IntPtr plugin, int handle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Object_DoesDoorExist(IntPtr plugin, ulong doorHash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Object_DoesObjectOfTypeExistAtCoords(IntPtr plugin, float x, float y, float z, float radius, ulong hash, bool p5);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Object_DoesPickupExist(IntPtr plugin, int pickup);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Object_DoesPickupObjectExist(IntPtr plugin, int pickupObject);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object_DoorControl(IntPtr plugin, ulong doorHash, float x, float y, float z, bool locked, float xRotMult, float yRotMult, float zRotMult);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Object_GetClosestObjectOfType(IntPtr plugin, float x, float y, float z, float radius, ulong modelHash, bool isMission, bool p6, bool p7);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Object_GetDesObject(IntPtr plugin, float x, float y, float z, float rotation, IntPtr name);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern float Native_Object_GetDesObjectAnimProgress(IntPtr plugin, int desObjectHandle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Object_GetDesObjectState(IntPtr plugin, int handle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern float Native_Object_GetObjectFragmentDamageHealth(IntPtr plugin, ulong p0, bool p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern IntPtr Native_Object_GetObjectOffsetFromCoords(IntPtr plugin, float xPos, float yPos, float zPos, float heading, float xOffset, float yOffset, float zOffset);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern IntPtr Native_Object_GetPickupCoords(IntPtr plugin, int pickup);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Object_GetPickupHash(IntPtr plugin, int pickupHash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Object_GetPickupObject(IntPtr plugin, int pickup);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern IntPtr Native_Object_GetSafePickupCoords(IntPtr plugin, float x, float y, float z, ulong p3, ulong p4);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object_GetStateOfClosestDoorOfType(IntPtr plugin, ulong type, float x, float y, float z, ref bool locked, ref float heading);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Object_GetWeaponHashFromPickup(IntPtr plugin, int pickupHash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Object_HasClosestObjectOfTypeBeenBroken(IntPtr plugin, float p0, float p1, float p2, float p3, ulong modelHash, ulong p5);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Object_HasObjectBeenBroken(IntPtr plugin, int @object);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Object_HasPickupBeenCollected(IntPtr plugin, int pickup);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object_HighlightPlacementCoords(IntPtr plugin, float x, float y, float z, int colorIndex);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Object_IsAnyObjectNearPoint(IntPtr plugin, float x, float y, float z, float range, bool p4);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Object_IsDoorClosed(IntPtr plugin, ulong door);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Object_IsGarageEmpty(IntPtr plugin, ulong garage, bool p1, int p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Object_IsObjectNearPoint(IntPtr plugin, ulong objectHash, float x, float y, float z, float range);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Object_IsObjectVisible(IntPtr plugin, int @object);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Object_IsPickupWithinRadius(IntPtr plugin, ulong pickupHash, float x, float y, float z, float radius);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Object_IsPointInAngledArea(IntPtr plugin, float p0, float p1, float p2, float p3, float p4, float p5, float p6, float p7, float p8, float p9, bool p10, bool p11);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object_MarkObjectForDeletion(IntPtr plugin, int @object);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Object__0x024A60DEB0EA69F0(IntPtr plugin, ulong p0, int player, float p2, int p3);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Object__0x0378C08504160D0D(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object__0x03C27E13B42A0E82(IntPtr plugin, ulong doorHash, float p1, bool p2, bool p3);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object__0x0596843B34B95CE5(IntPtr plugin, ulong p0, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object__0x0BF3B3BD47D79C08(IntPtr plugin, ulong hash, int p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Object__0x11D1E53A726891FE(IntPtr plugin, int @object);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Object__0x160AA1B32F6139B8(IntPtr plugin, ulong doorHash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Object__0x1761DC5D8471CBAA(IntPtr plugin, ulong p0, int player, int p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object__0x190428512B240692(IntPtr plugin, ulong p0, bool p1, bool p2, bool p3, bool p4);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object__0x1C1B69FAE509BA97(IntPtr plugin, ulong p0, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object__0x1E3F1B1B891A2AAA(IntPtr plugin, ulong p0, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object__0x318516E02DE3ECE2(IntPtr plugin, float p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object__0x31F924B53EADDF65(IntPtr plugin, bool p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Object__0x372EF6699146A1E4(IntPtr plugin, ulong p0, int entity, float p2, int p3);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object__0x394CD08E31313C28(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object__0x39A5FB7EAF150840(IntPtr plugin, ulong p0, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object__0x3ED2B83AB2E82799(IntPtr plugin, ulong p0, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Object__0x46494A2475701343(IntPtr plugin, float p0, float p1, float p2, float p3, ulong modelHash, bool p5);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object__0x46F3ADD1E2D5BAF2(IntPtr plugin, ulong p0, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object__0x4A39DB43E47CF3AA(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Object__0x4BC2854478F3A749(IntPtr plugin, ulong doorHash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object__0x4D89D607CB3DD1D2(IntPtr plugin, int @object, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Object__0x589F80B325CC82C5(IntPtr plugin, float p0, float p1, float p2, ulong p3, ref ulong p4);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object__0x616093EC6B139DD9(IntPtr plugin, int player, ulong pickupHash, bool p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object__0x62454A641B41F3C5(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object__0x641F272B52E2F0F8(IntPtr plugin, ulong p0, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern float Native_Object__0x65499865FCA6E5EC(IntPtr plugin, ulong doorHash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object__0x66A49D021870FE88(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Object__0x673ED815D6E323B7(IntPtr plugin, ulong p0, bool p1, bool p2, bool p3, ulong p4);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object__0x701FDA1E82076BA4(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object__0x758A5C1B3B1E1990(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object__0x762DB2D380B48D04(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object__0x78857FC65CADB909(IntPtr plugin, bool p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object__0x826D1EE4D1CAFC78(IntPtr plugin, ulong p0, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object__0x858EC9FD25DE04AA(IntPtr plugin, ulong p0, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Object__0x85B6C850546FDDE2(IntPtr plugin, ulong p0, bool p1, bool p2, bool p3, ulong p4);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object__0x867458251D47CCB2(IntPtr plugin, ulong p0, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object__0x8881C98A31117998(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object__0x88EAEC617CD26926(IntPtr plugin, ulong p0, bool p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object__0x8CAAB2BD3EA58BD4(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object__0x92AEFB5F6E294023(IntPtr plugin, int @object, bool p1, bool p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object__0x96EE0EBA0163DF80(IntPtr plugin, ulong p0, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object__0x9BA001CB45CBF627(IntPtr plugin, ulong doorHash, float heading, bool p2, bool p3);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object__0xA08FE5E49BDC39DD(IntPtr plugin, ulong p0, float p1, bool p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object__0xA2C1F5E92AFE49ED(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object__0xA85A21582451E951(IntPtr plugin, ulong doorHash, bool p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object__0xA90E7227A9303FA9(IntPtr plugin, ulong p0, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object__0xB2D0BDE54F0E8E5A(IntPtr plugin, int @object, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Object__0xB3ECA65C7317F174(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object__0xBCE595371A5FBAAF(IntPtr plugin, ulong p0, bool p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object__0xC485E07E4F0B7958(IntPtr plugin, ulong doorHash, bool p1, bool p2, bool p3);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object__0xC6033D32241F6FB5(IntPtr plugin, ulong p0, bool p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object__0xC7F29CA00F46350E(IntPtr plugin, bool p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Object__0xD76EEEF746057FD6(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object__0xD9B71952F78A2640(IntPtr plugin, ulong doorHash, bool p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object__0xDA05194260CDCDF9(IntPtr plugin, ulong p0, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Object__0xDB41D07A45A6D4B7(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object__0xDF6CA0330F2E737B(IntPtr plugin, ulong p0, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Object__0xDF97CDD4FC08FD34(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object__0xE7E4C198B0185900(IntPtr plugin, int p0, ulong p1, bool p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Object__0xE84EB93729C5F36A(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object__0xEB6F1A9B5510A5D2(IntPtr plugin, ulong p0, bool p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Object__0xF0EED5A6BC7B237A(IntPtr plugin, ulong p0, int entity, int p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Object__0xF12E33034D887F66(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4, ulong p5);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object__0xF2E1A7133DD356A6(IntPtr plugin, ulong hash, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object__0xF92099527DB8E2A7(IntPtr plugin, ulong p0, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object__0xF9C1681347C8BD15(IntPtr plugin, int @object);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Object_PlaceObjectOnGroundProperly(IntPtr plugin, int @object);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object_RemoveAllPickupsOfType(IntPtr plugin, ulong pickupHash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object_RemoveDoorFromSystem(IntPtr plugin, ulong doorHash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object_RemovePickup(IntPtr plugin, int pickup);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object_SetActivateObjectPhysicsAsSoonAsItIsUnfrozen(IntPtr plugin, int @object, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object_SetDesObjectState(IntPtr plugin, int handle, int state);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object_SetDoorAccelerationLimit(IntPtr plugin, ulong doorHash, int limit, bool p2, bool p3);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object_SetDoorAjarAngle(IntPtr plugin, ulong doorHash, float ajar, bool p2, bool p3);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object_SetForceObjectThisFrame(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object_SetObjectColour(IntPtr plugin, int entity, ulong p1, int R, int G, int B);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object_SetObjectPhysicsParams(IntPtr plugin, int @object, float weight, float p2, float p3, float p4, float p5, float gravity, float p7, float p8, float p9, float p10, float buoyancy);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object_SetObjectSomething(IntPtr plugin, int @object, bool p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Object_SetObjectTargettable(IntPtr plugin, int @object, bool targettable);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object_SetObjectTextureVariant(IntPtr plugin, int @object, int paintIndex);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object_SetPickupRegenerationTime(IntPtr plugin, int pickup, int duration);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object_SetStateOfClosestDoorOfType(IntPtr plugin, ulong type, float x, float y, float z, bool locked, float heading, bool p6);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object_SetTeamPickupObject(IntPtr plugin, int @object, ulong p1, bool p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Object_SlideObject(IntPtr plugin, int @object, float toX, float toY, float toZ, float speedX, float speedY, float speedZ, bool collision);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Object_TrackObjectVisibility(IntPtr plugin, ulong p0);
}
