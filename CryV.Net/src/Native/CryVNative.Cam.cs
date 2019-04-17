using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CryV.Net.Native
{
    internal static partial class CryVNative
    {
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_AddCamSplineNode(IntPtr plugin, int camera, float x, float y, float z, float xRot, float yRot, float zRot, int length, int p8, int transitionType);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_AnimatedShakeCam(IntPtr plugin, int cam, IntPtr p1, IntPtr p2, IntPtr p3, float amplitude);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_AnimateGameplayCamZoom(IntPtr plugin, float p0, float distance);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_AttachCamToEntity(IntPtr plugin, int cam, int entity, float xOffset, float yOffset, float zOffset, bool isRelative);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_AttachCamToPedBone(IntPtr plugin, int cam, int ped, int boneIndex, float x, float y, float z, bool heading);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_AttachCamToVehicleBone(IntPtr plugin, int cam, int vehicle, int boneIndex, bool relativeRotation, float rotX, float rotY, float rotZ, float offX, float offY, float offZ, bool fixedDirection);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Cam_ClampGameplayCamPitch(IntPtr plugin, float minimum, float maximum);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Cam_ClampGameplayCamYaw(IntPtr plugin, float minimum, float maximum);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Cam_CreateCam(IntPtr plugin, IntPtr Gippo, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Cam_CreateCamera(IntPtr plugin, ulong camHash, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Cam_CreateCameraWithParams(IntPtr plugin, ulong camHash, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, float fov, bool p8, ulong p9);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Cam_CreateCamWithParams(IntPtr plugin, IntPtr camName, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, float fov, bool p8, int p9);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_CreateCinematicShot(IntPtr plugin, ulong p0, int p1, ulong p2, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_CustomMenuCoordinates(IntPtr plugin, float p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_DestroyAllCams(IntPtr plugin, bool thisScriptCheck);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_DestroyCam(IntPtr plugin, int cam, bool thisScriptCheck);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_DetachCam(IntPtr plugin, int cam);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_DisableAimCamThisUpdate(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_DisableFirstPersonCamThisFrame(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_DisableVehicleFirstPersonCamThisFrame(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Cam_DoesCamExist(IntPtr plugin, int cam);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_DoScreenFadeIn(IntPtr plugin, int duration);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_DoScreenFadeOut(IntPtr plugin, int duration);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_EnableCrosshairThisFrame(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Cam_GetCamAnimCurrentPhase(IntPtr plugin, int cam);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Native_Cam_GetCamCoord(IntPtr plugin, int cam);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Cam_GetCamFarClip(IntPtr plugin, int cam);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Cam_GetCamFarDof(IntPtr plugin, int cam);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Cam_GetCamFov(IntPtr plugin, int cam);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Cam_GetCamNearClip(IntPtr plugin, int cam);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Native_Cam_GetCamRot(IntPtr plugin, int cam, int rotationOrder);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Cam_GetCamSplineNodeIndex(IntPtr plugin, int cam);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Cam_GetCamSplineNodePhase(IntPtr plugin, int cam);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Cam_GetCamSplinePhase(IntPtr plugin, int cam);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Cam_GetFollowPedCamViewMode(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Cam_GetFollowPedCamZoomLevel(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Cam_GetFollowVehicleCamViewMode(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Cam_GetFollowVehicleCamZoomLevel(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Native_Cam_GetGameplayCamCoord(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Native_Cam_GetGameplayCamCoords(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Cam_GetGameplayCamFarClip(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Cam_GetGameplayCamFarDof(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Cam_GetGameplayCamFov(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Cam_GetGameplayCamNearDof(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Cam_GetGameplayCamRelativeHeading(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Cam_GetGameplayCamRelativePitch(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Native_Cam_GetGameplayCamRot(IntPtr plugin, int rotationOrder);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Native_Cam_GetGameplayCamRot2(IntPtr plugin, int rotationOrder);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Cam_GetGameplayCamZoom(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_GetIsMultiplayerBrief(IntPtr plugin, bool p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Cam_GetRenderingCam(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Cam_IsAimCamActive(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Cam_IsCamActive(IntPtr plugin, int cam);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Cam_IsCamInterpolating(IntPtr plugin, int cam);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Cam_IsCamPlayingAnim(IntPtr plugin, int cam, IntPtr animName, IntPtr animDictionary);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Cam_IsCamRendering(IntPtr plugin, int cam);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Cam_IsCamShaking(IntPtr plugin, int cam);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Cam_IsCamSplinePaused(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Cam_IsCinematicCamRendering(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Cam_IsCinematicCamShaking(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Cam_IsCinematicShotActive(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Cam_IsFirstPersonAimCamActive(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Cam_IsFollowPedCamActive(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Cam_IsFollowVehicleCamActive(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Cam_IsGameplayCamLookingBehind(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Cam_IsGameplayCamRendering(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Cam_IsGameplayCamShaking(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Cam_IsGameplayHintActive(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Cam_IsInVehicleCamDisabled(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Cam_IsScreenFadedIn(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Cam_IsScreenFadedOut(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Cam_IsScreenFadingIn(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Cam_IsScreenFadingOut(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Cam_IsScriptGlobalShaking(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Cam_IsSphereVisible(IntPtr plugin, float x, float y, float z, float radius);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam__0x0225778816FDC28C(IntPtr plugin, float p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam__0x0A9F2A468B328E74(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam__0x0AA27680A0BD43FA(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam__0x0FB82563989CF4FB(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam__0x11FA5D3479C7DD47(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam__0x12DED8CA53D47EA5(IntPtr plugin, float p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Cam__0x162F9D995753DC19(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Cam__0x17FCA7199A530203(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Cam__0x19CAFA3C87F7C2FF(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Cam__0x1F2300CB7FA7B7F6(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam__0x21E253A7F8DA5DFB(IntPtr plugin, IntPtr vehicleName);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam__0x247ACBC4ABBC9D1C(IntPtr plugin, bool p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Cam__0x26903D9CD1175F2C(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam__0x271017B9BA825366(IntPtr plugin, ulong p0, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam__0x271401846BD26E92(IntPtr plugin, bool p0, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam__0x2A2173E46DAECD12(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam__0x2AED6301F67007D5(IntPtr plugin, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam__0x2F7F2B26DD3F18EE(IntPtr plugin, float p0, float p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Cam__0x3044240D2E0FA842(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam__0x4008EDF7D6E48175(IntPtr plugin, bool p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam__0x469F2ECDEC046337(IntPtr plugin, bool p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam__0x47B595D60664CFFA(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam__0x48608C3464F58AB4(IntPtr plugin, ulong p0, ulong p1, ulong p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Cam__0x4879E4FE39074CDF(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam__0x49482F9FCD825AAA(IntPtr plugin, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam__0x503F5920162365B2(IntPtr plugin, ulong p0, float p1, float p2, float p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam__0x59424BD75174C9B1(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam__0x5A43C76F7FC7BA5F(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam__0x5C41E6BABC9E2112(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Cam__0x5C48A1D6E3B33179(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam__0x5D7B620DAE436138(IntPtr plugin, float p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Cam__0x5F35F6732C3FBBA0(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam__0x609278246A29CA34(IntPtr plugin, ulong p0, ulong p1, ulong p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam__0x62374889A4D59F72(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam__0x62ECFCFDEE7885D6(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam__0x6493CF69859B116A(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam__0x661B5C8654ADD825(IntPtr plugin, ulong p0, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Cam__0x705A276EBFF3133D(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Cam__0x70894BD0915C5BCA(IntPtr plugin, float p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Cam__0x74BD83EA840F6BC9(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam__0x7B8A361C1813FBEF(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam__0x7BF1A54AE67AC070(IntPtr plugin, ulong p0, ulong p1, ulong p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Cam__0x80EC114669DAEFF4(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam__0x83B8201ED82A9A2D(IntPtr plugin, ulong p0, ulong p1, ulong p2, float p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Cam__0x89215EC747DF244A(IntPtr plugin, float p0, int p1, float p2, float p3, float p4, float p5, float p6, int p7, int p8);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam__0x8BBACBF51DA047A8(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Cam__0x8BFCEB5EA1B161B6(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam__0x91EF6EE6419E5B97(IntPtr plugin, bool p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam__0x9E4CFFF989258472(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam__0xA2767257A320FC82(IntPtr plugin, ulong p0, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam__0xA41BCD7213805AAC(IntPtr plugin, bool p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam__0xA6385DEB180F319F(IntPtr plugin, ulong p0, ulong p1, float p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Cam__0xBF72910D0F26F025(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam__0xC2EAE3FB8CDBED31(IntPtr plugin, IntPtr p0, IntPtr p1, IntPtr p2, float p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam__0xC8391C309684595A(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam__0xC8B5C4A79CC18B94(IntPtr plugin, int p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam__0xC91C6C55199308CA(IntPtr plugin, ulong p0, float p1, float p2, float p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam__0xC92717EF615B6704(IntPtr plugin, float p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Cam__0xCA9D2AA3E326D720(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam__0xCCD078C2665D2973(IntPtr plugin, bool p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam__0xCED08CBE8EBB97C7(IntPtr plugin, float p0, float p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Cam__0xD0082607100D7193(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam__0xD1B0F412F109EA5D(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam__0xD1F8363DFAD03848(IntPtr plugin, float p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Cam__0xD7360051C885628B(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam__0xDB90C6CCA48940F1(IntPtr plugin, bool p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam__0xDC9DA9E8789F5246(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam__0xDD79DF9F4D26E1C9(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam__0xE111A7C0D200CBC5(IntPtr plugin, ulong p0, float p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam__0xE827B9382CFB41BA(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Cam__0xE9EA16D6E54CDCA4(IntPtr plugin, int p0, int p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Cam__0xEAF0FA793D05C592(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Cam__0xEE778F8C7E1142E2(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam__0xF4C8CF9E353AFECA(IntPtr plugin, IntPtr p0, float p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam__0xF4F2C0D4EE209E20(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam__0xF55E4046F6F831DC(IntPtr plugin, ulong p0, float p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam__0xF8BDBF3D573049A1(IntPtr plugin, float p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam__0xFD3151CD37EA2245(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_OverrideCamSplineMotionBlur(IntPtr plugin, int cam, int p1, float p2, float p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_OverrideCamSplineVelocity(IntPtr plugin, int cam, int p1, float p2, float p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Cam_PlayCamAnim(IntPtr plugin, int cam, IntPtr animName, IntPtr animDictionary, float x, float y, float z, float xRot, float yRot, float zRot, bool p9, int p10);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Cam_PlaySynchronizedCamAnim(IntPtr plugin, ulong p0, ulong p1, IntPtr animName, IntPtr animDictionary);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_PointCamAtCoord(IntPtr plugin, int cam, float x, float y, float z);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_PointCamAtEntity(IntPtr plugin, int cam, int entity, float p2, float p3, float p4, bool p5);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_PointCamAtPedBone(IntPtr plugin, int cam, int ped, int boneIndex, float x, float y, float z, bool p6);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_RenderFirstPersonCam(IntPtr plugin, bool render, float p1, int p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_RenderScriptCams(IntPtr plugin, bool render, bool ease, int easeTime, bool p3, bool p4);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_SetCamActive(IntPtr plugin, int cam, bool active);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_SetCamActiveWithInterp(IntPtr plugin, int camTo, int camFrom, int duration, int easeLocation, int easeRotation);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_SetCamAffectsAiming(IntPtr plugin, int cam, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_SetCamAnimCurrentPhase(IntPtr plugin, int cam, float phase);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_SetCamCoord(IntPtr plugin, int cam, float posX, float posY, float posZ);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_SetCamDebugName(IntPtr plugin, int camera, IntPtr name);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_SetCamDofFnumberOfLens(IntPtr plugin, int camera, float p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_SetCamDofFocusDistanceBias(IntPtr plugin, int camera, float p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_SetCamDofMaxNearInFocusDistance(IntPtr plugin, int camera, float p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_SetCamDofMaxNearInFocusDistanceBlendLevel(IntPtr plugin, int camera, float p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_SetCamDofPlanes(IntPtr plugin, int cam, float p1, float p2, float p3, float p4);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_SetCamDofStrength(IntPtr plugin, int cam, float dofStrength);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_SetCamEffect(IntPtr plugin, int p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_SetCameraRange(IntPtr plugin, int cam, float range);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_SetCamFarClip(IntPtr plugin, int cam, float farClip);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_SetCamFarDof(IntPtr plugin, int cam, float farDOF);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_SetCamFov(IntPtr plugin, int cam, float fieldOfView);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_SetCamInheritRollVehicle(IntPtr plugin, int cam, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_SetCamMotionBlurStrength(IntPtr plugin, int cam, float strength);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_SetCamNearClip(IntPtr plugin, int cam, float nearClip);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_SetCamNearDof(IntPtr plugin, int cam, float nearDOF);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_SetCamParams(IntPtr plugin, int cam, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, float fieldOfView, ulong p8, int p9, int p10, int p11);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_SetCamRot(IntPtr plugin, int cam, float rotX, float rotY, float rotZ, int rotationOrder);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_SetCamShakeAmplitude(IntPtr plugin, int cam, float amplitude);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_SetCamSplineDuration(IntPtr plugin, int cam, int timeDuration);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_SetCamSplinePhase(IntPtr plugin, int cam, float p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_SetCamUseShallowDofMode(IntPtr plugin, int cam, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_SetCinematicButtonActive(IntPtr plugin, bool p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_SetCinematicCamShakeAmplitude(IntPtr plugin, float p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_SetCinematicModeActive(IntPtr plugin, bool p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_SetFirstPersonCamNearClip(IntPtr plugin, float distance);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_SetFirstPersonCamPitchRange(IntPtr plugin, float minAngle, float maxAngle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Cam_SetFollowPedCamCutsceneChat(IntPtr plugin, IntPtr p0, int p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_SetFollowPedCamViewMode(IntPtr plugin, int viewMode);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_SetFollowVehicleCamViewMode(IntPtr plugin, int viewMode);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_SetFollowVehicleCamZoomLevel(IntPtr plugin, int zoomLevel);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_SetGameplayCamRawPitch(IntPtr plugin, float pitch);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_SetGameplayCamRawYaw(IntPtr plugin, float yaw);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_SetGameplayCamRelativeHeading(IntPtr plugin, float heading);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_SetGameplayCamRelativePitch(IntPtr plugin, float x, float Value2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_SetGameplayCamShakeAmplitude(IntPtr plugin, float amplitude);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_SetGameplayCoordHint(IntPtr plugin, float x, float y, float z, int duration, int blendOutDuration, int blendInDuration, int unk);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_SetGameplayEntityHint(IntPtr plugin, int entity, float xOffset, float yOffset, float zOffset, bool p4, int p5, int p6, int p7, ulong p8);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_SetGameplayHintFov(IntPtr plugin, float FOV);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_SetGameplayObjectHint(IntPtr plugin, ulong p0, float p1, float p2, float p3, bool p4, ulong p5, ulong p6, ulong p7);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_SetGameplayPedHint(IntPtr plugin, int p0, float x1, float y1, float z1, bool p4, ulong p5, ulong p6, ulong p7);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_SetGameplayVehicleHint(IntPtr plugin, ulong p0, float p1, float p2, float p3, bool p4, ulong p5, ulong p6, ulong p7);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_SetThirdPersonAimCamNearClip(IntPtr plugin, float distance);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_SetTimeIdleDrop(IntPtr plugin, bool p0, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_SetUseHiDof(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Cam_SetWidescreenBorders(IntPtr plugin, bool p0, int p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_ShakeCam(IntPtr plugin, int cam, IntPtr type, float amplitude);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_ShakeCinematicCam(IntPtr plugin, IntPtr p0, float p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_ShakeGameplayCam(IntPtr plugin, IntPtr shakeName, float intensity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_StopCamPointing(IntPtr plugin, int cam);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_StopCamShaking(IntPtr plugin, int cam, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_StopCinematicCamShaking(IntPtr plugin, bool p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_StopCinematicShot(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_StopCutsceneCamShaking(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_StopGameplayCamShaking(IntPtr plugin, bool p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_StopGameplayHint(IntPtr plugin, bool p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Cam_StopScriptGlobalShaking(IntPtr plugin, bool p0);
    }
}
