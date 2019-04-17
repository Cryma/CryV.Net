using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CryV.Net.Native
{
    internal static partial class CryVNative
    {
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity_ApplyForceToEntity(IntPtr plugin, int entity, int forceFlags, float x, float y, float z, float offX, float offY, float offZ, int boneIndex, bool isDirectionRel, bool ignoreUpVec, bool isForceRel, bool p12, bool p13);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity_ApplyForceToEntityCenterOfMass(IntPtr plugin, int entity, int forceType, float x, float y, float z, bool p5, bool isDirectionRel, bool isForceRel, bool p8);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity_AttachEntityToEntity(IntPtr plugin, int entity1, int entity2, int boneIndex, float xPos, float yPos, float zPos, float xRot, float yRot, float zRot, bool p9, bool useSoftPinning, bool collision, bool isPed, int vertexIndex, bool fixedRot);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity_AttachEntityToEntityPhysically(IntPtr plugin, int entity1, int entity2, int boneIndex1, int boneIndex2, float xPos1, float yPos1, float zPos1, float xPos2, float yPos2, float zPos2, float xRot, float yRot, float zRot, float breakForce, bool fixedRot, bool p15, bool collision, bool teleport, int p18);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Entity_ClearEntityLastDamageEntity(IntPtr plugin, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity_CreateForcedObject(IntPtr plugin, float x, float y, float z, ulong p3, ulong modelHash, bool p5);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity_CreateModelHide(IntPtr plugin, float x, float y, float z, float radius, ulong model, bool p5);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity_CreateModelHideExcludingScriptObjects(IntPtr plugin, float x, float y, float z, float radius, ulong model, bool p5);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity_CreateModelSwap(IntPtr plugin, float x, float y, float z, float radius, ulong originalModel, ulong newModel, bool p6);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity_DeleteEntity(IntPtr plugin, ref int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity_DetachEntity(IntPtr plugin, int entity, bool p1, bool collision);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Entity_DoesEntityBelongToThisScript(IntPtr plugin, int entity, bool p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Entity_DoesEntityExist(IntPtr plugin, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Entity_DoesEntityHaveDrawable(IntPtr plugin, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Entity_DoesEntityHavePhysics(IntPtr plugin, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Entity_FindAnimEventPhase(IntPtr plugin, IntPtr animDictionary, IntPtr animName, IntPtr p2, ref ulong p3, ref ulong p4);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity_ForceEntityAiAndAnimationUpdate(IntPtr plugin, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity_FreezeEntityPosition(IntPtr plugin, int entity, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Entity_GetAnimDuration(IntPtr plugin, IntPtr animDict, IntPtr animName);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Native_Entity_GetCollisionNormalOfLastHitForEntity(IntPtr plugin, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Entity_GetEntityAlpha(IntPtr plugin, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Entity_GetEntityAnimCurrentTime(IntPtr plugin, int entity, IntPtr animDict, IntPtr animName);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Entity_GetEntityAnimTotalTime(IntPtr plugin, int entity, IntPtr animDict, IntPtr animName);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Entity_GetEntityAttachedTo(IntPtr plugin, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Entity_GetEntityBoneIndexByName(IntPtr plugin, int entity, IntPtr boneName);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Entity_GetEntityCollisonDisabled(IntPtr plugin, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Native_Entity_GetEntityCoords(IntPtr plugin, int entity, bool alive);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Native_Entity_GetEntityForwardVector(IntPtr plugin, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Entity_GetEntityForwardX(IntPtr plugin, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Entity_GetEntityForwardY(IntPtr plugin, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Entity_GetEntityHeading(IntPtr plugin, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Entity_GetEntityHealth(IntPtr plugin, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Entity_GetEntityHeight(IntPtr plugin, int entity, float X, float Y, float Z, bool atTop, bool inWorldCoords);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Entity_GetEntityHeightAboveGround(IntPtr plugin, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Entity_GetEntityLodDist(IntPtr plugin, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Entity_GetEntityMaxHealth(IntPtr plugin, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Entity_GetEntityModel(IntPtr plugin, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Entity_GetEntityPhysicsHeading(IntPtr plugin, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Entity_GetEntityPitch(IntPtr plugin, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Entity_GetEntityPopulationType(IntPtr plugin, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity_GetEntityQuaternion(IntPtr plugin, int entity, ref float x, ref float y, ref float z, ref float w);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Entity_GetEntityRoll(IntPtr plugin, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Native_Entity_GetEntityRotation(IntPtr plugin, int entity, int rotationOrder);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Native_Entity_GetEntityRotationVelocity(IntPtr plugin, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Native_Entity_GetEntityScript(IntPtr plugin, int entity, ref int script);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Entity_GetEntitySpeed(IntPtr plugin, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Native_Entity_GetEntitySpeedVector(IntPtr plugin, int entity, bool relative);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Entity_GetEntitySubmergedLevel(IntPtr plugin, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Entity_GetEntityType(IntPtr plugin, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Entity_GetEntityUprightValue(IntPtr plugin, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Native_Entity_GetEntityVelocity(IntPtr plugin, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Entity_GetLastMaterialHitByEntity(IntPtr plugin, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Entity_GetNearestPlayerToEntity(IntPtr plugin, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Entity_GetNearestPlayerToEntityOnTeam(IntPtr plugin, int entity, int team);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Entity_GetObjectIndexFromEntityIndex(IntPtr plugin, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Native_Entity_GetOffsetFromEntityGivenWorldCoords(IntPtr plugin, int entity, float posX, float posY, float posZ);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Native_Entity_GetOffsetFromEntityInWorldCoords(IntPtr plugin, int entity, float offsetX, float offsetY, float offsetZ);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Entity_GetPedIndexFromEntityIndex(IntPtr plugin, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Entity_GetVehicleIndexFromEntityIndex(IntPtr plugin, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Native_Entity_GetWorldPositionOfEntityBone(IntPtr plugin, int entity, int boneIndex);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Entity_HasAnimEventFired(IntPtr plugin, int entity, ulong actionHash);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Entity_HasCollisionLoadedAroundEntity(IntPtr plugin, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Entity_HasEntityAnimFinished(IntPtr plugin, int entity, IntPtr animDict, IntPtr animName, int p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Entity_HasEntityBeenDamagedByAnyObject(IntPtr plugin, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Entity_HasEntityBeenDamagedByAnyPed(IntPtr plugin, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Entity_HasEntityBeenDamagedByAnyVehicle(IntPtr plugin, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Entity_HasEntityBeenDamagedByEntity(IntPtr plugin, int entity1, int entity2, bool p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Entity_HasEntityClearLosToEntity(IntPtr plugin, int entity1, int entity2, int traceType);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Entity_HasEntityClearLosToEntityInFront(IntPtr plugin, int entity1, int entity2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Entity_HasEntityCollidedWithAnything(IntPtr plugin, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Entity_IsAnEntity(IntPtr plugin, int handle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Entity_IsEntityAMissionEntity(IntPtr plugin, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Entity_IsEntityAnObject(IntPtr plugin, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Entity_IsEntityAPed(IntPtr plugin, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Entity_IsEntityAtCoord(IntPtr plugin, int entity, float xPos, float yPos, float zPos, float xSize, float ySize, float zSize, bool p7, bool p8, int p9);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Entity_IsEntityAtEntity(IntPtr plugin, int entity1, int entity2, float xSize, float ySize, float zSize, bool p5, bool p6, int p7);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Entity_IsEntityAttached(IntPtr plugin, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Entity_IsEntityAttachedToAnyObject(IntPtr plugin, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Entity_IsEntityAttachedToAnyPed(IntPtr plugin, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Entity_IsEntityAttachedToAnyVehicle(IntPtr plugin, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Entity_IsEntityAttachedToEntity(IntPtr plugin, int from, int to);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Entity_IsEntityAVehicle(IntPtr plugin, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Entity_IsEntityDead(IntPtr plugin, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Entity_IsEntityInAir(IntPtr plugin, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Entity_IsEntityInAngledArea(IntPtr plugin, int entity, float originX, float originY, float originZ, float edgeX, float edgeY, float edgeZ, float angle, bool p8, bool p9, ulong p10);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Entity_IsEntityInArea(IntPtr plugin, int entity, float x1, float y1, float z1, float x2, float y2, float z2, bool p7, bool p8, ulong p9);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Entity_IsEntityInWater(IntPtr plugin, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Entity_IsEntityInZone(IntPtr plugin, int entity, IntPtr zone);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Entity_IsEntityOccluded(IntPtr plugin, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Entity_IsEntityOnScreen(IntPtr plugin, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Entity_IsEntityPlayingAnim(IntPtr plugin, int entity, IntPtr animDict, IntPtr animName, int taskFlag);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Entity_IsEntityStatic(IntPtr plugin, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Entity_IsEntityTouchingEntity(IntPtr plugin, int entity, int targetEntity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Entity_IsEntityTouchingModel(IntPtr plugin, int entity, ulong modelHash);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Entity_IsEntityUpright(IntPtr plugin, int entity, float angle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Entity_IsEntityUpsidedown(IntPtr plugin, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Entity_IsEntityVisible(IntPtr plugin, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Entity_IsEntityVisibleToScript(IntPtr plugin, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Entity_IsEntityWaitingForWorldCollision(IntPtr plugin, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity__0x1A092BB0C3808B96(IntPtr plugin, int entity, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity__0x2C2E3DC128F44309(IntPtr plugin, int entity, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity__0x352E2B5CF420BF3B(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity__0x36F32DE87082343E(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Native_Entity__0x46F8696933A63C9B(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity__0x490861B88F4FD846(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity__0x5C3B791D580E0BC2(IntPtr plugin, int entity, float p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity__0x5C48B75732C8456C(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4, ulong p5);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity__0x694E00132F2823ED(IntPtr plugin, int entity, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity__0x6CE177D014502E8A(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity__0x78E8E3A640178255(IntPtr plugin, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity__0xA80AE305E0A3044F(IntPtr plugin, int entity, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity__0xB17BC6453F6CF5AC(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Entity__0xB328DCC3A3AA401B(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity__0xC34BC448DA29F5E9(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Native_Entity__0xCE6294A232D03786(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity__0xCEA7C8E1B48FF68C(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Entity__0xD95CC5D2AB15A09F(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity__0xDC6F8601FAF2E893(IntPtr plugin, int entity, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity__0xE12ABE5E3A389A6C(IntPtr plugin, int entity, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity__0xFD1695C5D3B05439(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4, ulong p5);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Entity_PlayEntityAnim(IntPtr plugin, int entity, IntPtr animName, IntPtr animDict, float p3, bool loop, bool stayInAnim, bool p6, float delta, ulong bitset);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Entity_PlaySynchronizedEntityAnim(IntPtr plugin, int entity, int syncedScene, IntPtr animation, IntPtr propName, float p4, float p5, ulong p6, float p7);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Entity_PlaySynchronizedMapEntityAnim(IntPtr plugin, float p0, float p1, float p2, float p3, ulong p4, ulong p5, ref ulong p6, ref ulong p7, float p8, float p9, ulong p10, float p11);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity_ProcessEntityAttachments(IntPtr plugin, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity_RemoveForcedObject(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity_RemoveModelHide(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4, ulong p5);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity_RemoveModelSwap(IntPtr plugin, float x, float y, float z, float radius, ulong originalModel, ulong newModel, bool p6);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Entity_ResetEntityAlpha(IntPtr plugin, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity_SetEntityAlpha(IntPtr plugin, int entity, int alphaLevel, int skin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity_SetEntityAlwaysPrerender(IntPtr plugin, int entity, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity_SetEntityAnimCurrentTime(IntPtr plugin, int entity, IntPtr animDictionary, IntPtr animName, float time);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity_SetEntityAnimSpeed(IntPtr plugin, int entity, IntPtr animDictionary, IntPtr animName, float speedMultiplier);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity_SetEntityAsMissionEntity(IntPtr plugin, int entity, bool p1, bool p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity_SetEntityAsNoLongerNeeded(IntPtr plugin, ref int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity_SetEntityCanBeDamaged(IntPtr plugin, int entity, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity_SetEntityCanBeDamagedByRelationshipGroup(IntPtr plugin, int entity, bool bCanBeDamaged, int relGroup);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity_SetEntityCanBeTargetedWithoutLos(IntPtr plugin, int entity, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity_SetEntityCollision(IntPtr plugin, int entity, bool toggle, bool keepPhysics);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity_SetEntityCollision2(IntPtr plugin, int entity, bool p1, bool p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity_SetEntityCoords(IntPtr plugin, int entity, float xPos, float yPos, float zPos, bool xAxis, bool yAxis, bool zAxis, bool clearArea);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity_SetEntityCoordsNoOffset(IntPtr plugin, int entity, float xPos, float yPos, float zPos, bool xAxis, bool yAxis, bool zAxis);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity_SetEntityCoords2(IntPtr plugin, int entity, float xPos, float yPos, float zPos, bool xAxis, bool yAxis, bool zAxis, bool clearArea);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity_SetEntityDynamic(IntPtr plugin, int entity, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity_SetEntityHasGravity(IntPtr plugin, int entity, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity_SetEntityHeading(IntPtr plugin, int entity, float heading);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity_SetEntityHealth(IntPtr plugin, int entity, int health);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity_SetEntityInvincible(IntPtr plugin, int entity, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity_SetEntityIsTargetPriority(IntPtr plugin, int entity, bool p1, float p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity_SetEntityLights(IntPtr plugin, int entity, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity_SetEntityLoadCollisionFlag(IntPtr plugin, int entity, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity_SetEntityLodDist(IntPtr plugin, int entity, int value);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity_SetEntityMaxHealth(IntPtr plugin, int entity, int value);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity_SetEntityMaxSpeed(IntPtr plugin, int entity, float speed);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity_SetEntityMotionBlur(IntPtr plugin, int entity, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity_SetEntityNoCollisionEntity(IntPtr plugin, int entity1, int entity2, bool unknown);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity_SetEntityOnlyDamagedByPlayer(IntPtr plugin, int entity, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity_SetEntityOnlyDamagedByRelationshipGroup(IntPtr plugin, int entity, bool p1, ulong relationshipHash);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity_SetEntityProofs(IntPtr plugin, int entity, bool bulletProof, bool fireProof, bool explosionProof, bool collisionProof, bool meleeProof, bool p6, bool p7, bool p8);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity_SetEntityQuaternion(IntPtr plugin, int entity, float x, float y, float z, float w);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity_SetEntityRecordsCollisions(IntPtr plugin, int entity, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity_SetEntityRenderScorched(IntPtr plugin, int entity, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity_SetEntityRotation(IntPtr plugin, int entity, float pitch, float roll, float yaw, int rotationOrder, bool p5);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity_SetEntitySomething(IntPtr plugin, int entity, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity_SetEntityTrafficlightOverride(IntPtr plugin, int entity, int state);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity_SetEntityVelocity(IntPtr plugin, int entity, float x, float y, float z);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity_SetEntityVisible(IntPtr plugin, int entity, bool toggle, bool unk);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity_SetObjectAsNoLongerNeeded(IntPtr plugin, ref int @object);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity_SetPedAsNoLongerNeeded(IntPtr plugin, ref int ped);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Entity_SetVehicleAsNoLongerNeeded(IntPtr plugin, ref int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Entity_StopEntityAnim(IntPtr plugin, int entity, IntPtr animation, IntPtr animGroup, float p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Entity_StopSynchronizedEntityAnim(IntPtr plugin, int entity, float p1, bool p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Entity_StopSynchronizedMapEntityAnim(IntPtr plugin, float p0, float p1, float p2, float p3, ulong p4, float p5);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Entity_WouldEntityBeOccluded(IntPtr plugin, ulong entityModelHash, float x, float y, float z, bool p4);
    }
}
