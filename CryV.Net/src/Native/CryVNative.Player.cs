using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CryV.Net.Native
{
    internal static partial class CryVNative
    {
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Player_ArePlayerFlashingStarsAboutToDrop(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Player_ArePlayerStarsGreyedOut(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_AssistedMovementCloseRoute(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_AssistedMovementFlushRoute(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Player_CanPedHearPlayer(IntPtr plugin, int player, int ped);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Player_CanPlayerStartMission(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_ChangePlayerPed(IntPtr plugin, int Player, int ped, bool b2, bool b3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_ClearPlayerHasDamagedAtLeastOneNonAnimalPed(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_ClearPlayerHasDamagedAtLeastOnePed(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_ClearPlayerParachuteModelOverride(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_ClearPlayerParachutePackModelOverride(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_ClearPlayerParachuteVariationOverride(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_ClearPlayerWantedLevel(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_DisablePlayerFiring(IntPtr plugin, int player, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_DisablePlayerVehicleRewards(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_DisplaySystemSigninUi(IntPtr plugin, bool unk);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_EnableSpecialAbility(IntPtr plugin, int player, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_ExpandWorldLimits(IntPtr plugin, float x, float y, float z);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_ForceCleanup(IntPtr plugin, int cleanupFlags);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_ForceCleanupForAllThreadsWithThisName(IntPtr plugin, IntPtr name, int cleanupFlags);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_ForceCleanupForThreadWithThisId(IntPtr plugin, int id, int cleanupFlags);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Player_GetAchievementProgression(IntPtr plugin, int achId);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Player_GetCauseOfMostRecentForceCleanup(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Player_GetEntityPlayerIsFreeAimingAt(IntPtr plugin, int player, ref int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Player_GetMaxWantedLevel(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Player_GetNumberOfPlayers(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Player_GetPlayerCurrentStealthNoise(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Player_GetPlayerGroup(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Player_GetPlayerHasReserveParachute(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Player_GetPlayerIndex(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Player_GetPlayerInvincible(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Player_GetPlayerMaxArmour(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Native_Player_GetPlayerName(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_GetPlayerParachutePackTintIndex(IntPtr plugin, int player, ref int tintIndex);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_GetPlayerParachuteSmokeTrailColor(IntPtr plugin, int player, ref int r, ref int g, ref int b);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_GetPlayerParachuteTintIndex(IntPtr plugin, int player, ref int tintIndex);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Player_GetPlayerPed(IntPtr plugin, int playerId);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Player_GetPlayerPedScriptIndex(IntPtr plugin, int Player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_GetPlayerReserveParachuteTintIndex(IntPtr plugin, int player, ref int index);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_GetPlayerRgbColour(IntPtr plugin, int Player, ref int r, ref int g, ref int b);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Player_GetPlayersLastVehicle(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Player_GetPlayerSprintStaminaRemaining(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Player_GetPlayerSprintTimeRemaining(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Player_GetPlayerTargetEntity(IntPtr plugin, int player, ref int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Player_GetPlayerTeam(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Player_GetPlayerUnderwaterTimeRemaining(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Native_Player_GetPlayerWantedCentrePosition(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Player_GetPlayerWantedLevel(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Player_GetTimeSinceLastArrest(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Player_GetTimeSinceLastDeath(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Player_GetTimeSincePlayerDroveAgainstTraffic(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Player_GetTimeSincePlayerDroveOnPavement(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Player_GetTimeSincePlayerHitPed(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Player_GetTimeSincePlayerHitVehicle(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Player_GetWantedLevelRadius(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Player_GetWantedLevelThreshold(IntPtr plugin, int wantedLevel);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Player_GiveAchievementToPlayer(IntPtr plugin, int achId);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_GivePlayerRagdollControl(IntPtr plugin, int player, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Player_HasAchievementBeenPassed(IntPtr plugin, int achievement);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Player_HasForceCleanupOccurred(IntPtr plugin, int cleanupFlags);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Player_HasPlayerBeenSpottedInStolenVehicle(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Player_HasPlayerDamagedAtLeastOneNonAnimalPed(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Player_HasPlayerDamagedAtLeastOnePed(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Player_HasPlayerLeftTheWorld(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Player_HasPlayerTeleportFinished(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Player_IntToParticipantindex(IntPtr plugin, int value);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Player_IntToPlayerindex(IntPtr plugin, int value);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Player_IsPlayerBeingArrested(IntPtr plugin, int player, bool atArresting);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Player_IsPlayerCamControlDisabled(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Player_IsPlayerClimbing(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Player_IsPlayerControlOn(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Player_IsPlayerDead(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Player_IsPlayerFreeAiming(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Player_IsPlayerFreeAimingAtEntity(IntPtr plugin, int player, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Player_IsPlayerFreeForAmbientTask(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Player_IsPlayerLoggingInNp(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Player_IsPlayerOnline(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Player_IsPlayerPlaying(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Player_IsPlayerPressingHorn(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Player_IsPlayerReadyForCutscene(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Player_IsPlayerRidingTrain(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Player_IsPlayerScriptControlOn(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Player_IsPlayerTargettingAnything(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Player_IsPlayerTargettingEntity(IntPtr plugin, int player, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Player_IsPlayerTeleportActive(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Player_IsPlayerWantedLevelGreater(IntPtr plugin, int player, int wantedLevel);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Player_IsSpecialAbilityActive(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Player_IsSpecialAbilityEnabled(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Player_IsSpecialAbilityMeterFull(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Player_IsSpecialAbilityUnlocked(IntPtr plugin, ulong playerModel);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Player_IsSystemUiBeingDisplayed(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Player_NetworkPlayerIdToInt(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player__0x0032A6DBA562C518(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player__0x17F7471EACA78290(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player__0x2382AB11450AE7BA(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player__0x2F41A3BAE005E5FA(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player__0x2F7CEB6520288061(IntPtr plugin, bool p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player__0x31E90B8873A4CD3B(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player__0x36F1B38855F2A8DF(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Player__0x38D28DA81E4E9BF9(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Player__0x4669B3ED80F24B4E(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player__0x5501B7A5CDB79D37(IntPtr plugin, int p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player__0x55FCC0C390620314(IntPtr plugin, int player1, int player2, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Player__0x56105E599CAB0EFA(IntPtr plugin, ref int p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player__0x5702B917B99DB1CD(IntPtr plugin, int p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Player__0x5FC472C501CCADB3(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Player__0x65FAEE425DE637B0(IntPtr plugin, int p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Player__0x690A61A6D13583F6(IntPtr plugin, int p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player__0x6BC97F4F4BB3C04B(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Player__0x6E4361FF3E8CD7CA(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Player__0x7E07C78925D5FD96(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player__0x821FDC827D6F4090(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Player__0x8BC515BAE4AAF8FF(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player__0x8D768602ADEF2245(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player__0x9EDD76E87D5D51BA(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Player__0xA0D3E4F7AAFB7E78(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Player__0xAD73CE5A09E42D12(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player__0xB214D570EAD7F81A(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player__0xB45EFF719D8427A6(IntPtr plugin, float p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player__0xB885852C39CC265D(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Player__0xB9CF1F793A9F1BF1(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Player__0xBC0753C9CA14B506(IntPtr plugin, int player, int p1, bool p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player__0xBC9490CA15AEA8FB(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player__0xBCFDE9EDE4CF27DC(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player__0xC3376F42B1FACCC6(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player__0xC388A0F065F5BC34(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player__0xC9A763D8FE87436A(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player__0xCAC57395B151135F(IntPtr plugin, int player, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Player__0xCB645E85E97EA48B(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player__0xD2B315B6689D537D(IntPtr plugin, int player, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player__0xD821056B9ACF8052(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player__0xDC64D2C53493ED12(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Player__0xDD2620B7B9D16FF1(IntPtr plugin, int player, float p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player__0xDE45D1A1EF45EE61(IntPtr plugin, int player, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player__0xEFD79FA81DFBA9CB(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Player__0xF10B44FD479D69F3(IntPtr plugin, int player, int p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player__0xFAC75988A7D078D3(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player__0xFF300C7649724A0B(IntPtr plugin, int player, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player__0xFFEE8FA29AB9A18E(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_PlayerAttachVirtualBound(IntPtr plugin, float p0, float p1, float p2, float p3, float p4, float p5, float p6, float p7);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_PlayerDetachVirtualBound(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Player_PlayerId(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Player_PlayerPedId(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Player_RemovePlayerHelmet(IntPtr plugin, int player, bool p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_ReportCrime(IntPtr plugin, int player, int crimeType, int wantedLvlThresh);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_ResetPlayerArrestState(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_ResetPlayerInputGait(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_ResetPlayerStamina(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_ResetWantedLevelDifficulty(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_RestorePlayerStamina(IntPtr plugin, int player, float p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Player_SetAchievementProgression(IntPtr plugin, int achId, int progression);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SetAirDragMultiplierForPlayersVehicle(IntPtr plugin, int player, float multiplier);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SetAllRandomPedsFlee(IntPtr plugin, int player, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SetAllRandomPedsFleeThisFrame(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SetAutoGiveParachuteWhenEnterPlane(IntPtr plugin, int player, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SetDisableAmbientMeleeMove(IntPtr plugin, int player, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SetDispatchCopsForPlayer(IntPtr plugin, int player, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SetEveryoneIgnorePlayer(IntPtr plugin, int player, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SetIgnoreLowPriorityShockingEvents(IntPtr plugin, int player, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SetMaxWantedLevel(IntPtr plugin, int maxWantedLevel);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SetPlayerCanBeHassledByGangs(IntPtr plugin, int player, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SetPlayerCanDoDriveBy(IntPtr plugin, int player, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SetPlayerCanLeaveParachuteSmokeTrail(IntPtr plugin, int player, bool enabled);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Player_SetPlayerCanUseCover(IntPtr plugin, int player, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SetPlayerClothLockCounter(IntPtr plugin, int value);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SetPlayerClothPackageIndex(IntPtr plugin, int index);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SetPlayerClothPinFrames(IntPtr plugin, int player, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SetPlayerControl(IntPtr plugin, int player, bool toggle, int flags);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SetPlayerForcedAim(IntPtr plugin, int player, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SetPlayerForcedZoom(IntPtr plugin, int player, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SetPlayerForceSkipAimIntro(IntPtr plugin, int player, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SetPlayerHasReserveParachute(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SetPlayerHealthRechargeMultiplier(IntPtr plugin, int player, float regenRate);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SetPlayerInvincible(IntPtr plugin, int player, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SetPlayerLockon(IntPtr plugin, int player, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SetPlayerLockonRangeOverride(IntPtr plugin, int player, float range);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SetPlayerMaxArmour(IntPtr plugin, int player, int value);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SetPlayerMayNotEnterAnyVehicle(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SetPlayerMayOnlyEnterThisVehicle(IntPtr plugin, int player, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SetPlayerMeleeWeaponDamageModifier(IntPtr plugin, int player, float modifier);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SetPlayerMeleeWeaponDefenseModifier(IntPtr plugin, int player, float modifier);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SetPlayerModel(IntPtr plugin, int player, ulong model);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SetPlayerNoiseMultiplier(IntPtr plugin, int player, float multiplier);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SetPlayerParachuteModelOverride(IntPtr plugin, int player, ulong model);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SetPlayerParachutePackModelOverride(IntPtr plugin, int player, ulong model);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SetPlayerParachutePackTintIndex(IntPtr plugin, int player, int tintIndex);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SetPlayerParachuteSmokeTrailColor(IntPtr plugin, int player, int r, int g, int b);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SetPlayerParachuteTintIndex(IntPtr plugin, int player, int tintIndex);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SetPlayerParachuteVariationOverride(IntPtr plugin, int player, int p1, ulong p2, ulong p3, bool p4);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SetPlayerReserveParachuteTintIndex(IntPtr plugin, int player, int index);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SetPlayerResetFlagPreferRearSeats(IntPtr plugin, int player, int flags);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SetPlayerSimulateAiming(IntPtr plugin, int player, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SetPlayerSneakingNoiseMultiplier(IntPtr plugin, int player, float multiplier);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SetPlayerSprint(IntPtr plugin, int player, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SetPlayerStealthPerceptionModifier(IntPtr plugin, int player, float value);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SetPlayerTargetingMode(IntPtr plugin, int targetMode);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SetPlayerTeam(IntPtr plugin, int player, int team);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SetPlayerVehicleDamageModifier(IntPtr plugin, int player, float damageAmount);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SetPlayerVehicleDefenseModifier(IntPtr plugin, int player, float modifier);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SetPlayerWantedCentrePosition(IntPtr plugin, int player, float x, float y, float z);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SetPlayerWantedLevel(IntPtr plugin, int player, int wantedLevel, bool disableNoMission);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SetPlayerWantedLevelNoDrop(IntPtr plugin, int player, int wantedLevel, bool p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SetPlayerWantedLevelNow(IntPtr plugin, int player, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SetPlayerWeaponDamageModifier(IntPtr plugin, int player, float damageAmount);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SetPoliceIgnorePlayer(IntPtr plugin, int player, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SetPoliceRadarBlips(IntPtr plugin, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SetRunSprintMultiplierForPlayer(IntPtr plugin, int player, float multiplier);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SetSpecialAbilityMultiplier(IntPtr plugin, float multiplier);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SetSwimMultiplierForPlayer(IntPtr plugin, int player, float multiplier);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SetWantedLevelDifficulty(IntPtr plugin, int player, float difficulty);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SetWantedLevelMultiplier(IntPtr plugin, float multiplier);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SimulatePlayerInputGait(IntPtr plugin, int control, float amount, int gaitType, float speed, bool p4, bool p5);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SpecialAbilityChargeAbsolute(IntPtr plugin, int player, int p1, bool p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SpecialAbilityChargeContinuous(IntPtr plugin, int player, int p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SpecialAbilityChargeLarge(IntPtr plugin, int player, bool p1, bool p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SpecialAbilityChargeMedium(IntPtr plugin, int player, bool p1, bool p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SpecialAbilityChargeNormalized(IntPtr plugin, int player, float normalizedValue, bool p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SpecialAbilityChargeSmall(IntPtr plugin, int player, bool p1, bool p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SpecialAbilityDeactivate(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SpecialAbilityDeactivateFast(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SpecialAbilityDepleteMeter(IntPtr plugin, int player, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SpecialAbilityFillMeter(IntPtr plugin, int player, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SpecialAbilityLock(IntPtr plugin, ulong playerModel);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SpecialAbilityReset(IntPtr plugin, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SpecialAbilityUnlock(IntPtr plugin, ulong playerModel);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_StartFiringAmnesty(IntPtr plugin, int duration);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_StartPlayerTeleport(IntPtr plugin, int player, float x, float y, float z, float heading, bool p5, bool p6, bool p7);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_StopPlayerTeleport(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Player_SwitchCrimeType(IntPtr plugin, int player, int p1);
    }
}
