using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CryV.Net.Native;

internal static partial class CryVNative
{
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern float Native_Misc_Absf(IntPtr plugin, float value);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Misc_Absi(IntPtr plugin, int value);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern float Native_Misc_Acos(IntPtr plugin, float p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Misc_AddHospitalRestart(IntPtr plugin, float x, float y, float z, float p3, ulong p4);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Misc_AddPoliceRestart(IntPtr plugin, float p0, float p1, float p2, float p3, ulong p4);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Misc_AddStuntJump(IntPtr plugin, float x1, float y1, float z1, float x2, float y2, float z2, float x3, float y3, float z3, float x4, float y4, float z4, float camX, float camY, float camZ, int unk1, int unk2, int unk3);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Misc_AddStuntJumpAngled(IntPtr plugin, float x1, float y1, float z1, float x2, float y2, float z2, float radius1, float x3, float y3, float z3, float x4, float y4, float z4, float radius2, float camX, float camY, float camZ, int unk1, int unk2, int unk3);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Misc_AreStringsEqual(IntPtr plugin, IntPtr string1, IntPtr string2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern float Native_Misc_Asin(IntPtr plugin, float p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern float Native_Misc_Atan(IntPtr plugin, float p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern float Native_Misc_Atan2(IntPtr plugin, float p0, float p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_BeginReplayStats(IntPtr plugin, ulong p0, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_CancelStuntJump(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_ClearAngledAreaOfVehicles(IntPtr plugin, float p0, float p1, float p2, float p3, float p4, float p5, float p6, bool p7, bool p8, bool p9, bool p10, bool p11);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_ClearArea(IntPtr plugin, float X, float Y, float Z, float radius, bool p4, bool ignoreCopCars, bool ignoreObjects, bool p7);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_ClearAreaOfCops(IntPtr plugin, float x, float y, float z, float radius, int flags);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_ClearAreaOfEverything(IntPtr plugin, float x, float y, float z, float radius, bool p4, bool p5, bool p6, bool p7);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_ClearAreaOfObjects(IntPtr plugin, float x, float y, float z, float radius, int flags);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_ClearAreaOfPeds(IntPtr plugin, float x, float y, float z, float radius, int flags);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_ClearAreaOfProjectiles(IntPtr plugin, float x, float y, float z, float radius, bool isNetworkGame);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_ClearAreaOfVehicles(IntPtr plugin, float x, float y, float z, float radius, bool p4, bool p5, bool p6, bool p7, bool p8);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_ClearBit(IntPtr plugin, ref int address, int offset);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_ClearCloudHat(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_ClearOverrideWeather(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_ClearReplayStats(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_ClearWeatherTypePersist(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Misc_CompareStrings(IntPtr plugin, IntPtr str1, IntPtr str2, bool matchCase, int maxLength);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Misc_CreateIncident(IntPtr plugin, int incidentType, float x, float y, float z, int p5, float radius, ref int outIncidentID);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Misc_CreateIncidentWithEntity(IntPtr plugin, int incidentType, int ped, int amountOfPeople, float radius, ref int outIncidentID);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_CreateLightningThunder(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_DeleteIncident(IntPtr plugin, int incidentId);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_DeleteStuntJump(IntPtr plugin, int p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_DisableAutomaticRespawn(IntPtr plugin, bool disableRespawn);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_DisableHospitalRestart(IntPtr plugin, int hospitalIndex, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_DisablePoliceRestart(IntPtr plugin, int policeIndex, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_DisableStuntJumpSet(IntPtr plugin, int p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_DisplayOnscreenKeyboard(IntPtr plugin, int p0, IntPtr windowTitle, IntPtr p2, IntPtr defaultText, IntPtr defaultConcat1, IntPtr defaultConcat2, IntPtr defaultConcat3, int maxInputLength);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_DisplayOnscreenKeyboard2(IntPtr plugin, int p0, IntPtr windowTitle, ref ulong p2, IntPtr defaultText, IntPtr defaultConcat1, IntPtr defaultConcat2, IntPtr defaultConcat3, IntPtr defaultConcat4, IntPtr defaultConcat5, IntPtr defaultConcat6, IntPtr defaultConcat7, int maxInputLength);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_DoAutoSave(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_EnableDispatchService(IntPtr plugin, int dispatchService, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_EnableStuntJumpSet(IntPtr plugin, int p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_EnableTennisMode(IntPtr plugin, int ped, bool toggle, bool p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_EndReplayStats(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_ForceSocialClubUpdate(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Misc_GetAllocatedStackSize(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern float Native_Misc_GetAngleBetween2DVectors(IntPtr plugin, float x1, float y1, float x2, float y2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern float Native_Misc_GetBenchmarkTime(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Misc_GetBitsInRange(IntPtr plugin, int var, int rangeStart, int rangeEnd);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern float Native_Misc_GetCloudHatOpacity(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern float Native_Misc_GetDistanceBetweenCoords(IntPtr plugin, float x1, float y1, float z1, float x2, float y2, float z2, bool useZ);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Misc_GetFakeWantedLevel(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Misc_GetFrameCount(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern float Native_Misc_GetFrameTime(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Misc_GetFreeStackSlotsCount(IntPtr plugin, int threadId);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Misc_GetGameTimer(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern IntPtr Native_Misc_GetGlobalCharBuffer(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Misc_GetGroundZFor3DCoord(IntPtr plugin, float x, float y, float z, ref float groundZ, bool unk);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Misc_GetHashKey(IntPtr plugin, IntPtr @string);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern float Native_Misc_GetHeadingFromVector2D(IntPtr plugin, float dx, float dy);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Misc_GetIndexOfCurrentLevel(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Misc_GetMissionFlag(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Misc_GetNextWeatherTypeHashName(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Misc_GetNumberOfDispatchedUnitsForPlayer(IntPtr plugin, int dispatchService);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern IntPtr Native_Misc_GetOnscreenKeyboardResult(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Misc_GetPrevWeatherTypeHashName(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Misc_GetProfileSetting(IntPtr plugin, int profileSetting);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ref ulong Native_Misc_GetRainLevel(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Misc_GetRandomEventFlag(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern float Native_Misc_GetRandomFloatInRange(IntPtr plugin, float startRange, float endRange);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Misc_GetRandomIntInRange(IntPtr plugin, int startRange, int endRange);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Misc_GetSnowLevel(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_GetWeatherTypeTransition(IntPtr plugin, ref ulong weatherType1, ref ulong weatherType2, ref float percentWeather2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern IntPtr Native_Misc_GetWindDirection(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern float Native_Misc_GetWindSpeed(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Misc_HasBulletImpactedInArea(IntPtr plugin, float x, float y, float z, float p3, bool p4, bool p5);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Misc_HasBulletImpactedInBox(IntPtr plugin, float p0, float p1, float p2, float p3, float p4, float p5, bool p6, bool p7);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Misc_HasButtonCombinationJustBeenEntered(IntPtr plugin, ulong hash, int amount);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Misc_HasCheatStringJustBeenEntered(IntPtr plugin, ulong hash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_IgnoreNextRestart(IntPtr plugin, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Misc_IsAreaOccupied(IntPtr plugin, float p0, float p1, float p2, float p3, float p4, float p5, bool p6, bool p7, bool p8, bool p9, bool p10, ulong p11, bool p12);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Misc_IsAussieVersion(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Misc_IsAutoSaveInProgress(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Misc_IsBitSet(IntPtr plugin, int address, int offset);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Misc_IsBulletInAngledArea(IntPtr plugin, float p0, float p1, float p2, float p3, float p4, float p5, float p6, bool p7);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Misc_IsBulletInArea(IntPtr plugin, float p0, float p1, float p2, float p3, bool p4);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Misc_IsBulletInBox(IntPtr plugin, float p0, float p1, float p2, float p3, float p4, float p5, bool p6);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Misc_IsDurangoVersion(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Misc_IsFrontendFading(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Misc_IsIncidentValid(IntPtr plugin, int incidentId);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Misc_IsMemoryCardInUse(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Misc_IsMinigameInProgress(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Misc_IsNextWeatherType(IntPtr plugin, IntPtr weatherType);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Misc_IsOrbisVersion(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Misc_IsPcVersion(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Misc_IsPointObscuredByAMissionEntity(IntPtr plugin, float p0, float p1, float p2, float p3, float p4, float p5, ulong p6);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Misc_IsPositionOccupied(IntPtr plugin, float x, float y, float z, float range, bool p4, bool p5, bool p6, bool p7, bool p8, ulong p9, bool p10);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Misc_IsPrevWeatherType(IntPtr plugin, IntPtr weatherType);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Misc_IsProjectileInArea(IntPtr plugin, float x1, float y1, float z1, float x2, float y2, float z2, bool ownedByPlayer);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Misc_IsProjectileTypeInAngledArea(IntPtr plugin, float p0, float p1, float p2, float p3, float p4, float p5, float p6, ulong p7, bool p8);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Misc_IsProjectileTypeInArea(IntPtr plugin, float x1, float y1, float z1, float x2, float y2, float z2, int type, bool p7);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Misc_IsProjectileTypeInRadius(IntPtr plugin, float x, float y, float z, ulong projHash, float radius, bool ownedByPlayer);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Misc_IsPs3Version(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Misc_IsSniperBulletInArea(IntPtr plugin, float x1, float y1, float z1, float x2, float y2, float z2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Misc_IsSniperInverted(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Misc_IsStringNull(IntPtr plugin, IntPtr @string);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Misc_IsStringNullOrEmpty(IntPtr plugin, IntPtr @string);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Misc_IsStuntJumpInProgress(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Misc_IsStuntJumpMessageShowing(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Misc_IsTennisMode(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Misc_IsThisAMinigameScript(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Misc_IsXbox360Version(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_NetworkSetScriptIsSafeForNetworkGame(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0x02DEAAC8F8EA7FE7(IntPtr plugin, IntPtr p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0x06462A961E94B67C(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Misc__0x075F1D57402C93BA(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0x0A60017F841A54F2(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0x0CF97F497FE7D048(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0x11B56FBBF7224868(IntPtr plugin, IntPtr p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Misc__0x1327E2FE9746BAEE(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Misc__0x14832BF2ABA53FC5(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Misc__0x171BAFB3C60389F4(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Misc__0x17DF68D720AA77F8(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Misc__0x19BFED045C647C49(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Misc__0x1B2366C3F2A5C8DF(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0x1BB299305C3E8C13(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0x1EAE0A6E978894A2(IntPtr plugin, int p0, bool p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0x1FF6BF9A63E5757F(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Misc__0x2107A3773771186D(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0x213AEB2B90CBA7AC(IntPtr plugin, ulong p0, ulong p1, ulong p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern IntPtr Native_Misc__0x21C235BC64831E5A(IntPtr plugin, float p0, float p1, float p2, float p3, float p4, float p5, float p6, float p7, float p8, bool p9);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0x23227DF0B2115469(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0x2587A48BC88DFADF(IntPtr plugin, bool p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Misc__0x2B5E102E4A42F2BF(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Misc__0x2B626A0150E4D449(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Misc__0x2D4259F1FEB81DA9(IntPtr plugin, float p0, float p1, float p2, float p3);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0x31125FD509D9043F(IntPtr plugin, ref ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0x31727907B2C43C55(IntPtr plugin, float p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Misc__0x32C7A7E8C43A1F80(IntPtr plugin, float p0, float p1, float p2, float p3, float p4, float p5, bool p6, bool p7);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0x37DEB0AA183FB6D8(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Misc__0x397BAA01068BAA96(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Misc__0x3BBBD13E5041A79E(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0x3ED1438C1F5C6612(IntPtr plugin, int p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0x405591EC8FD9096D(IntPtr plugin, float p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0x437138B6A830166A(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0x438822C279B73B93(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Misc__0x44A0BDC559B35F6E(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Misc__0x4750FC27570311EC(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0x48F069265A0E4BEC(IntPtr plugin, ref ulong p0, IntPtr name);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0x4DCDF92BF64236CD(IntPtr plugin, IntPtr p0, IntPtr p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0x54F157E0336A3822(IntPtr plugin, ulong p0, IntPtr p1, float p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0x58A39BE597CE99CD(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Misc__0x5AA3BEFA29F03AD4(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Misc__0x5B1F2E327B6B6FE1(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0x6216B116083A7CB4(IntPtr plugin, float p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0x65D2EBB47E1CEC21(IntPtr plugin, bool p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Misc__0x67F6413D3220E18D(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4, ulong p5, ulong p6, ulong p7, ulong p8);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Misc__0x684A41975F077262(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Misc__0x6856EC3D35C81EA4(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0x693478ACBD7F18E7(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0x69FE6DC87BD2A5E9(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Misc__0x6E04F06094C87047(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0x6F2135B6129620C1(IntPtr plugin, bool p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0x6F7794F28C6B2535(IntPtr plugin, ref ulong p0, IntPtr name);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Misc__0x6FDDF453C0C756EC(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0x703CC7F60CBB2B57(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Misc__0x72DE52178C291CB5(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0x7C9C0B1EEB1F9072(IntPtr plugin, float p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0x7EC6F9A478A6A512(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern float Native_Misc__0x7F8F6405F4777AF6(IntPtr plugin, float p0, float p1, float p2, float p3, float p4, float p5, float p6, float p7, float p8, bool p9);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Misc__0x8098C8D6597AAE18(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0x8269816F6CFD40F8(IntPtr plugin, ref ulong p0, IntPtr name);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0x8951EB9C6906D3C8(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0x8D74E26F54B4E5C3(IntPtr plugin, IntPtr p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Misc__0x8EF5573A1F801A5C(IntPtr plugin, ulong p0, ref ulong p1, ref ulong p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0x8FA9C42FC5D7C64B(IntPtr plugin, ulong p0, ulong p1, float p2, float p3, float p4, bool p5);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Misc__0x918C7B2D2FF3928B(IntPtr plugin, float p0, float p1, float p2, float p3, float p4, float p5, float p6);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0x92790862E36C2ADA(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Misc__0x9689123E3F213AA5(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0x97E7E2C04245115B(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Misc__0x996DD1E1E02F1008(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0x9B2BD3773123EA2F(IntPtr plugin, int type, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0x9D8D44ADBBA61EF2(IntPtr plugin, bool p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Misc__0x9E82F0F362881B29(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0x9F5E6BB6B34540DA(IntPtr plugin, float p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Misc__0xA049A5BE0F04F2F8(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Misc__0xA09F896CE912481F(IntPtr plugin, bool p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Misc__0xA4A0065E39C9F25C(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0xA735353C77334EA0(IntPtr plugin, ref ulong p0, ref ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0xA74802FB8D0B7814(IntPtr plugin, IntPtr p0, float p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0xA7A1127490312C36(IntPtr plugin, float p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0xA8434F1DFF41D6E7(IntPtr plugin, float p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Misc__0xABB2FA71C83A1B72(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0xB08B85D860E7BA3C(IntPtr plugin, ulong p0, ulong p1, ulong p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0xB129E447A2EDA4BF(IntPtr plugin, ulong p0, bool p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Misc__0xB335F761606DB47C(IntPtr plugin, ref ulong p1, ref ulong p2, ulong p3, bool p4);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0xB3CD58CCA6CDA852(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0xB3E6360DDE733E82(IntPtr plugin, float p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0xB51B9AB9EF81868C(IntPtr plugin, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0xB8721407EE9C3FF6(IntPtr plugin, ulong p0, ulong p1, ulong p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0xB8F87EAD7533B176(IntPtr plugin, float p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0xB9854DFDE0D833D6(IntPtr plugin, float p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0xBA4B8D83BDC75551(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0xC3C221ADDDE31A11(IntPtr plugin, float p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0xC3EAD29AB273ECE8(IntPtr plugin, float p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0xC54A08C85AE4D410(IntPtr plugin, float p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0xC79AE21974B01FB2(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0xC7DB36C24634F52B(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Misc__0xD10282B6E3751BA0(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0xD10F442036302D50(IntPtr plugin, ulong p0, ulong p1, ulong p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0xD261BA3E7E998072(IntPtr plugin, ulong p0, float p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Misc__0xD642319C54AADEB6(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0xD79185689F8FD5DF(IntPtr plugin, bool p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0xD9F692D349249528(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Misc__0xDC9274A7EF6B2867(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0xDEA36202FC3382DF(IntPtr plugin, bool p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0xE266ED23311F24D4(IntPtr plugin, ulong p0, ref ulong p1, ref ulong p2, float p3, float p4, bool p5);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0xE3D969D2785FFB5E(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0xE532EC1A63231B4F(IntPtr plugin, ulong p0, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0xE574A662ACAEFBB1(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0xE6869BECDD8F2403(IntPtr plugin, ulong p0, bool p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Misc__0xE8B9C0EC9E183F35(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Misc__0xE95B0C7D5BA3B96B(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Misc__0xEA2F2061875EED90(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0xEB078CA2B5E82ADD(IntPtr plugin, ulong p0, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Misc__0xEB2104E905C6F2E9(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0xEBD3205A207939ED(IntPtr plugin, ref ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0xF2F6A2FA49278625(IntPtr plugin, float p0, float p1, float p2, float p3, float p4, float p5, float p6, float p7, float p8, ref ulong p9, ref ulong p10, ref ulong p11, ref ulong p12);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Misc__0xF56DFB7B61BE7276(IntPtr plugin, float p0, float p1, float p2, float p3, float p4, float p5, float p6, float p7, float p8, float p9, float p10, float p11, ref ulong p12);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0xF751B16FB32ABC1D(IntPtr plugin, float p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0xFAA457EF263E8763(IntPtr plugin, ref ulong p0, IntPtr name);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0xFB00CA71DA386228(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc__0xFB80AB299D2EE1BD(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Misc_OverrideSaveHouse(IntPtr plugin, bool p0, float p1, float p2, float p3, float p4, bool p5, float p6, float p7);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_PopulateNow(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_RegisterBoolToSave(IntPtr plugin, ref ulong p0, IntPtr name);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_RegisterEnumToSave(IntPtr plugin, ref ulong p0, IntPtr name);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_RegisterFloatToSave(IntPtr plugin, ref ulong p0, IntPtr name);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_RegisterIntToSave(IntPtr plugin, ref ulong p0, IntPtr name);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Misc_RegisterSaveHouse(IntPtr plugin, float p0, float p1, float p2, float p3, ref ulong p4, ulong p5, ulong p6);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_RegisterTextLabelToSave(IntPtr plugin, ref ulong p0, IntPtr name);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_RemoveDispatchSpawnBlockingArea(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_RemoveStealthKill(IntPtr plugin, ulong hash, bool p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_ResetDispatchIdealSpawnDistance(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_ResetDispatchSpawnBlockingAreas(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_ResetLocalplayerState(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_SetBit(IntPtr plugin, ref int address, int offset);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_SetBitsInRange(IntPtr plugin, ref int var, int rangeStart, int rangeEnd, int p3);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_SetCloudHatOpacity(IntPtr plugin, float opacity);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_SetCloudHatTransition(IntPtr plugin, IntPtr type, float transitionTime);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_SetCreditsActive(IntPtr plugin, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_SetCustomRespawnPosition(IntPtr plugin, float x, float y, float z, float heading);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_SetDispatchIdealSpawnDistance(IntPtr plugin, float p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_SetDispatchTimeBetweenSpawnAttempts(IntPtr plugin, ulong p0, float p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_SetDispatchTimeBetweenSpawnAttemptsMultiplier(IntPtr plugin, ulong p0, float p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_SetExplosiveAmmoThisFrame(IntPtr plugin, int player);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Misc_SetExplosiveMeleeThisFrame(IntPtr plugin, int player);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_SetFadeInAfterDeathArrest(IntPtr plugin, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_SetFadeInAfterLoad(IntPtr plugin, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_SetFadeOutAfterArrest(IntPtr plugin, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_SetFadeOutAfterDeath(IntPtr plugin, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_SetFakeWantedLevel(IntPtr plugin, int fakeWantedLevel);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Misc_SetFireAmmoThisFrame(IntPtr plugin, int player);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_SetGamePaused(IntPtr plugin, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_SetGravityLevel(IntPtr plugin, int level);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_SetMinigameInProgress(IntPtr plugin, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_SetMissionFlag(IntPtr plugin, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_SetNextRespawnToCustom(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_SetOverrideWeather(IntPtr plugin, IntPtr weatherType);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_SetRainFxIntensity(IntPtr plugin, float intensity);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_SetRandomEventFlag(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_SetRandomSeed(IntPtr plugin, int time);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_SetRandomWeatherType(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_SetSaveHouse(IntPtr plugin, ulong p0, bool p1, bool p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_SetSaveMenuActive(IntPtr plugin, bool unk);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Misc_SetSuperJumpThisFrame(IntPtr plugin, int player);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_SetThisScriptCanBePaused(IntPtr plugin, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_SetThisScriptCanRemoveBlipsCreatedByAnyScript(IntPtr plugin, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_SetTimeScale(IntPtr plugin, float time);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_SetUnkMapFlag(IntPtr plugin, int flag);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_SetWeatherTypeNow(IntPtr plugin, IntPtr weatherType);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_SetWeatherTypeNowPersist(IntPtr plugin, IntPtr weatherType);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_SetWeatherTypeOverTime(IntPtr plugin, IntPtr weatherType, float time);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_SetWeatherTypePersist(IntPtr plugin, IntPtr weatherType);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_SetWeatherTypeTransition(IntPtr plugin, ulong weatherType1, ulong weatherType2, float percentWeather2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_SetWind(IntPtr plugin, float speed);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_SetWindDirection(IntPtr plugin, float direction);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_SetWindSpeed(IntPtr plugin, float speed);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_ShootSingleBulletBetweenCoords(IntPtr plugin, float x1, float y1, float z1, float x2, float y2, float z2, int damage, bool p7, ulong weaponHash, int ownerPed, bool isAudible, bool isInvisible, float speed);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_ShootSingleBulletBetweenCoordsPresetParams(IntPtr plugin, float x1, float y1, float z1, float x2, float y2, float z2, int damage, bool p7, ulong weaponHash, int ownerPed, bool isAudible, bool isInvisible, float speed, int entity);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_ShootSingleBulletBetweenCoordsWithExtraParams(IntPtr plugin, float x1, float y1, float z1, float x2, float y2, float z2, int damage, bool p7, ulong weaponHash, int ownerPed, bool isAudible, bool isInvisible, float speed, int entity, bool p14, bool p15, bool p16, bool p17);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Misc_ShouldUseMetricMeasurements(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_ShowPedInPauseMenu(IntPtr plugin, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_StartSaveArray(IntPtr plugin, ref ulong p0, int p1, IntPtr arrayName);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_StartSaveData(IntPtr plugin, ref ulong p0, ulong p1, bool p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_StartSaveStruct(IntPtr plugin, ref ulong p0, int p1, IntPtr structName);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_StopSaveArray(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_StopSaveData(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_StopSaveStruct(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Misc_StringToInt(IntPtr plugin, IntPtr @string, ref int outInteger);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern float Native_Misc_Tan(IntPtr plugin, float p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_TerminateAllScriptsWithThisName(IntPtr plugin, IntPtr scriptName);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Misc_UpdateOnscreenKeyboard(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_UseFreemodeMapBehavior(IntPtr plugin, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_UsingMissionCreator(IntPtr plugin, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern IntPtr Native_Misc_GetAllPeds(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern IntPtr Native_Misc_GetAllVehicles(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Misc_Wait(IntPtr plugin, int ms);
}
