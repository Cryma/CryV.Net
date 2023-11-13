using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CryV.Net.Native;

internal static partial class CryVNative
{
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Cutscene_CanSetEnterStateForRegisteredEntity(IntPtr plugin, IntPtr cutsceneEntName, ulong modelHash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Cutscene_CanSetExitStateForCamera(IntPtr plugin, bool p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Cutscene_CanSetExitStateForRegisteredEntity(IntPtr plugin, IntPtr cutsceneEntName, ulong modelHash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Cutscene_DoesCutsceneEntityExist(IntPtr plugin, IntPtr cutsceneEntName, ulong modelHash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Cutscene_GetCutsceneSectionPlaying(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Cutscene_GetCutsceneTime(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Cutscene_GetCutsceneTotalDuration(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Cutscene_GetEntityIndexOfCutsceneEntity(IntPtr plugin, IntPtr cutsceneEntName, ulong modelHash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Cutscene_GetEntityIndexOfRegisteredEntity(IntPtr plugin, IntPtr cutsceneEntName, ulong modelHash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Cutscene_HasCutsceneFinished(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Cutscene_HasCutsceneLoaded(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Cutscene_HasThisCutsceneLoaded(IntPtr plugin, IntPtr cutsceneName);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Cutscene_IsCutsceneActive(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Cutscene_IsCutscenePlaying(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Cutscene__0x011883F41211432A(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4, ulong p5, ulong p6);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Cutscene__0x06A3524161C502BA(IntPtr plugin, ref ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Cutscene__0x06EE9048FD080382(IntPtr plugin, bool p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Cutscene__0x0ABC54DE641DC0FC(IntPtr plugin, ref ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Cutscene__0x20746F7B1032A3C7(IntPtr plugin, bool p0, bool p1, bool p2, bool p3);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Cutscene__0x2A56C06EBEF2B0D9(IntPtr plugin, IntPtr cutsceneEntName, int ped, ulong modelHash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Cutscene__0x2F137B508DE238F2(IntPtr plugin, bool p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Cutscene__0x41FAA8FB2ECE8720(IntPtr plugin, bool p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Cutscene__0x4C61C75BEE8184C2(IntPtr plugin, IntPtr p0, ulong p1, ulong p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Cutscene__0x4CEBC1ED31E8925E(IntPtr plugin, IntPtr cutsceneName);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Cutscene__0x583DF8E3D4AFBD98(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Cutscene__0x5EDEF0CF8C1DAB3C(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Cutscene__0x708BDD8CD795B043(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Cutscene__0x71B74D2AE19338D0(IntPtr plugin, int p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Cutscene__0x7F96F23FA9B73327(IntPtr plugin, ulong modelHash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Cutscene__0x8D9DF6ECA8768583(IntPtr plugin, int p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Cutscene__0xA0FE76168A189DDB(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Cutscene__0xA1C996C2A744262E(IntPtr plugin, ref ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Cutscene__0xB56BBBCC2955D9CB(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Cutscene__0xC61B86C9F61EB404(IntPtr plugin, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Cutscene__0xD00D76A7DFC9D852(IntPtr plugin, ref ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Cutscene__0xE36A98D8AB3D3C66(IntPtr plugin, bool p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Cutscene_RegisterEntityForCutscene(IntPtr plugin, int cutscenePed, IntPtr cutsceneEntName, int p2, ulong modelHash, int p4);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Cutscene_RegisterSynchronisedScriptSpeech(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Cutscene_RemoveCutscene(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Cutscene_RequestCutscene(IntPtr plugin, IntPtr cutsceneName, int p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Cutscene_RequestCutsceneEx(IntPtr plugin, IntPtr cutsceneName, int p1, int p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Cutscene_SetCutsceneFadeValues(IntPtr plugin, bool p0, bool p1, bool p2, bool p3);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Cutscene_SetCutsceneOrigin(IntPtr plugin, float x, float y, float z, float p3, int p4);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Cutscene_SetCutscenePedComponentVariation(IntPtr plugin, IntPtr cutsceneEntName, int p1, int p2, int p3, ulong modelHash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Cutscene_SetCutscenePedPropVariation(IntPtr plugin, IntPtr cutsceneEntName, int p1, int p2, int p3, ulong modelHash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Cutscene_SetCutsceneTriggerArea(IntPtr plugin, float p0, float p1, float p2, float p3, float p4, float p5);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Cutscene_StartCutscene(IntPtr plugin, int p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Cutscene_StartCutsceneAtCoords(IntPtr plugin, float x, float y, float z, int p3);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Cutscene_StopCutscene(IntPtr plugin, bool p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Cutscene_StopCutsceneImmediately(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Cutscene_WasCutsceneSkipped(IntPtr plugin);
}
