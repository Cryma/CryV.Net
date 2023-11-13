using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CryV.Net.Native;

internal static partial class CryVNative
{
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming_BeginSrl(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming_ClearFocus(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming_ClearHdArea(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Streaming_DestroyPlayerInPauseMenu(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Streaming_DoesAnimDictExist(IntPtr plugin, IntPtr animDict);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming_EndSrl(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Streaming_FormatFocusHeading(IntPtr plugin, float x, float y, float z, float rad, ulong p4, ulong p5);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Streaming_GetIdealPlayerSwitchType(IntPtr plugin, float x1, float y1, float z1, float x2, float y2, float z2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Streaming_GetNumberOfStreamingRequests(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Streaming_GetPlayerShortSwitchState(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Streaming_GetPlayerSwitchState(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Streaming_GetPlayerSwitchType(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Streaming_HasAnimDictLoaded(IntPtr plugin, IntPtr animDict);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Streaming_HasAnimSetLoaded(IntPtr plugin, IntPtr animSet);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Streaming_HasClipSetLoaded(IntPtr plugin, IntPtr clipSet);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Streaming_HasCollisionForModelLoaded(IntPtr plugin, ulong model);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Streaming_HasModelLoaded(IntPtr plugin, ulong model);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Streaming_HasNamedPtfxAssetLoaded(IntPtr plugin, IntPtr assetName);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Streaming_HasPtfxAssetLoaded(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Streaming_IsEntityFocus(IntPtr plugin, int entity);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Streaming_IsIplActive(IntPtr plugin, IntPtr iplName);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Streaming_IsModelAPed(IntPtr plugin, ulong modelHash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Streaming_IsModelAVehicle(IntPtr plugin, ulong model);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Streaming_IsModelInCdimage(IntPtr plugin, ulong model);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Streaming_IsModelValid(IntPtr plugin, ulong model);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Streaming_IsNetworkLoadingScene(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Streaming_IsNewLoadSceneActive(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Streaming_IsNewLoadSceneLoaded(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Streaming_IsPlayerSwitchInProgress(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Streaming_IsSrlLoaded(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming_LoadAllObjectsNow(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming_LoadMissionCreatorData(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming_LoadScene(IntPtr plugin, float x, float y, float z);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming_NetworkStopLoadScene(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming_NetworkUpdateLoadScene(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Streaming_NewLoadSceneStart(IntPtr plugin, float p0, float p1, float p2, float p3, float p4, float p5, float p6, ulong p7);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Streaming_NewLoadSceneStartSphere(IntPtr plugin, float x, float y, float z, float radius, ulong p4);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming_NewLoadSceneStop(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming__0x03F1A106BDA7DD3E(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Streaming__0x07C313F94746702C(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming__0x0811381EF5062FEC(IntPtr plugin, int p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Streaming__0x0AD9710CEE2F590F(IntPtr plugin, float p0, float p1, float p2, float p3, float p4, float p5, ulong p6);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Streaming__0x0BC3144DEB678666(IntPtr plugin, ulong modelHash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Streaming__0x0C15B0E443B2349D(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming__0x0FDE9DBFC0A6BC65(IntPtr plugin, ref ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming__0x1E9057A74FD73E23(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming__0x1EE7D8DF4425F053(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Streaming__0x1F3F018BC3AFA77C(IntPtr plugin, float p0, float p1, float p2, float p3, float p4, float p5, float p6, ulong p7, ulong p8);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming__0x20C6C7E4EB082A7F(IntPtr plugin, bool p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Streaming__0x3D3D8B3BE5A83D35(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming__0x40AEFD1A244741F2(IntPtr plugin, bool p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming__0x43D1680C6D19A8E9(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming__0x472397322E92A856(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming__0x4E52E752C76E7E7A(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Streaming__0x5068F488DDB54DD8(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Streaming__0x5B48A06DD0E792A5(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming__0x5F2013F8BC24EE69(IntPtr plugin, int p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming__0x63EB2B972A218CAC(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Streaming__0x71E7B2E657449AAD(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming__0x74DE2E8739086740(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Streaming__0x78C0D93253149435(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Streaming__0x7D41E9D2D17C5B2D(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming__0x8E2A065ABDAE6994(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Streaming__0x933BBEEB8C61B5F4(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming__0x95A7DABDDBB78AE7(IntPtr plugin, ref ulong p0, ref ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming__0xA76359FC80B2438E(IntPtr plugin, float p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming__0xAD5FDF34B81BFE79(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming__0xAF12610C644A35C9(IntPtr plugin, IntPtr p0, bool p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Streaming__0xBC9823AB80A3DCAC(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming__0xBD605B8E0E18B3BB(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming__0xBEB2D9A1D9A8F55A(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming__0xBED8CA5FF5E04113(IntPtr plugin, float p0, float p1, float p2, float p3);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming__0xD4793DFF3AF2ABCD(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Streaming__0xDFA80CB25D0A19B3(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming__0xEF39EE20C537E98C(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4, ulong p5);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming__0xF086AD9354FAC3A3(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming__0xF4A0DADB70F57FA6(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming__0xF8155A7F03DDFC8E(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Streaming__0xFB199266061F820A(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming_PrefetchSrl(IntPtr plugin, IntPtr srl);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming_RemoveAnimDict(IntPtr plugin, IntPtr animDict);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming_RemoveAnimSet(IntPtr plugin, IntPtr animSet);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming_RemoveClipSet(IntPtr plugin, IntPtr clipSet);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming_RemoveIpl(IntPtr plugin, IntPtr iplName);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming_RemoveNamedPtfxAsset(IntPtr plugin, IntPtr assetName);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming_RemovePtfxAsset(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming_RequestAdditionalCollisionAtCoord(IntPtr plugin, float x, float y, float z);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming_RequestAnimDict(IntPtr plugin, IntPtr animDict);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming_RequestAnimSet(IntPtr plugin, IntPtr animSet);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming_RequestClipSet(IntPtr plugin, IntPtr clipSet);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Streaming_RequestCollisionAtCoord(IntPtr plugin, float x, float y, float z);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming_RequestCollisionForModel(IntPtr plugin, ulong model);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming_RequestInteriorRoomByName(IntPtr plugin, int interiorID, IntPtr roomName);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming_RequestIpl(IntPtr plugin, IntPtr iplName);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming_RequestMenuPedModel(IntPtr plugin, ulong model);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming_RequestModel(IntPtr plugin, ulong model);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming_RequestNamedPtfxAsset(IntPtr plugin, IntPtr assetName);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Streaming_RequestPtfxAsset(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming_SetDitchPoliceModels(IntPtr plugin, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming_SetFocusArea(IntPtr plugin, float x, float y, float z, float offsetX, float offsetY, float offsetZ);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming_SetFocusEntity(IntPtr plugin, int entity);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming_SetGamePausesForStreaming(IntPtr plugin, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming_SetHdArea(IntPtr plugin, float x, float y, float z, float radius);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming_SetInteriorActive(IntPtr plugin, int interiorID, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming_SetModelAsNoLongerNeeded(IntPtr plugin, ulong model);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming_SetPedPopulationBudget(IntPtr plugin, int p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Streaming_SetPlayerInvertedUp(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming_SetPlayerSwitchOutro(IntPtr plugin, float p0, float p1, float p2, float p3, float p4, float p5, float p6, float p7, ulong p8);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming_SetReducePedModelBudget(IntPtr plugin, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming_SetReduceVehicleModelBudget(IntPtr plugin, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming_SetSrlTime(IntPtr plugin, float p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming_SetStreaming(IntPtr plugin, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming_SetVehiclePopulationBudget(IntPtr plugin, int p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming_ShutdownCreatorBudget(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming_StartPlayerSwitch(IntPtr plugin, int from, int to, int flags, int switchType);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming_StopPlayerSwitch(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming_SwitchInPlayer(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Streaming_SwitchOutPlayer(IntPtr plugin, int ped, int flags, int switchType);
}
