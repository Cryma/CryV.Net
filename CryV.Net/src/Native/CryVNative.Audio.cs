using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CryV.Net.Native
{
    internal static partial class CryVNative
    {
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_AddLineToConversation(IntPtr plugin, int p0, IntPtr p1, IntPtr p2, int p3, int p4, bool p5, bool p6, bool p7, bool p8, int p9, bool p10, bool p11, bool p12);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_AddPedToConversation(IntPtr plugin, ulong p0, ulong ped, IntPtr p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Audio_AudioIsScriptedMusicPlaying(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_BlipSiren(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Audio_CancelMusicEvent(IntPtr plugin, IntPtr eventName);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Audio_CanPedSpeak(IntPtr plugin, int ped, IntPtr speechName, bool unk);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_ClearAllBrokenGlass(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_ClearAmbientZoneListState(IntPtr plugin, ref ulong p0, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_ClearAmbientZoneState(IntPtr plugin, IntPtr zoneName, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_CreateNewScriptedConversation(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_DisablePedPainAudio(IntPtr plugin, int ped, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_DisablePoliceReports(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_DynamicMixerRelatedFn(IntPtr plugin, int p0, IntPtr p1, float p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Audio_FindRadioStationIndex(IntPtr plugin, int station);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_ForceAmbientSiren(IntPtr plugin, bool value);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_ForceVehicleEngineAudio(IntPtr plugin, int vehicle, IntPtr audioName);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_FreezeRadioStation(IntPtr plugin, IntPtr radioStation);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Audio_GetAudibleMusicTrackTextId(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Audio_GetCurrentScriptedConversationLine(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Audio_GetMusicPlaytime(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Audio_GetNetworkIdFromSoundId(IntPtr plugin, int soundId);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Audio_GetNumberOfPassengerVoiceVariations(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_GetPlayerHeadsetSoundAlternate(IntPtr plugin, IntPtr p0, float p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Audio_GetPlayerRadioStationGenre(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Audio_GetPlayerRadioStationIndex(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Native_Audio_GetPlayerRadioStationName(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Native_Audio_GetRadioStationName(IntPtr plugin, int radioStation);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Audio_GetSoundId(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Audio_GetSoundIdFromNetworkId(IntPtr plugin, int netId);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Audio_GetStreamPlayTime(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Audio_GetVehicleDefaultHorn(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Audio_GetVehicleHornHash(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Audio_HasSoundFinished(IntPtr plugin, int soundId);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Audio_HintAmbientAudioBank(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Audio_HintScriptAudioBank(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_InterruptConversation(IntPtr plugin, ulong p0, ref ulong p1, ref ulong p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Audio_IsAlarmPlaying(IntPtr plugin, IntPtr alarmName);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Audio_IsAmbientSpeechDisabled(IntPtr plugin, int ped);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Audio_IsAmbientSpeechPlaying(IntPtr plugin, int p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Audio_IsAmbientZoneEnabled(IntPtr plugin, IntPtr ambientZone);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Audio_IsAnySpeechPlaying(IntPtr plugin, int ped);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Audio_IsAudioSceneActive(IntPtr plugin, IntPtr scene);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Audio_IsGameInControlOfMusic(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Audio_IsHornActive(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Audio_IsMissionCompletePlaying(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Audio_IsMobilePhoneCallOngoing(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Audio_IsMobilePhoneRadioActive(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Audio_IsPedInCurrentConversation(IntPtr plugin, int ped);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Audio_IsPedRingtonePlaying(IntPtr plugin, int ped);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Audio_IsPlayerVehicleRadioEnabled(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Audio_IsRadioRetuning(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Audio_IsScriptedConversationLoaded(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Audio_IsScriptedConversationOngoing(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Audio_IsScriptedSpeechPlaying(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Audio_IsStreamPlaying(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Audio_IsVehicleRadioLoud(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Audio_LoadStream(IntPtr plugin, IntPtr streamName, IntPtr soundSet);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Audio_LoadStreamWithStartOffset(IntPtr plugin, IntPtr streamName, int startOffset, IntPtr soundSet);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Audio_MaxRadioStationIndex(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0x0150B6FF25A9E2E5(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0x01BB4D577D38BD9E(IntPtr plugin, ulong p0, float p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0x02E93C796ABD3A97(IntPtr plugin, bool p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0x031ACB6ABA18C729(IntPtr plugin, IntPtr radioStation, IntPtr p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0x044DBAD7A7FA2BE5(IntPtr plugin, IntPtr p0, IntPtr p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Audio__0x0626A247D2405330(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0x062D5EAD4DA2FA6A(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0x06C0023BED16DD6B(IntPtr plugin, ulong p0, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0x0B568201DD99F0EB(IntPtr plugin, bool p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Audio__0x0BE4BE946463F917(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Audio__0x109697E2FFBAC8A1(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0x11579D940949C49E(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0x12561FCBB62D5B9C(IntPtr plugin, int p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0x149AEE66F0CB3A99(IntPtr plugin, float p0, float p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0x159B7318403A1CD8(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0x1654F24A88A8E3FE(IntPtr plugin, IntPtr radioStation);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0x18EB48CFC41F2EA0(IntPtr plugin, ulong p0, float p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0x19AF7ED9B9D23058(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0x1B7ABE26CBCBF8C7(IntPtr plugin, ulong p0, ulong p1, ulong p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0x1C073274E065C6D2(IntPtr plugin, ulong p0, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0x2BE4BC731D039D5A(IntPtr plugin, ulong p0, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0x2C96CDB04FCA358E(IntPtr plugin, float p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0x33E3C6C6F2F0B506(IntPtr plugin, ulong p0, float p1, float p2, float p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Audio__0x3A48AB4445D499BE(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Audio__0x3D120012440E6683(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Audio__0x40763EA7B9B783E7(IntPtr plugin, ulong p0, ulong p1, ulong p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0x43FA0DFC5DF87815(IntPtr plugin, int vehicle, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0x4E404A9361F75BB2(IntPtr plugin, IntPtr radioStation, IntPtr p1, bool p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Audio__0x544810ED9DB6BBE6(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0x58BB377BEC7CD5F4(IntPtr plugin, bool p0, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0x59E7B488451F4D3A(IntPtr plugin, ulong p0, float p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Audio__0x5B50ABB1FE3746F4(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0x5B9853296731E88D(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4, ulong p5);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0x5D2BFAAB8D956E0E(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Audio__0x5DB8010EE71FDEF2(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Audio__0x5E203DA2BA15D436(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0x61631F5DF50D1C34(IntPtr plugin, bool p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0x651D3228960D08AF(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Audio__0x6F259F82D873B8B8(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0x6FDDAD856E36988A(IntPtr plugin, ulong p0, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0x70B8EC8FC108A634(IntPtr plugin, bool p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0x733ADF241531E5C2(IntPtr plugin, IntPtr name, float p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0x75773E11BA459E90(IntPtr plugin, ulong p0, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0x774BD811F656A122(IntPtr plugin, IntPtr radioStation, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0x7CDC8C3B89F661B3(IntPtr plugin, int playerPed, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0x7EC3C679D0E7E46B(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0x806058BBDC136E06(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0x892B6AB8F33606F5(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0x8A694D7A68F8DC38(IntPtr plugin, int p0, IntPtr p1, IntPtr p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0x8BF907833BE275DE(IntPtr plugin, float p0, float p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0x9A53DED9921DE990(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0x9AC92EED5E4793AB(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0x9D3AF56E94C9AE98(IntPtr plugin, ulong p0, float p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Audio__0xA097AB275061FB21(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0xA5342D390CDA41D6(IntPtr plugin, ulong p0, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0xA5F377B175A699C5(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Audio__0xAA19F5572C38B564(IntPtr plugin, ref ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0xB4BBFD9CD8B3922B(IntPtr plugin, IntPtr p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0xB542DE8C3D1CB210(IntPtr plugin, bool p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0xB81CF134AEB56FFB(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0xBEF34B1D9624D5DD(IntPtr plugin, bool p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0xBF4DC1784BE94DFA(IntPtr plugin, ulong p0, bool p1, ulong p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0xC15907D667F7CFB2(IntPtr plugin, int vehicle, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0xC1805D05E6D4FE10(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Audio__0xC265DF9FB44A9FBD(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Audio__0xC8B1B2425604CDD0(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0xC8EDE9BDBCCBA6D4(IntPtr plugin, ref ulong p0, float p1, float p2, float p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0xCADA5A0D0702381E(IntPtr plugin, IntPtr p0, IntPtr soundset);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0xD01005D2BA2EB778(IntPtr plugin, IntPtr p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0xD2CC78CD3D0B50F9(IntPtr plugin, ulong p0, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0xD2DCCD8E16E20997(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0xD57AAAE0E2214D11(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0xDA07819E452FFE8F(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0xDD6BCF9E94425DF9(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0xDDC635D5B3262C56(IntPtr plugin, IntPtr p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0xE4E6DD5566D28C82(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Audio__0xE73364DB90778FFA(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0xEE066C7006C49C0A(IntPtr plugin, ulong p0, ulong p1, ref ulong p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0xF154B8D1775B2DEC(IntPtr plugin, bool p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0xF1F8157B8C3F171C(IntPtr plugin, ulong p0, IntPtr p1, IntPtr p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0xF3365489E0DD50F9(IntPtr plugin, ulong p0, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0xFBE20329593DEC9D(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio__0xFF266D1D0EB1195D(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_OverrideTrevorRage(IntPtr plugin, ref ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_OverrideUnderwaterStream(IntPtr plugin, ref ulong p0, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_OverrideVehHorn(IntPtr plugin, int vehicle, bool @override, int hornHash);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_PauseScriptedConversation(IntPtr plugin, bool p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_PlayAmbientSpeech1(IntPtr plugin, int ped, IntPtr speechName, IntPtr speechParam);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_PlayAmbientSpeech2(IntPtr plugin, int ped, IntPtr speechName, IntPtr speechParam);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_PlayAmbientSpeechAtCoords(IntPtr plugin, IntPtr p0, IntPtr p1, float p2, float p3, float p4, IntPtr p5);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_PlayAmbientSpeechWithVoice(IntPtr plugin, int p0, IntPtr speechName, IntPtr voiceName, IntPtr speechParam, bool p4);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_PlayEndCreditsMusic(IntPtr plugin, bool play);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_PlayMissionCompleteAudio(IntPtr plugin, IntPtr audioName);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_PlayPain(IntPtr plugin, int ped, int painID, int p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_PlayPedRingtone(IntPtr plugin, IntPtr ringtoneName, int ped, bool p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Audio_PlayPoliceReport(IntPtr plugin, IntPtr name, float p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_PlaySoundFromCoord(IntPtr plugin, int soundId, IntPtr audioName, float x, float y, float z, IntPtr audioRef, bool p6, int range, bool p8);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_PlaySoundFromEntity(IntPtr plugin, int soundId, IntPtr audioName, int entity, IntPtr audioRef, bool p4, ulong p5);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_PlaySoundFrontend(IntPtr plugin, int soundId, IntPtr audioName, IntPtr audioRef, bool p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_PlayStreamFromObject(IntPtr plugin, int @object);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_PlayStreamFromPed(IntPtr plugin, int ped);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_PlayStreamFromVehicle(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_PlayStreamFrontend(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Audio_PlaySynchronizedAudioEvent(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_PlayVehicleDoorCloseSound(IntPtr plugin, int vehicle, int p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_PlayVehicleDoorOpenSound(IntPtr plugin, int vehicle, int p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_PreloadScriptConversation(IntPtr plugin, bool p0, bool p1, bool p2, bool p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_PreloadScriptPhoneConversation(IntPtr plugin, bool p0, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Audio_PrepareAlarm(IntPtr plugin, IntPtr alarmName);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Audio_PrepareMusicEvent(IntPtr plugin, IntPtr eventName);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Audio_PrepareSynchronizedAudioEvent(IntPtr plugin, IntPtr p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Audio_PrepareSynchronizedAudioEventForScene(IntPtr plugin, ulong p0, ref ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_RegisterScriptWithAudio(IntPtr plugin, int p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_ReleaseAmbientAudioBank(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_ReleaseMissionAudioBank(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_ReleaseNamedScriptAudioBank(IntPtr plugin, IntPtr audioBank);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_ReleaseScriptAudioBank(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_ReleaseSoundId(IntPtr plugin, int soundId);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Audio_RequestAmbientAudioBank(IntPtr plugin, IntPtr p0, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Audio_RequestMissionAudioBank(IntPtr plugin, IntPtr p0, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Audio_RequestScriptAudioBank(IntPtr plugin, IntPtr p0, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_ResetPedAudioFlags(IntPtr plugin, int ped);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_ResetTrevorRage(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_RestartScriptedConversation(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_SetAggressiveHorns(IntPtr plugin, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_SetAmbientVoiceName(IntPtr plugin, int ped, IntPtr name);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_SetAmbientZoneListState(IntPtr plugin, IntPtr p0, bool p1, bool p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_SetAmbientZoneListStatePersistent(IntPtr plugin, IntPtr ambientZone, bool p1, bool p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_SetAmbientZoneState(IntPtr plugin, ref ulong p0, bool p1, bool p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_SetAmbientZoneStatePersistent(IntPtr plugin, IntPtr ambientZone, bool p1, bool p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_SetAnimalMood(IntPtr plugin, int animal, int mood);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_SetAudioFlag(IntPtr plugin, IntPtr flagName, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_SetAudioSceneVariable(IntPtr plugin, IntPtr scene, IntPtr variable, float value);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_SetAudioVehiclePriority(IntPtr plugin, int vehicle, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_SetCutsceneAudioOverride(IntPtr plugin, IntPtr p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_SetEmitterRadioStation(IntPtr plugin, IntPtr emitterName, IntPtr radioStation);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_SetFrontendRadioActive(IntPtr plugin, bool active);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_SetGpsActive(IntPtr plugin, bool active);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_SetHornEnabled(IntPtr plugin, int vehicle, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_SetInitialPlayerStation(IntPtr plugin, IntPtr radioStation);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_SetMicrophonePosition(IntPtr plugin, bool p0, float x1, float y1, float z1, float x2, float y2, float z2, float x3, float y3, float z3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_SetMobilePhoneRadioState(IntPtr plugin, bool state);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_SetMobileRadioEnabledDuringGameplay(IntPtr plugin, bool Toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_SetPedIsDrunk(IntPtr plugin, int ped, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_SetPedMute(IntPtr plugin, int ped);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_SetPedScream(IntPtr plugin, int ped);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_SetPedTalk(IntPtr plugin, int ped);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_SetPlayerAngry(IntPtr plugin, int playerPed, bool disabled);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_SetRadioAutoUnfreeze(IntPtr plugin, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_SetRadioStationDisabled(IntPtr plugin, IntPtr stationName, bool Toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_SetRadioToStationIndex(IntPtr plugin, int radioStation);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_SetRadioToStationName(IntPtr plugin, IntPtr stationName);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_SetRadioTrack(IntPtr plugin, IntPtr radioStation, IntPtr radioTrack);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_SetSirenWithNoDriver(IntPtr plugin, ref int vehicle, ref int toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_SetStaticEmitterEnabled(IntPtr plugin, IntPtr emitterName, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_SetSynchronizedAudioEventPositionThisFrame(IntPtr plugin, IntPtr p0, int p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_SetUserRadioControlEnabled(IntPtr plugin, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_SetVariableOnSound(IntPtr plugin, int soundId, IntPtr variableName, float value);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_SetVariableOnStream(IntPtr plugin, IntPtr p0, float p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_SetVehicleBoostActive(IntPtr plugin, int vehicle, bool Toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_SetVehicleRadioEnabled(IntPtr plugin, int vehicle, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_SetVehicleRadioLoud(IntPtr plugin, int vehicle, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_SetVehRadioStation(IntPtr plugin, int vehicle, IntPtr radioStation);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_SkipRadioForward(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_SkipToNextScriptedConversationLine(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_SoundVehicleHornThisFrame(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_SpecialFrontendEqual(IntPtr plugin, float x, float y, float z);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_StartAlarm(IntPtr plugin, IntPtr alarmName, bool p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Audio_StartAudioScene(IntPtr plugin, IntPtr scene);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_StartPreloadedConversation(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_StartScriptConversation(IntPtr plugin, bool p0, bool p1, bool p2, bool p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_StartScriptPhoneConversation(IntPtr plugin, bool p0, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_StopAlarm(IntPtr plugin, IntPtr alarmName, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_StopAllAlarms(IntPtr plugin, bool stop);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_StopAudioScene(IntPtr plugin, IntPtr scene);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_StopAudioScenes(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_StopCurrentPlayingAmbientSpeech(IntPtr plugin, int ped);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_StopPedRingtone(IntPtr plugin, int ped);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_StopPedSpeaking(IntPtr plugin, int ped, bool shaking);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Audio_StopScriptedConversation(IntPtr plugin, bool p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_StopSound(IntPtr plugin, int soundId);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_StopStream(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Audio_StopSynchronizedAudioEvent(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Audio_TriggerMusicEvent(IntPtr plugin, IntPtr eventName);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_UnfreezeRadioStation(IntPtr plugin, IntPtr radioStation);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_UnlockMissionNewsStory(IntPtr plugin, int newsStory);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_UnregisterScriptWithAudio(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Audio_UseSirenAsHorn(IntPtr plugin, int vehicle, bool toggle);
    }
}
