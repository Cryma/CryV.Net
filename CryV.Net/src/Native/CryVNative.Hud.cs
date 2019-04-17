using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CryV.Net.Native
{
    internal static partial class CryVNative
    {
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_AbortTextChat(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_ActivateFrontendMenu(IntPtr plugin, ulong menuhash, bool Toggle_Pause, int component);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Hud_AddBlipForArea(IntPtr plugin, float x, float y, float z, float width, float height);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Hud_AddBlipForCoord(IntPtr plugin, float x, float y, float z);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Hud_AddBlipForEntity(IntPtr plugin, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Hud_AddBlipForPickup(IntPtr plugin, int pickup);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Hud_AddBlipForRadius(IntPtr plugin, float posX, float posY, float posZ, float radius);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_AddNextMessageToPreviousBriefs(IntPtr plugin, bool p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_AddTextComponentAppTitle(IntPtr plugin, IntPtr p0, int p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_AddTextComponentFloat(IntPtr plugin, float value, int decimalPlaces);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_AddTextComponentFormattedInteger(IntPtr plugin, int value, bool commaSeparated);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_AddTextComponentInteger(IntPtr plugin, int value);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_AddTextComponentScaleform(IntPtr plugin, IntPtr p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_AddTextComponentSubstringBlipName(IntPtr plugin, int blip);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_AddTextComponentSubstringPlayerName(IntPtr plugin, IntPtr text);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_AddTextComponentSubstringTextLabel(IntPtr plugin, IntPtr labelName);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_AddTextComponentSubstringTextLabelHashKey(IntPtr plugin, ulong gxtEntryHash);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_AddTextComponentSubstringTime(IntPtr plugin, int timestamp, int flags);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_AddTextComponentSubstringWebsite(IntPtr plugin, IntPtr website);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Hud_AddTrevorRandomModifier(IntPtr plugin, int gamerTagId);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_BeginTextCommandBusyString(IntPtr plugin, IntPtr @string);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_BeginTextCommandClearPrint(IntPtr plugin, IntPtr text);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_BeginTextCommandDisplayHelp(IntPtr plugin, IntPtr inputType);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_BeginTextCommandDisplayText(IntPtr plugin, IntPtr text);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_BeginTextCommandIsMessageDisplayed(IntPtr plugin, IntPtr text);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_BeginTextCommandIsThisHelpMessageBeingDisplayed(IntPtr plugin, IntPtr labelName);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_BeginTextCommandLineCount(IntPtr plugin, IntPtr entry);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_BeginTextCommandObjective(IntPtr plugin, IntPtr p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_BeginTextCommandPrint(IntPtr plugin, IntPtr GxtEntry);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_BeginTextCommandSetBlipName(IntPtr plugin, IntPtr textLabel);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_BeginTextCommandTimer(IntPtr plugin, IntPtr p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_BeginTextCommandWidth(IntPtr plugin, IntPtr text);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_BlockWeaponWheelThisFrame(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_CenterPlayerOnRadarThisFrame(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_ClearAdditionalText(IntPtr plugin, int p0, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_ClearAllHelpMessages(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_ClearBrief(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_ClearFloatingHelp(IntPtr plugin, ulong p0, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_ClearGpsFlags(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_ClearGpsPlayerWaypoint(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_ClearGpsRaceTrack(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_ClearHelp(IntPtr plugin, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_ClearNotificationsPos(IntPtr plugin, float pos);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_ClearPedInPauseMenu(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_ClearPrints(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_ClearReminderMessage(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_ClearSmallPrints(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_ClearThisPrint(IntPtr plugin, IntPtr p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Hud_CreateMpGamerTag(IntPtr plugin, int ped, IntPtr username, bool pointedClanTag, bool isRockstarClan, IntPtr clanTag, ulong p5);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Hud_DisableBlipNameForVar(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_DisableFrontendThisFrame(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_DisableRadarThisFrame(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_DisplayAmmoThisFrame(IntPtr plugin, bool display);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_DisplayAreaName(IntPtr plugin, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_DisplayCash(IntPtr plugin, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_DisplayHelpTextThisFrame(IntPtr plugin, IntPtr message, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_DisplayHud(IntPtr plugin, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_DisplayJobReport(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Hud_DisplayRadar(IntPtr plugin, bool Toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_DisplaySniperScopeThisFrame(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Hud_DoesBlipExist(IntPtr plugin, int blip);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Hud_DoesPedHaveAiBlip(IntPtr plugin, int ped);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Hud_DoesTextBlockExist(IntPtr plugin, IntPtr gxt);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Hud_DoesTextLabelExist(IntPtr plugin, IntPtr gxt);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Hud_DrawFrontendAlert(IntPtr plugin, IntPtr labelTitle, IntPtr labelMsg, int p2, int p3, IntPtr labelMsg2, int p5, int p6, int p7, IntPtr p8, IntPtr p9, bool background, ulong p11);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Hud_DrawNotification(IntPtr plugin, bool blink, bool showInBrief);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Hud_DrawNotificationApartmentInvite(IntPtr plugin, bool p0, bool p1, ref int p2, int p3, bool isLeader, bool unk0, int clanDesc, int R, int G, int B);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Hud_DrawNotificationAward(IntPtr plugin, IntPtr textureDict, IntPtr textureName, int rpBonus, int colorOverlay, IntPtr titleLabel);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Hud_DrawNotificationClanInvite(IntPtr plugin, bool p0, bool p1, ref int p2, int p3, bool isLeader, bool unk0, int clanDesc, IntPtr playerName, int R, int G, int B);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Hud_DrawNotificationWithButton(IntPtr plugin, int type, IntPtr button, IntPtr text);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Hud_DrawNotificationWithIcon(IntPtr plugin, int type, int image, IntPtr text);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Hud_DrawNotification2(IntPtr plugin, bool blink, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Hud_DrawNotification3(IntPtr plugin, bool blink, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Hud_DrawNotification4(IntPtr plugin, bool blink, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_EnableDeathbloodSeethrough(IntPtr plugin, bool p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_EndTextCommandBusyString(IntPtr plugin, int busySpinnerType);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_EndTextCommandClearPrint(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_EndTextCommandDisplayHelp(IntPtr plugin, ulong p0, bool loop, bool beep, int duration);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_EndTextCommandDisplayText(IntPtr plugin, float x, float y);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Hud_EndTextCommandGetWidth(IntPtr plugin, bool p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Hud_EndTextCommandIsMessageDisplayed(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Hud_EndTextCommandIsThisHelpMessageBeingDisplayed(IntPtr plugin, int p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_EndTextCommandObjective(IntPtr plugin, bool p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_EndTextCommandPrint(IntPtr plugin, int duration, bool drawImmediately);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_EndTextCommandSetBlipName(IntPtr plugin, int blip);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_EndTextCommandTimer(IntPtr plugin, bool p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_FlashAbilityBar(IntPtr plugin, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_FlashMinimapDisplay(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Hud_FlashWantedDisplay(IntPtr plugin, bool p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Hud_GetActiveWebsiteId(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Hud_GetAiBlip(IntPtr plugin, int ped);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Hud_GetBlipAlpha(IntPtr plugin, int blip);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Hud_GetBlipColour(IntPtr plugin, int blip);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Native_Hud_GetBlipCoords(IntPtr plugin, int blip);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Hud_GetBlipFromEntity(IntPtr plugin, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Hud_GetBlipHudColour(IntPtr plugin, int blip);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Native_Hud_GetBlipInfoIdCoord(IntPtr plugin, int blip);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Hud_GetBlipInfoIdDisplay(IntPtr plugin, int blip);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Hud_GetBlipInfoIdEntityIndex(IntPtr plugin, int blip);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Hud_GetBlipInfoIdIterator(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Hud_GetBlipInfoIdPickupIndex(IntPtr plugin, int blip);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Hud_GetBlipInfoIdType(IntPtr plugin, int blip);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Hud_GetBlipSprite(IntPtr plugin, int blip);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Hud_GetCurrentFrontendMenu(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Hud_GetCurrentNotification(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Hud_GetCurrentWebsiteId(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Hud_GetDefaultScriptRendertargetRenderId(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Hud_GetFirstBlipInfoId(IntPtr plugin, int blipSprite);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_GetHudColour(IntPtr plugin, int hudColorIndex, ref int r, ref int g, ref int b, ref int a);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Native_Hud_GetHudComponentPosition(IntPtr plugin, int id);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Native_Hud_GetLabelText(IntPtr plugin, IntPtr labelName);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Hud_GetLengthOfLiteralString(IntPtr plugin, IntPtr @string);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Hud_GetLengthOfString(IntPtr plugin, IntPtr STRING);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Hud_GetLengthOfStringWithThisTextLabel(IntPtr plugin, IntPtr gxt);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Hud_GetMainPlayerBlipId(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Hud_GetNamedRendertargetRenderId(IntPtr plugin, IntPtr p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Hud_GetNextBlipInfoId(IntPtr plugin, int blipSprite);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Hud_GetNumberOfActiveBlips(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Hud_GetPauseMenuState(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Hud_GetScreenCoordFromWorldCoord(IntPtr plugin, float worldX, float worldY, float worldZ, ref float screenX, ref float screenY);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Native_Hud_GetStreetNameFromHashKey(IntPtr plugin, ulong hash);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Hud_GetTextScaleHeight(IntPtr plugin, float size, int font);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Hud_GetTextScreenLineCount(IntPtr plugin, float x, float y);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Native_Hud_GetTextSubstring(IntPtr plugin, IntPtr text, int position, int length);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Native_Hud_GetTextSubstringSafe(IntPtr plugin, IntPtr text, int position, int length, int maxLength);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Native_Hud_GetTextSubstringSlice(IntPtr plugin, IntPtr text, int startPosition, int endPosition);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_GivePedToPauseMenu(IntPtr plugin, int ped, int p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Hud_HasAdditionalTextLoaded(IntPtr plugin, int slot);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Hud_HasMpGamerTag(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Hud_HasMpGamerTag2(IntPtr plugin, int gamerTagId);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Hud_HasThisAdditionalTextLoaded(IntPtr plugin, IntPtr gxt, int slot);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_HideHelpTextThisFrame(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_HideHudAndRadarThisFrame(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_HideHudComponentThisFrame(IntPtr plugin, int id);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_HideLoadingOnFadeThisFrame(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_HideNumberOnBlip(IntPtr plugin, int blip);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_HideScriptedHudComponentThisFrame(IntPtr plugin, int id);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_HideSpecialAbilityLockonOperation(IntPtr plugin, ulong p0, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_IsAiBlipAlwaysShown(IntPtr plugin, int ped, bool flag);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Hud_IsBlipFlashing(IntPtr plugin, int blip);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Hud_IsBlipOnMinimap(IntPtr plugin, int blip);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Hud_IsBlipShortRange(IntPtr plugin, int blip);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Hud_IsHelpMessageBeingDisplayed(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Hud_IsHelpMessageFadingOut(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Hud_IsHelpMessageOnScreen(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Hud_IsHudComponentActive(IntPtr plugin, int id);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Hud_IsHudHidden(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Hud_IsHudPreferenceSwitchedOn(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Hud_IsLoadingPromptBeingDisplayed(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Hud_IsMessageBeingDisplayed(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Hud_IsMinimapAreaRevealed(IntPtr plugin, float x, float y, float radius);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Hud_IsMissionCreatorBlip(IntPtr plugin, int blip);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Hud_IsMpGamerTagActive(IntPtr plugin, int gamerTagId);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Hud_IsNamedRendertargetLinked(IntPtr plugin, ulong hash);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Hud_IsNamedRendertargetRegistered(IntPtr plugin, IntPtr p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Hud_IsPauseMenuActive(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Hud_IsPauseMenuRestarting(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Hud_IsRadarEnabled(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Hud_IsRadarHidden(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Hud_IsRadarPreferenceSwitchedOn(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Hud_IsScriptedHudComponentActive(IntPtr plugin, int id);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Hud_IsSocialClubActive(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Hud_IsStreamingAdditionalText(IntPtr plugin, int p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Hud_IsSubtitlePreferenceSwitchedOn(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Hud_IsTextChatActive(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Hud_IsWarningMessageActive(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Hud_IsWaypointActive(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_KeyHudColour(IntPtr plugin, bool p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_LinkNamedRendertarget(IntPtr plugin, ulong hash);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_LockMinimapAngle(IntPtr plugin, int angle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_LockMinimapPosition(IntPtr plugin, float x, float y);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_LogDebugInfo(IntPtr plugin, IntPtr p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x04655F9D075D0AE5(IntPtr plugin, bool p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Hud__0x052991E59076E4E4(IntPtr plugin, ulong p0, ref ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x06A320535F5F0248(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x0923DBF87DFF735E(IntPtr plugin, float x, float y, float z);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Hud__0x09C0403ED9A751C2(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Hud__0x0C5A80A9E096D529(IntPtr plugin, ulong p0, ref ulong p1, ulong p2, ulong p3, ulong p4, ulong p5);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x0CF54F20DE43879C(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Hud__0x1121BFA1A1A522A8(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x1185A8087587322C(IntPtr plugin, bool p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Hud__0x13C4B962653A5280(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x14621BB1DF14E2B2(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x14C9FDCC41F81F63(IntPtr plugin, bool p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x15CFA549788D35EF(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x16A304E6CB2BFAB9(IntPtr plugin, int r, int g, int b, int a);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x170F541E1CADD1DE(IntPtr plugin, bool p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x17AD8C9706BDD88A(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x1EAC5F91BCBC5073(IntPtr plugin, bool p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x1EAE6DD17B7A5EFA(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x20FE7FDFEEAD38C0(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x211C4EF450086857(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Hud__0x214CD562A939246A(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Hud__0x2432784ACA090DA4(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Hud__0x24A49BEAF468DC90(IntPtr plugin, ulong p0, ref ulong p1, ulong p2, ulong p3, ulong p4);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x25615540D894B814(IntPtr plugin, ulong p0, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x25F87B30C382FCA7(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x2632482FD6B9AB87(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x2708FC083123F9FF(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x2790F4B17D098E26(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x2916A928514C9827(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Hud__0x2A25ADC48F87841F(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Hud__0x2C173AE2BDB9385E(IntPtr plugin, int blip);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x2C9F302398E13141(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x2DE6C5E2E996F178(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Hud__0x2E22FEFA0100275E(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Hud__0x2F057596F2BD0061(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x311438A071DD9B1A(IntPtr plugin, ulong p0, ulong p1, ulong p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x317EBA71D7543F52(IntPtr plugin, ref ulong p0, ref ulong p1, ref ulong p2, ref ulong p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x32888337579A5970(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Hud__0x33EE12743CCD6343(IntPtr plugin, ulong p0, ulong p1, ulong p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Hud__0x359AF31A4B52F5ED(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x35EDD5B2E3FF01C0(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x36C1451A88A09630(IntPtr plugin, ref ulong p0, ref ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Hud__0x3BAB9A4E4F2FF5C7(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x3D3D15AF7BCAAF83(IntPtr plugin, ulong p0, bool p1, bool p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Hud__0x3D9ACB1EB139E702(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x3DDA37128DD1ACA8(IntPtr plugin, bool p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Hud__0x3F0CF9CB7E589B88(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x3F5CC444DCAAA8F2(IntPtr plugin, ulong p0, ulong p1, bool p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x402F9ED62087E898(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x41350B4FC28E3941(IntPtr plugin, bool p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Hud__0x4167EFE0527D706E(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x488043841BBE156F(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x4A0C7C9BB10ABB36(IntPtr plugin, bool p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Hud__0x4A9923385BDB9DAD(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x4B5B620C9B59ED34(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Hud__0x4E3CD0EF8A489541(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x54318C915D27E4CE(IntPtr plugin, ulong p0, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Hud__0x551DF99658DB6EE8(IntPtr plugin, float p0, float p1, float p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x56C8B608CFD49854(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x577599CCED639CA2(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x57D760D55F54E071(IntPtr plugin, bool p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x583049884A2EEE3C(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Hud__0x593FEAE1F73392D4(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Native_Hud__0x5BFF36D6ED83E0AE(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Hud__0x5FBD7095FE7AE57F(IntPtr plugin, ulong p0, ref float p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x60734CC207C9833C(IntPtr plugin, bool p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x60E892BA4F5BDCA4(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x62E849B7EB28E770(IntPtr plugin, bool p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Hud__0x632B2940C67F4EA9(IntPtr plugin, int scaleformHandle, ref ulong p1, ref ulong p2, ref ulong p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Hud__0x66E7CB63C97B7D20(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x67EEDEA1B9BAFD94(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x6A1738B4323FE2D9(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x6B1DE27EE78E6A19(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x6CDD58146A436083(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x6EF54AB721DC6242(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x6F1554B0CC2089FA(IntPtr plugin, bool p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Hud__0x6F72CD94F7B5B68C(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x72C1056D678BB7D8(IntPtr plugin, ulong weaponHash);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x72DD432F3CDFC0EE(IntPtr plugin, float posX, float posY, float posZ, float radius, int p4);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x75A16C3DA34F1245(IntPtr plugin, int blip, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x75D3691713C3B05A(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x7669F9E39DC17063(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x7679CC1BCEBE3D4C(IntPtr plugin, ulong p0, float p1, float p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x7792424AA0EAC32E(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x77F16B447824DA6C(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x784BA7E0ECEB4178(IntPtr plugin, ulong p0, float x, float y, float z);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x788E7FD431BD67F1(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4, ulong p5);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Hud__0x7AE0589093A2E088(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4, ulong p5);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x7B21E0BB01E8224A(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x7C226D5346D4D10A(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x7CD934010E115C2C(IntPtr plugin, int ped);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x7E17BE53E1AAABAF(IntPtr plugin, ref int p0, ref int p1, ref int p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Hud__0x801879A9B4F4B2FB(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x80FE4F3AB4E1B62A(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x817B86108EB94E51(IntPtr plugin, bool p0, ref ulong p1, ref ulong p2, ref ulong p3, ref ulong p4, ref ulong p5, ref ulong p6, ref ulong p7, ref ulong p8);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x82CEDC33687E1F50(IntPtr plugin, bool p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Hud__0x84698AB38D0C6636(IntPtr plugin, ulong hash);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x8817605C2BA76200(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Hud__0x8EFCCF6EC66D85E4(IntPtr plugin, ref ulong p0, ref ulong p1, ref ulong p2, bool p3, bool p4);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Hud__0x8F08017F9D7C47BD(IntPtr plugin, ulong p0, ref ulong p1, ulong p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x900086F371220B6F(IntPtr plugin, bool p0, ulong p1, ulong p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Hud__0x9049FE339D5F6F6F(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Hud__0x90A6526CF0381030(IntPtr plugin, ulong p0, ref ulong p1, ulong p2, ulong p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Hud__0x9135584D09A3437E(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x9245E81072704B8A(IntPtr plugin, bool p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x95CF81BD06EE1887(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x975D66A0BC17064C(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x98215325A695E78A(IntPtr plugin, bool p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Hud__0x98C3CF913D895111(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x9C16459B2324B2CF(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0x9E778248D6685FE0(IntPtr plugin, IntPtr p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0xA13C11E1B5C06BFC(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Hud__0xA13E93403F26C812(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0xA17784FCA9548D15(IntPtr plugin, ulong p0, ulong p1, ulong p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Hud__0xA238192F33110615(IntPtr plugin, ref int p0, ref int p1, ref int p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Hud__0xA277800A9EAE340E(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Hud__0xA48931185F0536FE(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0xA4DEDE28B1814289(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0xA8B6AFDAC320AC87(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0xA8FDB297A8D25FBA(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0xA905192A6781C41B(IntPtr plugin, float x, float y, float z);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Hud__0xA9CBFD40B3FA3010(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0xADED7F5748ACAFE6(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Hud__0xAF42195A42C63BBA(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0xB094BC1DB4018240(IntPtr plugin, ulong p0, ulong p1, float p2, float p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0xB13DCB4C6FAAD238(IntPtr plugin, int ped, bool toggle, ulong p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Hud__0xB2A592B04648A9CB(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0xB552929B85FC27EC(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Hud__0xB6871B0555B02996(IntPtr plugin, ref ulong p0, ref ulong p1, ulong p2, ref ulong p3, ref ulong p4, ulong p5);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0xB695E2CD0A2DA9EE(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0xB99C4E4D9499DF29(IntPtr plugin, bool p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0xB9C362BABECDDC7A(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0xBA751764F0821256(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0xBA8D65C1C65702E5(IntPtr plugin, bool p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0xBAE4F9B97CD43B30(IntPtr plugin, bool p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0xBF4F34A85CA2970C(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0xC2D15BEF167E27BC(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Hud__0xC2D2AD9EAAE265B8(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0xC4278F70131BAA6D(IntPtr plugin, int p0, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0xC594B315EDF2D4AF(IntPtr plugin, int ped);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0xC65AB383CD91DF98(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0xC78E239AC5B2DDB9(IntPtr plugin, bool p0, ulong p1, ulong p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Hud__0xC8E1071177A23BE5(IntPtr plugin, ref ulong p0, ref ulong p1, ref ulong p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Hud__0xC8F3AAF93D0600BF(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Hud__0xCA6B2F7CE32AB653(IntPtr plugin, ulong p0, ref ulong p1, ulong p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0xCC3FDDED67BCFC63(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0xCD74233600C4EA6B(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0xCDCA26E80FAECB8F(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0xCEF214315D276FD1(IntPtr plugin, bool p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0xD12882D3FF82BF11(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0xD1942374085C8469(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0xD2049635DEB9C375(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0xD2B32BE3FC1626C6(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0xD4438C0564490E63(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0xD68A5FF8A3A89874(IntPtr plugin, int r, int g, int b, int a);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0xD8E694757BCEA8E9(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Hud__0xDAF87174BE7454FF(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0xDB34E8D56FC13B08(IntPtr plugin, ulong p0, bool p1, bool p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Hud__0xDD2238F57B977751(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Hud__0xDE03620F8703A9DF(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Hud__0xE0130B41D3CF4574(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0xE1CD1E48E025E661(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Hud__0xE3B05614DCE1D014(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0xE67C6DFD386EA5E7(IntPtr plugin, bool p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0xE6DE0561D9232A64(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0xEC9264727EEC0F28(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0xEE4C0E6DBC6F2C6F(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0xF06EBB91A81E09E3(IntPtr plugin, bool p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Hud__0xF13FE2A80C05C561(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0xF1A6C18B35BCADE6(IntPtr plugin, bool p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Hud__0xF284AC67940C6812(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0xF47E567B3630DD12(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0xF98E4B3E56AFC7B1(IntPtr plugin, ulong p0, float p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0xFCFACD0DB9D7A57D(IntPtr plugin, int ped, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0xFDB423997FA30340(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0xFDD85225B2DEA55E(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud__0xFDEC055AB549E328(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_ObjectDecalToggle(IntPtr plugin, ulong hash);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_PauseMenuActivateContext(IntPtr plugin, ulong hash);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_PulseBlip(IntPtr plugin, int blip);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_RefreshWaypoint(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Hud_RegisterNamedRendertarget(IntPtr plugin, IntPtr p0, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Hud_ReleaseNamedRendertarget(IntPtr plugin, ref ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_RemoveBlip(IntPtr plugin, ref int blip);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_RemoveLoadingPrompt(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_RemoveMpGamerTag(IntPtr plugin, int gamerTagId);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_RemoveMultiplayerBankCash(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_RemoveMultiplayerHudCash(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_RemoveNotification(IntPtr plugin, int notificationId);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_RequestAdditionalText(IntPtr plugin, IntPtr gxt, int slot);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_RequestAdditionalText2(IntPtr plugin, IntPtr gxt, int slot);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_ResetHudComponentValues(IntPtr plugin, int id);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_ResetReticuleValues(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_RespondingAsTemp(IntPtr plugin, float p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_RestartFrontendMenu(IntPtr plugin, ulong menuHash, int p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetAbilityBarValue(IntPtr plugin, float value, float maxValue);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetAiBlipMaxDistance(IntPtr plugin, int ped, float distance);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetAiBlipType(IntPtr plugin, int ped, int type);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetBigmapActive(IntPtr plugin, bool toggleBigMap, bool showFullMap);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetBlipAlpha(IntPtr plugin, int blip, int alpha);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetBlipAsFriendly(IntPtr plugin, int blip, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetBlipAsMissionCreatorBlip(IntPtr plugin, int blip, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetBlipAsShortRange(IntPtr plugin, int blip, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetBlipBright(IntPtr plugin, int blip, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetBlipCategory(IntPtr plugin, int blip, int index);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetBlipColour(IntPtr plugin, int blip, int color);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetBlipCoords(IntPtr plugin, int blip, float posX, float posY, float posZ);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetBlipDisplay(IntPtr plugin, int blip, int displayId);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetBlipFade(IntPtr plugin, int blip, int opacity, int duration);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetBlipFlashes(IntPtr plugin, int blip, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetBlipFlashesAlternate(IntPtr plugin, int blip, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetBlipFlashInterval(IntPtr plugin, int blip, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetBlipFlashTimer(IntPtr plugin, int blip, int duration);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetBlipHighDetail(IntPtr plugin, int blip, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetBlipNameFromTextFile(IntPtr plugin, int blip, IntPtr gxtEntry);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetBlipNameToPlayerName(IntPtr plugin, int blip, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetBlipPriority(IntPtr plugin, int blip, int priority);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetBlipRotation(IntPtr plugin, int blip, int rotation);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetBlipRoute(IntPtr plugin, int blip, bool enabled);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetBlipRouteColour(IntPtr plugin, int blip, int colour);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetBlipScale(IntPtr plugin, int blip, float scale);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetBlipSecondaryColour(IntPtr plugin, int blip, float r, float g, float b);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetBlipShowCone(IntPtr plugin, int blip, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetBlipShrink(IntPtr plugin, int blip, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetBlipSprite(IntPtr plugin, int blip, int spriteId);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetCursorSprite(IntPtr plugin, int spriteId);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetDirectorMode(IntPtr plugin, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetFrontendActive(IntPtr plugin, bool active);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetGpsFlags(IntPtr plugin, int p0, float p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetGpsFlashes(IntPtr plugin, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetHudColour(IntPtr plugin, int hudColorIndex, int r, int g, int b, int a);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetHudColoursSwitch(IntPtr plugin, int hudColorIndex, int hudColorIndex2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetHudComponentPosition(IntPtr plugin, int id, float x, float y);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetMapFullScreen(IntPtr plugin, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetMinimapAttitudeIndicatorLevel(IntPtr plugin, float altitude, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetMinimapBlockWaypoint(IntPtr plugin, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Hud_SetMinimapComponent(IntPtr plugin, int componentID, bool toggle, int p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetMinimapGolfCourse(IntPtr plugin, int hole);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetMinimapRevealed(IntPtr plugin, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetMissionName(IntPtr plugin, bool p0, IntPtr name);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetMissionName2(IntPtr plugin, bool p0, IntPtr name);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetMpGamerTagAlpha(IntPtr plugin, int gamerTagId, int component, int alpha);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetMpGamerTagChatting(IntPtr plugin, int gamerTagId, IntPtr @string);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetMpGamerTagColor(IntPtr plugin, int headDisplayId, IntPtr username, bool pointedClanTag, bool isRockstarClan, IntPtr clanTag, ulong p5, int r, int g, int b);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetMpGamerTagColour(IntPtr plugin, int gamerTagId, int flag, int color);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetMpGamerTagHealthBarColour(IntPtr plugin, int headDisplayId, int color);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetMpGamerTagIcons(IntPtr plugin, int headDisplayId, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetMpGamerTagName(IntPtr plugin, int gamerTagId, IntPtr @string);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetMpGamerTagVisibility(IntPtr plugin, int gamerTagId, int component, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetMpGamerTagWantedLevel(IntPtr plugin, int gamerTagId, int wantedlvl);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetMpGamerTag(IntPtr plugin, int headDisplayId, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetMultiplayerBankCash(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetMultiplayerHudCash(IntPtr plugin, int p0, int p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetNewWaypoint(IntPtr plugin, float x, float y);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetNorthYanktonMap(IntPtr plugin, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetNotificationBackgroundColor(IntPtr plugin, int hudIndex);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetNotificationColorNext(IntPtr plugin, int hudIndex);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetNotificationFlashColor(IntPtr plugin, int red, int green, int blue, int alpha);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Hud_SetNotificationMessage(IntPtr plugin, IntPtr textureDict, IntPtr textureName, bool flash, int iconType, IntPtr sender, IntPtr subject);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Hud_SetNotificationMessageClanTag(IntPtr plugin, IntPtr picName1, IntPtr picName2, bool flash, int iconType, IntPtr sender, IntPtr subject, float duration, IntPtr clanTag);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Hud_SetNotificationMessageClanTag2(IntPtr plugin, IntPtr picName1, IntPtr picName2, bool flash, int iconType1, IntPtr sender, IntPtr subject, float duration, IntPtr clanTag, int iconType2, int p9);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Hud_SetNotificationMessage2(IntPtr plugin, IntPtr picName1, int picName2, bool flash, int iconType, bool p4, IntPtr sender, IntPtr subject);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Hud_SetNotificationMessage3(IntPtr plugin, IntPtr picName1, IntPtr picName2, bool p2, ulong p3, IntPtr p4, IntPtr p5);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Hud_SetNotificationMessage4(IntPtr plugin, IntPtr picName1, IntPtr picName2, bool flash, int iconType, IntPtr sender, IntPtr subject, float duration);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetNotificationTextEntry(IntPtr plugin, IntPtr text);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetPauseMenuActive(IntPtr plugin, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetPauseMenuPedLighting(IntPtr plugin, bool state);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetPauseMenuPedSleepState(IntPtr plugin, bool state);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetPedAiBlip(IntPtr plugin, int pedHandle, bool showViewCones);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetPlayerBlipPositionThisFrame(IntPtr plugin, float x, float y);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetPlayerCashChange(IntPtr plugin, int cash, int bank);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetRadarAsExteriorThisFrame(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetRadarAsInteriorThisFrame(IntPtr plugin, ulong interior, float x, float y, int heading, int zoom);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetRadarZoom(IntPtr plugin, int zoomLevel);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetRadarZoomLevelThisFrame(IntPtr plugin, float zoomLevel);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetTextCentre(IntPtr plugin, bool align);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetTextChatUnk(IntPtr plugin, bool p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetTextColour(IntPtr plugin, int red, int green, int blue, int alpha);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetTextDropShadow(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetTextDropshadow(IntPtr plugin, int distance, int r, int g, int b, int a);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetTextEdge(IntPtr plugin, int p0, int r, int g, int b, int a);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetTextFont(IntPtr plugin, int fontType);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetTextJustification(IntPtr plugin, int justifyType);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetTextLeading(IntPtr plugin, bool p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetTextOutline(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetTextProportional(IntPtr plugin, bool p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetTextRenderId(IntPtr plugin, int renderId);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetTextRightJustify(IntPtr plugin, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetTextScale(IntPtr plugin, float scale, float size);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetTextWrap(IntPtr plugin, float start, float end);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Hud_SetUseridsUihidden(IntPtr plugin, ulong p0, ref ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetWarningMessage(IntPtr plugin, IntPtr entryLine1, int instructionalKey, IntPtr entryLine2, bool p3, ulong p4, ref ulong background, ref ulong p6, bool p7, ulong p8);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetWarningMessageWithHeader(IntPtr plugin, IntPtr entryHeader, IntPtr entryLine1, int instructionalKey, IntPtr entryLine2, bool p4, ulong p5, bool background, ref ulong p7, bool p8);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetWarningMessage3(IntPtr plugin, IntPtr entryHeader, IntPtr entryLine1, ulong instructionalKey, IntPtr entryLine2, bool p4, ulong p5, ulong p6, ref ulong p7, ref ulong p8, bool p9);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetWaypointOff(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_SetWidescreenFormat(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_ShowCrewIndicatorOnBlip(IntPtr plugin, int blip, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_ShowCursorThisFrame(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_ShowFriendIndicatorOnBlip(IntPtr plugin, int blip, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_ShowHeadingIndicatorOnBlip(IntPtr plugin, int blip, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_ShowHudComponentThisFrame(IntPtr plugin, int id);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_ShowNumberOnBlip(IntPtr plugin, int blip, int number);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_ShowOutlineIndicatorOnBlip(IntPtr plugin, int blip, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_ShowSocialClubLegalScreen(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_ShowTickOnBlip(IntPtr plugin, int blip, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_ShowWeaponWheel(IntPtr plugin, bool forcedShow);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_ToggleStealthRadar(IntPtr plugin, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_UnlockMinimapAngle(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Hud_UnlockMinimapPosition(IntPtr plugin);
    }
}
