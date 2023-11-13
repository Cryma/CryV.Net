using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CryV.Net.Native;

internal static partial class CryVNative
{
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_AddArmourToPed(IntPtr plugin, int ped, int amount);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Ped_AddRelationshipGroup(IntPtr plugin, IntPtr name, ref ulong groupHash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Ped_AddScenarioBlockingArea(IntPtr plugin, float x1, float y1, float z1, float x2, float y2, float z2, bool p6, bool p7, bool p8, bool p9);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_ApplyDamageToPed(IntPtr plugin, int ped, int damageAmount, bool armorFirst);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_ApplyPedBlood(IntPtr plugin, int ped, int boneIndex, float xRot, float yRot, float zRot, IntPtr woundType);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_ApplyPedBloodByZone(IntPtr plugin, int ped, ulong p1, float p2, float p3, ref ulong p4);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_ApplyPedBloodDamageByZone(IntPtr plugin, int ped, ulong p1, float p2, float p3, ulong p4);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_ApplyPedBloodSpecific(IntPtr plugin, int ped, ulong p1, float p2, float p3, float p4, float p5, ulong p6, float p7, ref ulong p8);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_ApplyPedDamageDecal(IntPtr plugin, int ped, int p1, float p2, float p3, float p4, float p5, float p6, int p7, bool p8, IntPtr p9);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_ApplyPedDamagePack(IntPtr plugin, int ped, IntPtr damagePack, float damage, float mult);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_AttachSynchronizedSceneToEntity(IntPtr plugin, int sceneID, int entity, int boneIndex);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_CanCreateRandomBikeRider(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_CanCreateRandomCops(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_CanCreateRandomDriver(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_CanCreateRandomPed(IntPtr plugin, bool unk);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_CanKnockPedOffVehicle(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_CanPedInCombatSeeTarget(IntPtr plugin, int ped, int target);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_CanPedRagdoll(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_CanPedSeePed(IntPtr plugin, int ped1, int ped2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_ClearAllPedProps(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_ClearFacialIdleAnimOverride(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_ClearPedAlternateMovementAnim(IntPtr plugin, int ped, int stance, float p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_ClearPedAlternateWalkAnim(IntPtr plugin, int ped, float p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_ClearPedBloodDamage(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_ClearPedBloodDamageByZone(IntPtr plugin, int ped, int p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_ClearPedDamageDecalByZone(IntPtr plugin, int ped, int p1, IntPtr p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_ClearPedDecorations(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_ClearPedDriveByClipsetOverride(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_ClearPedFacialDecorations(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_ClearPedLastDamageBone(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_ClearPedNonCreationArea(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_ClearPedProp(IntPtr plugin, int ped, int propId);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_ClearPedScubaGearVariation(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_ClearPedWetness(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_ClearRelationshipBetweenGroups(IntPtr plugin, int relationship, ulong group1, ulong group2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Ped_ClonePed(IntPtr plugin, int ped, float heading, bool isNetwork, bool thisScriptCheck);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_ClonePedToTarget(IntPtr plugin, int ped, int targetPed);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Ped_CreateGroup(IntPtr plugin, int unused);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_CreateNmMessage(IntPtr plugin, bool startImmediately, int messageId);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Ped_CreatePed(IntPtr plugin, int pedType, ulong modelHash, float x, float y, float z, float heading, bool isNetwork, bool thisScriptCheck);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Ped_CreatePedInsideVehicle(IntPtr plugin, int vehicle, int pedType, ulong modelHash, int seat, bool isNetwork, bool thisScriptCheck);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Ped_CreateRandomPed(IntPtr plugin, float posX, float posY, float posZ);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Ped_CreateRandomPedAsDriver(IntPtr plugin, int vehicle, bool returnHandle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Ped_CreateSynchronizedScene(IntPtr plugin, float x, float y, float z, float roll, float pitch, float yaw, int p6);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Ped_CreateSynchronizedScene2(IntPtr plugin, float x, float y, float z, float radius, ulong @object);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_DeletePed(IntPtr plugin, ref int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_DetachSynchronizedScene(IntPtr plugin, int sceneID);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_DisposeSynchronizedScene(IntPtr plugin, int scene);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_DoesGroupExist(IntPtr plugin, int groupId);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_ExplodePedHead(IntPtr plugin, int ped, ulong weaponHash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_ForcePedMotionState(IntPtr plugin, int ped, ulong motionStateHash, bool p2, bool p3, bool p4);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_ForcePedToOpenParachute(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_FreezePedCameraRotation(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern IntPtr Native_Ped_GetAnimInitialOffsetPosition(IntPtr plugin, IntPtr animDict, IntPtr animName, float x, float y, float z, float xRot, float yRot, float zRot, float p8, int p9);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern IntPtr Native_Ped_GetAnimInitialOffsetRotation(IntPtr plugin, IntPtr animDict, IntPtr animName, float x, float y, float z, float xRot, float yRot, float zRot, float p8, int p9);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_GetClosestPed(IntPtr plugin, float x, float y, float z, float radius, bool p4, bool p5, ref int outPed, bool p7, bool p8, int pedType);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern float Native_Ped_GetCombatFloat(IntPtr plugin, int ped, int p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern IntPtr Native_Ped_GetDeadPedPickupCoords(IntPtr plugin, int ped, float p1, float p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Ped_GetFirstParentIdForPedType(IntPtr plugin, int type);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_GetGroupSize(IntPtr plugin, int groupID, ref ulong unknown, ref int sizeInMembers);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_GetHairRgbColor(IntPtr plugin, int hairColorIndex, ref int outR, ref int outG, ref int outB);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Ped_GetJackTarget(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_GetMakeupRgbColor(IntPtr plugin, int makeupColorIndex, ref int outR, ref int outG, ref int outB);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Ped_GetMeleeTargetForPed(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Ped_GetMount(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Ped_GetNumberOfPedDrawableVariations(IntPtr plugin, int ped, int componentId);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Ped_GetNumberOfPedPropDrawableVariations(IntPtr plugin, int ped, int propId);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Ped_GetNumberOfPedPropTextureVariations(IntPtr plugin, int ped, int propId, int drawableId);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Ped_GetNumberOfPedTextureVariations(IntPtr plugin, int ped, int componentId, int drawableId);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Ped_GetNumHairColors(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Ped_GetNumHeadOverlayValues(IntPtr plugin, int overlayID);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Ped_GetNumMakeupColors(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Ped_GetNumParentPedsOfType(IntPtr plugin, int type);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Ped_GetPedAccuracy(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Ped_GetPedAlertness(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Ped_GetPedArmour(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Ped_GetPedAsGroupLeader(IntPtr plugin, int groupID);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Ped_GetPedAsGroupMember(IntPtr plugin, int groupID, int memberNumber);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern IntPtr Native_Ped_GetPedBoneCoords(IntPtr plugin, int ped, int boneId, float offsetX, float offsetY, float offsetZ);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Ped_GetPedBoneIndex(IntPtr plugin, int ped, int boneId);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Ped_GetPedCauseOfDeath(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Ped_GetPedCombatMovement(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Ped_GetPedCombatRange(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_GetPedConfigFlag(IntPtr plugin, int ped, int flagId, bool p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Ped_GetPedDecorationsState(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern IntPtr Native_Ped_GetPedDefensiveAreaPosition(IntPtr plugin, int ped, bool p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Ped_GetPedDrawableVariation(IntPtr plugin, int ped, int componentId);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern float Native_Ped_GetPedEnveffScale(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern IntPtr Native_Ped_GetPedExtractedDisplacement(IntPtr plugin, int ped, bool worldSpace);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_GetPedFloodInvincibility(IntPtr plugin, int ped, bool p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Ped_GetPedGroupIndex(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_GetPedHeadBlendData(IntPtr plugin, int ped, ref ulong headBlendData);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Ped_GetPedHeadOverlayValue(IntPtr plugin, int ped, int overlayID);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern IntPtr Native_Ped_GetPedheadshotTxdString(IntPtr plugin, int handle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern float Native_Ped_GetPedIlluminatedClothingGlowIntensity(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_GetPedLastDamageBone(IntPtr plugin, int ped, ref int outBone);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Ped_GetPedMaxHealth(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Ped_GetPedMoney(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Ped_GetPedNearbyPeds(IntPtr plugin, int ped, ref int sizeAndPeds, int ignore);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Ped_GetPedNearbyVehicles(IntPtr plugin, int ped, ref int sizeAndVehs);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Ped_GetPedPaletteVariation(IntPtr plugin, int ped, int componentId);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Ped_GetPedParachuteLandingType(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Ped_GetPedParachuteState(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_GetPedParachuteTintIndex(IntPtr plugin, int ped, ref int outTintIndex);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Ped_GetPedPropIndex(IntPtr plugin, int ped, int componentId);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Ped_GetPedPropTextureIndex(IntPtr plugin, int ped, int componentId);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Ped_GetPedRagdollBoneIndex(IntPtr plugin, int ped, int bone);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Ped_GetPedRelationshipGroupDefaultHash(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Ped_GetPedRelationshipGroupHash(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_GetPedResetFlag(IntPtr plugin, int ped, int flagId);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Ped_GetPedsJacker(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Ped_GetPedSourceOfDeath(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_GetPedStealthMovement(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Ped_GetPedTextureVariation(IntPtr plugin, int ped, int componentId);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Ped_GetPedType(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Ped_GetPlayerPedIsFollowing(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Ped_GetRandomPedAtCoord(IntPtr plugin, float x, float y, float z, float xRadius, float yRadius, float zRadius, int pedType);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Ped_GetRelationshipBetweenGroups(IntPtr plugin, ulong group1, ulong group2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Ped_GetRelationshipBetweenPeds(IntPtr plugin, int ped1, int ped2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Ped_GetSeatPedIsTryingToEnter(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern float Native_Ped_GetSynchronizedScenePhase(IntPtr plugin, int sceneID);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern float Native_Ped_GetSynchronizedSceneRate(IntPtr plugin, int sceneID);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Ped_GetTattooZone(IntPtr plugin, ulong collection, ulong overlay);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Ped_GetVehiclePedIsIn(IntPtr plugin, int ped, bool lastVehicle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Ped_GetVehiclePedIsTryingToEnter(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Ped_GetVehiclePedIsUsing(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_GivePedHelmet(IntPtr plugin, int ped, bool cannotRemove, int helmetFlag, int textureIndex);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_GivePedNmMessage(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_HasActionModeAssetLoaded(IntPtr plugin, IntPtr asset);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_HasPedHeadBlendFinished(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_HasPedReceivedEvent(IntPtr plugin, int ped, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_HasStealthModeAssetLoaded(IntPtr plugin, IntPtr asset);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_HidePedBloodDamageByZone(IntPtr plugin, int ped, ulong p1, bool p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsAnyPedNearPoint(IntPtr plugin, float x, float y, float z, float radius);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsAnyPedShootingInArea(IntPtr plugin, float x1, float y1, float z1, float x2, float y2, float z2, bool p6, bool p7);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsConversationPedDead(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsCopPedInArea3D(IntPtr plugin, float x1, float y1, float z1, float x2, float y2, float z2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedAimingFromCover(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedAPlayer(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedBeingJacked(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedBeingStealthKilled(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedBeingStunned(IntPtr plugin, int ped, int p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedBlushColorValid(IntPtr plugin, int colorID);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedClimbing(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedComponentVariationValid(IntPtr plugin, int ped, int componentId, int drawableId, int textureId);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedDeadOrDying(IntPtr plugin, int ped, bool p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedDiving(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedDoingDriveby(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedDucking(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedEvasiveDiving(IntPtr plugin, int ped, ref int evadingEntity);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedFacingPed(IntPtr plugin, int ped, int otherPed, float angle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedFalling(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedFatallyInjured(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedFleeing(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedGettingIntoAVehicle(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedGoingIntoCover(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedGroupMember(IntPtr plugin, int ped, int groupId);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedHairColorValid(IntPtr plugin, int colorID);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedHangingOnToVehicle(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedheadshotReady(IntPtr plugin, int handle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedheadshotValid(IntPtr plugin, int handle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedHeadtrackingEntity(IntPtr plugin, int ped, int entity);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedHeadtrackingPed(IntPtr plugin, int ped1, int ped2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedHuman(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedHurt(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedInAnyBoat(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedInAnyHeli(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedInAnyPlane(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedInAnyPoliceVehicle(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedInAnySub(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedInAnyTaxi(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedInAnyTrain(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedInAnyVehicle(IntPtr plugin, int ped, bool atGetIn);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedInCombat(IntPtr plugin, int ped, int target);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedInCover(IntPtr plugin, int ped, bool exceptUseWeapon);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedInCoverFacingLeft(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedInFlyingVehicle(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedInGroup(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedInjured(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedInMeleeCombat(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedInModel(IntPtr plugin, int ped, ulong modelHash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedInParachuteFreeFall(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedInVehicle(IntPtr plugin, int ped, int vehicle, bool atGetIn);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedJacking(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedJumping(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedJumpingOutOfVehicle(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedLipstickColorValid(IntPtr plugin, int colorID);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedMale(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedModel(IntPtr plugin, int ped, ulong modelHash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedOnAnyBike(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedOnFoot(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedOnMount(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedOnSpecificVehicle(IntPtr plugin, int ped, int vehicle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedOnVehicle(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedPerformingStealthKill(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedPlantingBomb(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedProne(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedPropValid(IntPtr plugin, int ped, int componentId, int drawableId, int TextureId);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedRagdoll(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedReloading(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedRespondingToEvent(IntPtr plugin, int ped, ulong @event);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedRunningMobilePhoneTask(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedRunningRagdollTask(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedShooting(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedShootingInArea(IntPtr plugin, int ped, float x1, float y1, float z1, float x2, float y2, float z2, bool p7, bool p8);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedSittingInAnyVehicle(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedSittingInVehicle(IntPtr plugin, int ped, int vehicle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedStandingInCover(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedStopped(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedSwimming(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedSwimmingUnderWater(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedTracked(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedTryingToEnterALockedVehicle(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedUsingActionMode(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedUsingAnyScenario(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedUsingScenario(IntPtr plugin, int ped, IntPtr scenario);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedVaulting(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsPedWearingHelmet(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsScriptedScenarioPedUsingConditionalAnim(IntPtr plugin, int ped, IntPtr animDict, IntPtr anim);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsSynchronizedSceneLooped(IntPtr plugin, int sceneID);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsSynchronizedSceneRunning(IntPtr plugin, int sceneId);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_IsTrackedPedVisible(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_KnockOffPedProp(IntPtr plugin, int ped, bool p1, bool p2, bool p3, bool p4);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_KnockPedOffVehicle(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped__0x03EA03AF85A85CB7(IntPtr plugin, int ped, bool p1, bool p2, bool p3, bool p4, bool p5, bool p6, bool p7, ulong p8);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped__0x06087579E7AA85A9(IntPtr plugin, ulong p0, ulong p1, float p2, float p3, float p4, float p5);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0x061CB768363D6424(IntPtr plugin, ulong p0, bool p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0x0B3E35AC043707D9(IntPtr plugin, ulong p0, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0x0F62619393661D6E(IntPtr plugin, ulong p0, ulong p1, ulong p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0x110F526AB784111F(IntPtr plugin, int ped, float p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0x1216E0BFA72CC703(IntPtr plugin, ulong p0, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0x1280804F7CFD2D6C(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0x129466ED55140F8D(IntPtr plugin, int ped, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped__0x14590DDBEDB1EC85(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0x148B08C2D2ACB884(IntPtr plugin, ulong p0, ulong p1, ulong p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0x1A330D297AAC6BC1(IntPtr plugin, int ped, int p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Ped__0x1E77FA7A62EE6C4C(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Ped__0x1E98817B311AE98A(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0x2016C603D6B8987C(IntPtr plugin, ulong p0, bool p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0x2208438012482A1A(IntPtr plugin, int ped, bool p1, bool p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Ped__0x25361A96E0F7E419(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped__0x26AF0E8E30BD2A2C(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0x2735233A786B1BEF(IntPtr plugin, int ped, float p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0x280C7E3AC7F56E90(IntPtr plugin, ulong p0, ref ulong p1, ref ulong p2, ref ulong p3);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0x288DF530C92DAD6F(IntPtr plugin, ulong p0, float p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0x2B5AA717A181FB4C(IntPtr plugin, ulong p0, bool p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0x2B694AFCF64E6994(IntPtr plugin, int ped, bool p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0x2DF9038C90AD5264(IntPtr plugin, float p0, float p1, float p2, float p3, float p4, int interiorFlags, float scale, int duration);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Ped__0x2DFC81C9B9608549(IntPtr plugin, ulong p0, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0x2F074C904D85129E(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4, ulong p5, ulong p6);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0x2F3C3D9F50681DE4(IntPtr plugin, ulong p0, bool p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Ped__0x336B3D200AB007CB(IntPtr plugin, ulong p0, float p1, float p2, float p3, float p4);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Ped__0x36B77BB84687C318(IntPtr plugin, int ped, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0x36C6984C3ED0C911(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Ped__0x3795688A307E1EB6(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Ped__0x39D55A620FCB6A3A(IntPtr plugin, int ped, int slot, int drawableId, int textureId);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Ped__0x3C67506996001F5E(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped__0x3E802F11FBE27674(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0x3E9679C1DFCF422C(IntPtr plugin, ulong p0, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0x3F7325574E41B44D(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Ped__0x412F1364FA066CFB(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0x425AECF167663F48(IntPtr plugin, int ped, bool p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped__0x451294E859ECC018(IntPtr plugin, int p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Ped__0x451D05012CCEC234(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0x4668D80430D6C299(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped__0x46B05BCAE43856B0(IntPtr plugin, int ped, int flag);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0x4759CC730F947C81(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0x49E50BDB8BA4DAB2(IntPtr plugin, int ped, bool p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Ped__0x511F1A683387C7E2(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0x52D59AB61DDC05DD(IntPtr plugin, int ped, bool p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Ped__0x5407B7288D0478B7(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0x5615E0C5EB2BC6E2(IntPtr plugin, ulong p0, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0x570389D1C3DE3C6B(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0x576594E8D64375E2(IntPtr plugin, ulong p0, bool p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0x5A7F62FDA59759BD(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0x5AAB586FFEC0FD96(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0x5B6010B3CBC29095(IntPtr plugin, ulong p0, bool p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0x5D517B27CF6ECD04(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0x600048C60D5C2C51(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped__0x61767F73EACEED21(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Ped__0x6585D955A68452A5(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0x6647C5F6F5792496(IntPtr plugin, int ped, bool p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped__0x66680A92700F43DF(IntPtr plugin, int p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Ped__0x668FD40BCBA5DE48(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped__0x68772DB2B2526F9F(IntPtr plugin, int ped, float x, float y, float z, float range);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0x687C0B594907D2E8(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0x6B0E6172C9A4D902(IntPtr plugin, bool p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0x711794453CFD692B(IntPtr plugin, ulong p0, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0x733C87D4CE22BEA2(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped__0x7350823473013C02(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0x75BA1CB3B7D40CAF(IntPtr plugin, int ped, bool p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Ped__0x76BBA2CEE66D47E9(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0x781DE8FA214E87D2(IntPtr plugin, int ped, IntPtr p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped__0x784002A632822099(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0x78C4E9961DB3EB5B(IntPtr plugin, ulong p0, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0x7D7A2E43E74E2EB8(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped__0x7F2F4F13AC5257EF(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0x80054D7FCC70EEC6(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Ped__0x81AA517FBBA05D39(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0x820E9892A77E97CD(IntPtr plugin, ulong p0, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0x83A169EABCDB10A2(IntPtr plugin, ulong p0, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Ped__0x876928DDDFCCC9CD(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0x87DDEB611B329A9C(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Ped__0x8A24B067D175A7BD(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4, ulong p5);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Ped__0x8C4F3BF23B6237DB(IntPtr plugin, int ped, bool p1, bool p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0x952F06BEECD775CC(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Ped__0x953563CE563143AF(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0x9911F4A24485F653(IntPtr plugin, bool p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0x9A77DFD295E29B09(IntPtr plugin, ulong p0, bool p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped__0x9C6A6C19B6C0C496(IntPtr plugin, int p0, ref ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Ped__0x9D728C1E12BF5518(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0x9DBA107B4937F809(IntPtr plugin, ulong p0, IntPtr p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped__0x9E30E91FB03A2CAF(IntPtr plugin, ref ulong p0, ref ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0xA21C118553BBDF02(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0xA3A9299C4F2ADB98(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped__0xA3F3564A5B3646C0(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0xA52D5247A4227E14(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Ped__0xA586FBEB32A53DBB(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Ped__0xA635C11B8C44AFC2(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0xA660FAF550EB37E5(IntPtr plugin, ulong p0, bool p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0xA9B61A329BFDCBEA(IntPtr plugin, ulong p0, bool p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Ped__0xAAA6A3698A69E048(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0xAFC976FD0580C7B3(IntPtr plugin, int ped, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0xAFF4710E2A0A6C12(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0xB282749D5E028163(IntPtr plugin, ulong p0, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0xB2AFF10216DEFA2F(IntPtr plugin, float x, float y, float z, float p3, float p4, float p5, float p6, int interiorFlags, float scale, int duration);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0xB782F8238512BAD5(IntPtr plugin, ulong p0, ref ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped__0xB8B52E498014F5B0(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Ped__0xB9496CE47546DB2C(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped__0xBA63D9FE45412247(IntPtr plugin, int ped, bool p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Ped__0xBA8805A1108A2515(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0xC1F6EBF9A3D55538(IntPtr plugin, ulong p0, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0xC2EE020F5FB4DB53(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Ped__0xC56FBF2F228E1DAC(IntPtr plugin, ulong modelHash, ulong p1, ulong p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0xC79196DCB36F6121(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0xCB968B53FC7F916D(IntPtr plugin, ulong p0, bool p1, ulong p2, ulong p3);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Ped__0xCC6E3B6BB69501F1(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0xCC9682B8951C5229(IntPtr plugin, int ped, int r, int g, int b, int p4);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0xCD018C591F94CB43(IntPtr plugin, ulong p0, bool p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0xCEDA60A74219D064(IntPtr plugin, ulong p0, bool p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped__0xD1871251F3B5ACD7(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0xD33DAA36272177C4(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0xD69411AA0CEBF9E9(IntPtr plugin, int ped, int p1, int p2, int p3);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0xD8C3BE3EE94CAF2D(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped__0xDCCA191DF9980FD7(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0xDED5AF5A0EA4B297(IntPtr plugin, int driver, float p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0xE43A13C9E4CCCBCF(IntPtr plugin, int ped, bool p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0xE4723DB6E736CCFF(IntPtr plugin, int ped, ulong p1, float p2, float p3, float p4, float p5, bool p6);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0xE6CA85E7259CE16B(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0xE861D0B05C7662B8(IntPtr plugin, int p0, ulong p1, ref int p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Ped__0xE8A169E666CBC541(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0xE906EC930F5FE7C8(IntPtr plugin, ulong p0, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Ped__0xEA9960D07DADCF10(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Ped__0xEBB376779A760AA8(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped__0xEBD0EDBA5BE957CF(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0xEC4B4B3B9908052A(IntPtr plugin, int ped, float unk);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Ped__0xEC6935EBE0847B90(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0xED3C76ADFA6D07C4(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped__0xED6D8E27A43B8CDE(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Ped__0xEEED8FAFEC331A70(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Ped__0xF033419D1B81FAE8(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped__0xF0DAEF2F545BEE25(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0xF1C03A5352243A30(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped__0xF2385935BFFD4D92(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0xF2BEBCDFAFDAA19E(IntPtr plugin, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped__0xF41B5D290C99A3D6(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Ped__0xF445DE8DA80A1792(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0xF5846EDB26A98A24(IntPtr plugin, int ped, bool p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped__0xF60165E1D2C5370B(IntPtr plugin, int ped, ref ulong p1, ref ulong p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0xF79F9DEF0AADE61A(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0xF9ACF4A08098EA25(IntPtr plugin, int ped, bool p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped__0xFCF37A457CB96DC0(IntPtr plugin, ulong p0, float p1, float p2, float p3, float p4);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Ped__0xFE07FF6495D52E2A(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped__0xFEC9A3B1820F3331(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0xFEE4A5459472A9F8(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped__0xFF4803BC019852D9(IntPtr plugin, float p0, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_PlayFacialAnim(IntPtr plugin, int ped, IntPtr animName, IntPtr animDict);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_RegisterHatedTargetsAroundPed(IntPtr plugin, int ped, float radius);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Ped_RegisterPedheadshot(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_RegisterTarget(IntPtr plugin, int ped, int target);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_RemoveActionModeAsset(IntPtr plugin, IntPtr asset);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_RemoveGroup(IntPtr plugin, int groupId);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_RemovePedDefensiveArea(IntPtr plugin, int ped, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_RemovePedElegantly(IntPtr plugin, ref int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_RemovePedFromGroup(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_RemovePedHelmet(IntPtr plugin, int ped, bool instantly);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_RemovePedPreferredCoverSet(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_RemoveRelationshipGroup(IntPtr plugin, ulong groupHash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_RemoveScenarioBlockingArea(IntPtr plugin, ulong p0, bool p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_RemoveScenarioBlockingAreas(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_RemoveStealthModeAsset(IntPtr plugin, IntPtr asset);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_RequestActionModeAsset(IntPtr plugin, IntPtr asset);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_RequestStealthModeAsset(IntPtr plugin, IntPtr asset);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_ResetAiMeleeWeaponDamageModifier(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_ResetAiWeaponDamageModifier(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_ResetGroupFormationDefaultSpacing(IntPtr plugin, int groupHandle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_ResetPedInVehicleContext(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_ResetPedLastVehicle(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_ResetPedMovementClipset(IntPtr plugin, int ped, float p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_ResetPedRagdollBlockingFlags(IntPtr plugin, int ped, int flags);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_ResetPedRagdollTimer(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_ResetPedStrafeClipset(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Ped_ResetPedVisibleDamage(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_ResetPedWeaponMovementClipset(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_ResurrectPed(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_ReviveInjuredPed(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetAiMeleeWeaponDamageModifier(IntPtr plugin, float modifier);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetAiWeaponDamageModifier(IntPtr plugin, float value);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetBlockingOfNonTemporaryEvents(IntPtr plugin, int ped, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetCanAttackFriendly(IntPtr plugin, int ped, bool toggle, bool p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetCombatFloat(IntPtr plugin, int ped, int combatType, float p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetCreateRandomCops(IntPtr plugin, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetCreateRandomCopsNotOnScenarios(IntPtr plugin, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetCreateRandomCopsOnScenarios(IntPtr plugin, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetDriverAbility(IntPtr plugin, int driver, float ability);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetDriverAggressiveness(IntPtr plugin, int driver, float aggressiveness);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetEnableBoundAnkles(IntPtr plugin, int ped, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetEnableHandcuffs(IntPtr plugin, int ped, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetEnablePedEnveffScale(IntPtr plugin, int ped, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetEnableScuba(IntPtr plugin, int ped, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Ped_SetExclusivePhoneRelationships(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetFacialIdleAnimOverride(IntPtr plugin, int ped, IntPtr animName, IntPtr animDict);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetGroupFormation(IntPtr plugin, int groupId, int formationType);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetGroupFormationSpacing(IntPtr plugin, int groupId, float p1, float p2, float p3);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetGroupSeparationRange(IntPtr plugin, int groupHandle, float separationRange);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetIkTarget(IntPtr plugin, int ped, int ikIndex, int entityLookAt, int boneLookAt, float offsetX, float offsetY, float offsetZ, ulong p7, int blendInDuration, int blendOutDuration);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Ped_SetPedAccuracy(IntPtr plugin, int ped, int accuracy);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedAlertness(IntPtr plugin, int ped, int value);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedAllowedToDuck(IntPtr plugin, int ped, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedAllowVehiclesOverride(IntPtr plugin, int ped, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedAlternateMovementAnim(IntPtr plugin, int ped, int stance, IntPtr animDictionary, IntPtr animationName, float p4, bool p5);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedAlternateWalkAnim(IntPtr plugin, int ped, IntPtr animDict, IntPtr animName, float p3, bool p4);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedAngledDefensiveArea(IntPtr plugin, int ped, float p1, float p2, float p3, float p4, float p5, float p6, float p7, bool p8, bool p9);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedArmour(IntPtr plugin, int ped, int amount);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedAsCop(IntPtr plugin, int ped, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedAsEnemy(IntPtr plugin, int ped, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedAsGroupLeader(IntPtr plugin, int ped, int groupId);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedAsGroupMember(IntPtr plugin, int ped, int groupId);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedBlendFromParents(IntPtr plugin, int ped, int father, int mother, float fathersSide, float mothersSide);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedBoundsOrientation(IntPtr plugin, int ped, float p1, float p2, float p3, float p4, float p5);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedCanArmIk(IntPtr plugin, int ped, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedCanBeDraggedOut(IntPtr plugin, int ped, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedCanBeKnockedOffVehicle(IntPtr plugin, int ped, int state);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedCanBeShotInVehicle(IntPtr plugin, int ped, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedCanBeTargetedWhenInjured(IntPtr plugin, int ped, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedCanBeTargetedWithoutLos(IntPtr plugin, int ped, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedCanBeTargetted(IntPtr plugin, int ped, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedCanBeTargettedByPlayer(IntPtr plugin, int ped, int player, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedCanBeTargettedByTeam(IntPtr plugin, int ped, int team, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedCanCowerInCover(IntPtr plugin, int ped, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedCanEvasiveDive(IntPtr plugin, int ped, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedCanHeadIk(IntPtr plugin, int ped, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedCanLegIk(IntPtr plugin, int ped, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedCanPeekInCover(IntPtr plugin, int ped, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedCanPlayAmbientAnims(IntPtr plugin, int ped, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedCanPlayAmbientBaseAnims(IntPtr plugin, int ped, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedCanPlayGestureAnims(IntPtr plugin, int ped, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedCanPlayInjuredAnims(IntPtr plugin, int ped, bool p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedCanPlayVisemeAnims(IntPtr plugin, int ped, bool toggle, bool p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedCanRagdoll(IntPtr plugin, int ped, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedCanRagdollFromPlayerImpact(IntPtr plugin, int ped, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedCanSmashGlass(IntPtr plugin, int ped, bool p1, bool p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedCanSwitchWeapon(IntPtr plugin, int ped, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedCanTeleportToGroupLeader(IntPtr plugin, int pedHandle, int groupHandle, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedCanTorsoIk(IntPtr plugin, int ped, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedCanUseAutoConversationLookat(IntPtr plugin, int ped, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedCapsule(IntPtr plugin, int ped, float value);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedClothProne(IntPtr plugin, ulong p0, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedCombatAbility(IntPtr plugin, int ped, int p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedCombatAttributes(IntPtr plugin, int ped, int attributeIndex, bool enabled);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedCombatMovement(IntPtr plugin, int ped, int combatMovement);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedCombatRange(IntPtr plugin, int ped, int p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedComponentVariation(IntPtr plugin, int ped, int componentId, int drawableId, int textureId, int paletteId);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedConfigFlag(IntPtr plugin, int ped, int flagId, bool value);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedCoordsKeepVehicle(IntPtr plugin, int ped, float posX, float posY, float posZ);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedCoordsNoGang(IntPtr plugin, int ped, float posX, float posY, float posZ);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedCowerHash(IntPtr plugin, int ped, IntPtr p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedDecoration(IntPtr plugin, int ped, ulong collection, ulong overlay);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedDefaultComponentVariation(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedDefensiveAreaAttachedToPed(IntPtr plugin, int ped, int attachPed, float p2, float p3, float p4, float p5, float p6, float p7, float p8, bool p9, bool p10);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedDefensiveAreaDirection(IntPtr plugin, int ped, float p1, float p2, float p3, bool p4);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedDefensiveSphereAttachedToPed(IntPtr plugin, int ped, int target, float xOffset, float yOffset, float zOffset, float radius, bool p6);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedDensityMultiplierThisFrame(IntPtr plugin, float multiplier);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedDesiredHeading(IntPtr plugin, int ped, float heading);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedDiesInSinkingVehicle(IntPtr plugin, int ped, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedDiesInstantlyInWater(IntPtr plugin, int ped, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedDiesInVehicle(IntPtr plugin, int ped, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedDiesInWater(IntPtr plugin, int ped, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Ped_SetPedDiesWhenInjured(IntPtr plugin, int ped, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedDriveByClipsetOverride(IntPtr plugin, int ped, IntPtr clipset);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedDucking(IntPtr plugin, int ped, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Ped_SetPedEnableWeaponBlocking(IntPtr plugin, int ped, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedEnveffScale(IntPtr plugin, int ped, float value);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedEyeColor(IntPtr plugin, int ped, int index);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedFaceFeature(IntPtr plugin, int ped, int index, float scale);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedFacialDecoration(IntPtr plugin, int ped, ulong collection, ulong overlay);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedFiringPattern(IntPtr plugin, int ped, ulong patternHash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedFleeAttributes(IntPtr plugin, int ped, int attributes, bool p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedGeneratesDeadBodyEvents(IntPtr plugin, int ped, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedGestureGroup(IntPtr plugin, int ped, IntPtr animGroupGesture);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedGetOutUpsideDownVehicle(IntPtr plugin, int ped, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedGravity(IntPtr plugin, int ped, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedGroupMemberPassengerIndex(IntPtr plugin, int ped, int index);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedHairColor(IntPtr plugin, int ped, int colorID, int highlightColorID);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedHeadBlendData(IntPtr plugin, int ped, int shapeFirstID, int shapeSecondID, int shapeThirdID, int skinFirstID, int skinSecondID, int skinThirdID, float shapeMix, float skinMix, float thirdMix, bool isParent);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedHeadOverlay(IntPtr plugin, int ped, int overlayID, int index, float opacity);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedHeadOverlayColor(IntPtr plugin, int ped, int overlayID, int colorType, int colorID, int secondColorID);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedHearingRange(IntPtr plugin, int ped, float value);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedHelmet(IntPtr plugin, int ped, bool canWearHelmet);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedHelmetFlag(IntPtr plugin, int ped, int helmetFlag);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedHelmetPropIndex(IntPtr plugin, int ped, int propIndex);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedHelmetTextureIndex(IntPtr plugin, int ped, int textureIndex);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedIdRange(IntPtr plugin, int ped, float value);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedIlluminatedClothingGlowIntensity(IntPtr plugin, int ped, float intensity);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedIntoVehicle(IntPtr plugin, int ped, int vehicle, int seatIndex);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedInVehicleContext(IntPtr plugin, int ped, ulong context);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedKeepTask(IntPtr plugin, int ped, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedLegIkMode(IntPtr plugin, int ped, int mode);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedLodMultiplier(IntPtr plugin, int ped, float multiplier);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedMaxHealth(IntPtr plugin, int ped, int value);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedMaxMoveBlendRatio(IntPtr plugin, int ped, float value);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedMaxTimeInWater(IntPtr plugin, int ped, float value);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedMaxTimeUnderwater(IntPtr plugin, int ped, float value);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedMinGroundTimeForStungun(IntPtr plugin, int ped, int ms);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedMinMoveBlendRatio(IntPtr plugin, int ped, float value);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedModelIsSuppressed(IntPtr plugin, int ped, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedMoney(IntPtr plugin, int ped, int amount);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedMotionBlur(IntPtr plugin, int ped, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedMoveAnimsBlendOut(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedMovementClipset(IntPtr plugin, int ped, IntPtr clipSet, float p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedMoveRateOverride(IntPtr plugin, int ped, float value);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedNameDebug(IntPtr plugin, int ped, IntPtr name);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedNeverLeavesGroup(IntPtr plugin, int ped, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedNonCreationArea(IntPtr plugin, float x1, float y1, float z1, float x2, float y2, float z2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedParachuteTintIndex(IntPtr plugin, int ped, int tintIndex);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Ped_SetPedPinnedDown(IntPtr plugin, int ped, bool pinned, int p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedPlaysHeadOnHornAnimWhenDiesInVehicle(IntPtr plugin, int ped, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedPreferredCoverSet(IntPtr plugin, int ped, ulong itemSet);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedPrimaryLookat(IntPtr plugin, int ped, int lookAt);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedPropIndex(IntPtr plugin, int ped, int componentId, int drawableId, int TextureId, bool attach);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedRagdollBlockingFlags(IntPtr plugin, int ped, int flags);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Ped_SetPedRagdollForceFall(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedRagdollOnCollision(IntPtr plugin, int ped, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedRandomComponentVariation(IntPtr plugin, int ped, bool p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedRandomProps(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedRelationshipGroupDefaultHash(IntPtr plugin, int ped, ulong hash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedRelationshipGroupHash(IntPtr plugin, int ped, ulong hash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedReserveParachuteTintIndex(IntPtr plugin, int ped, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedResetFlag(IntPtr plugin, int ped, int flagId, bool doReset);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedSeeingRange(IntPtr plugin, int ped, float value);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedShootRate(IntPtr plugin, int ped, int shootRate);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedShootsAtCoord(IntPtr plugin, int ped, float x, float y, float z, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedSphereDefensiveArea(IntPtr plugin, int ped, float x, float y, float z, float radius, bool p5, bool p6);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedStayInVehicleWhenJacked(IntPtr plugin, int ped, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedStealthMovement(IntPtr plugin, int ped, bool p1, IntPtr action);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedSteersAroundObjects(IntPtr plugin, int ped, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedSteersAroundPeds(IntPtr plugin, int ped, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedSteersAroundVehicles(IntPtr plugin, int ped, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedStrafeClipset(IntPtr plugin, int ped, IntPtr clipSet);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedSuffersCriticalHits(IntPtr plugin, int ped, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedSweat(IntPtr plugin, int ped, float sweat);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedTargetLossResponse(IntPtr plugin, int ped, int responseType);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedToInformRespectedFriends(IntPtr plugin, int ped, float radius, int maxFriends);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedToLoadCover(IntPtr plugin, int ped, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_SetPedToRagdoll(IntPtr plugin, int ped, int time1, int time2, int ragdollType, bool p4, bool p5, bool p6);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_SetPedToRagdollWithFall(IntPtr plugin, int ped, int time, int p2, int ragdollType, float x, float y, float z, float p7, float p8, float p9, float p10, float p11, float p12, float p13);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedUsingActionMode(IntPtr plugin, int ped, bool p1, ulong p2, IntPtr action);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedVisualFieldCenterAngle(IntPtr plugin, int ped, float angle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedVisualFieldMaxAngle(IntPtr plugin, int ped, float value);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedVisualFieldMaxElevationAngle(IntPtr plugin, int ped, float angle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedVisualFieldMinAngle(IntPtr plugin, int ped, float value);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedVisualFieldMinElevationAngle(IntPtr plugin, int ped, float angle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedVisualFieldPeripheralRange(IntPtr plugin, int ped, float range);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedWeaponMovementClipset(IntPtr plugin, int ped, IntPtr clipSet);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedWetnessEnabledThisFrame(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetPedWetnessHeight(IntPtr plugin, int ped, float height);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetRelationshipBetweenGroups(IntPtr plugin, int relationship, ulong group1, ulong group2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetScenarioPedDensityMultiplierThisFrame(IntPtr plugin, float p0, float p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetScenarioPedsSpawnInSphereArea(IntPtr plugin, float x, float y, float z, float range, int p4);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetScenarioPedsToBeReturnedByNextCommand(IntPtr plugin, bool value);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetScriptedAnimSeatOffset(IntPtr plugin, int ped, float p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetScriptedConversionCoordThisFrame(IntPtr plugin, float x, float y, float z);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetSynchronizedSceneLooped(IntPtr plugin, int sceneID, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetSynchronizedSceneOcclusionPortal(IntPtr plugin, ulong sceneID, bool p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetSynchronizedSceneOrigin(IntPtr plugin, int sceneID, float x, float y, float z, float roll, float pitch, float yaw, bool p7);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetSynchronizedScenePhase(IntPtr plugin, int sceneID, float phase);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetSynchronizedSceneRate(IntPtr plugin, int sceneID, float rate);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_SetTimeExclusiveDisplayTexture(IntPtr plugin, ulong p0, bool p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_StopAnyPedModelBeingSuppressed(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_StopPedWeaponFiringWhenDropped(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_UnregisterPedheadshot(IntPtr plugin, int handle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Ped_UpdatePedHeadBlendData(IntPtr plugin, int ped, float shapeMix, float skinMix, float thirdMix);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_WasPedKilledByStealth(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_WasPedKilledByTakedown(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Ped_WasPedSkeletonUpdated(IntPtr plugin, int ped);
}
