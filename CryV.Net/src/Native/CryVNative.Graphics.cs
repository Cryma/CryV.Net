using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CryV.Net.Native;

internal static partial class CryVNative
{
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Graphics_AddClanDecalToVehicle(IntPtr plugin, int vehicle, int ped, int boneIndex, float x1, float x2, float x3, float y1, float y2, float y3, float z1, float z2, float z3, float scale, ulong p13, int alpha);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Graphics_AddDecal(IntPtr plugin, int decalType, float posX, float posY, float posZ, float p4, float p5, float p6, float p7, float p8, float p9, float width, float height, float rCoef, float gCoef, float bCoef, float opacity, float timeout, bool p17, bool p18, bool p19);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_AddDecalToMarker(IntPtr plugin, int decalType, IntPtr textureDict, IntPtr textureName);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Graphics_AddEntityIcon(IntPtr plugin, int entity, IntPtr icon);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Graphics_AddPetrolDecal(IntPtr plugin, float x, float y, float z, float groundLvl, float width, float transparency);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_AttachTvAudioToEntity(IntPtr plugin, int entity);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Graphics_BeginScaleformMovieMethod(IntPtr plugin, int scaleform, IntPtr functionName);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Graphics_BeginScaleformMovieMethodHudComponent(IntPtr plugin, int hudComponent, IntPtr functionName);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Graphics_BeginScaleformMovieMethodOnFrontend(IntPtr plugin, IntPtr functionName);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Graphics_BeginScaleformMovieMethodOnFrontendHeader(IntPtr plugin, IntPtr functionName);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_BeginTextCommandScaleformString(IntPtr plugin, IntPtr componentType);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_CallScaleformMovieFunctionFloatParams(IntPtr plugin, int scaleform, IntPtr functionName, float param1, float param2, float param3, float param4, float param5);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_CallScaleformMovieFunctionMixedParams(IntPtr plugin, int scaleform, IntPtr functionName, float floatParam1, float floatParam2, float floatParam3, float floatParam4, float floatParam5, IntPtr stringParam1, IntPtr stringParam2, IntPtr stringParam3, IntPtr stringParam4, IntPtr stringParam5);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_CallScaleformMovieFunctionStringParams(IntPtr plugin, int scaleform, IntPtr functionName, IntPtr param1, IntPtr param2, IntPtr param3, IntPtr param4, IntPtr param5);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_CallScaleformMovieMethod(IntPtr plugin, int scaleform, IntPtr method);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_ClearDrawOrigin(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_ClearExtraTimecycleModifier(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_ClearTimecycleModifier(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Graphics_CreateCheckpoint(IntPtr plugin, int type, float posX1, float posY1, float posZ1, float posX2, float posY2, float posZ2, float radius, int red, int green, int blue, int alpha, int reserved);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Graphics_CreateTrackedPoint(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_DeleteCheckpoint(IntPtr plugin, int checkpoint);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_DestroyTrackedPoint(IntPtr plugin, int point);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_DisableVehicleDistantlights(IntPtr plugin, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Graphics_DoesParticleFxLoopedExist(IntPtr plugin, int ptfxHandle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Graphics_DoesVehicleHaveDecal(IntPtr plugin, int vehicle, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_DrawBox(IntPtr plugin, float x1, float y1, float z1, float x2, float y2, float z2, int red, int green, int blue, int alpha);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_DrawDebugBox(IntPtr plugin, float x1, float y1, float z1, float x2, float y2, float z2, int red, int green, int blue, int alpha);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_DrawDebugCross(IntPtr plugin, float x, float y, float z, float size, int red, int green, int blue, int alpha);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_DrawDebugLine(IntPtr plugin, float x1, float y1, float z1, float x2, float y2, float z2, int red, int green, int blue, int alpha);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_DrawDebugLineWithTwoColours(IntPtr plugin, float x1, float y1, float z1, float x2, float y2, float z2, int r1, int g1, int b1, int r2, int g2, int b2, int alpha1, int alpha2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_DrawDebugSphere(IntPtr plugin, float x, float y, float z, float radius, int red, int green, int blue, int alpha);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_DrawDebugText(IntPtr plugin, IntPtr text, float x, float y, float z, int red, int green, int blue, int alpha);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_DrawDebugText2D(IntPtr plugin, IntPtr text, float x, float y, float z, int red, int green, int blue, int alpha);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_DrawInteractiveSprite(IntPtr plugin, IntPtr textureDict, IntPtr textureName, float screenX, float screenY, float width, float height, float heading, int red, int green, int blue, int alpha);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_DrawLightWithRange(IntPtr plugin, float posX, float posY, float posZ, int colorR, int colorG, int colorB, float range, float intensity);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_DrawLightWithRangeAndShadow(IntPtr plugin, float x, float y, float z, int r, int g, int b, float range, float intensity, float shadow);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_DrawLine(IntPtr plugin, float x1, float y1, float z1, float x2, float y2, float z2, int red, int green, int blue, int alpha);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_DrawMarker(IntPtr plugin, int type, float posX, float posY, float posZ, float dirX, float dirY, float dirZ, float rotX, float rotY, float rotZ, float scaleX, float scaleY, float scaleZ, int red, int green, int blue, int alpha, bool bobUpAndDown, bool faceCamera, int p19, bool rotate, IntPtr textureDict, IntPtr textureName, bool drawOnEnts);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_DrawPoly(IntPtr plugin, float x1, float y1, float z1, float x2, float y2, float z2, float x3, float y3, float z3, int red, int green, int blue, int alpha);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_DrawRect(IntPtr plugin, float x, float y, float width, float height, int r, int g, int b, int a);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_DrawScaleformMovie(IntPtr plugin, int scaleformHandle, float x, float y, float width, float height, int red, int green, int blue, int alpha, int unk);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_DrawScaleformMovieFullscreen(IntPtr plugin, int scaleform, int red, int green, int blue, int alpha, int unk);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_DrawScaleformMovieFullscreenMasked(IntPtr plugin, int scaleform1, int scaleform2, int red, int green, int blue, int alpha);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_DrawScaleformMovie3D(IntPtr plugin, int scaleform, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, float p7, float sharpness, float p9, float scaleX, float scaleY, float scaleZ, ulong p13);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_DrawScaleformMovie3DNonAdditive(IntPtr plugin, int scaleform, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, float p7, float p8, float p9, float scaleX, float scaleY, float scaleZ, ulong p13);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Graphics_DrawShowroom(IntPtr plugin, IntPtr p0, int ped, int p2, float posX, float posY, float posZ);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_DrawSpotLight(IntPtr plugin, float posX, float posY, float posZ, float dirX, float dirY, float dirZ, int colorR, int colorG, int colorB, float distance, float brightness, float hardness, float radius, float falloff);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_DrawSpotLightWithShadow(IntPtr plugin, float posX, float posY, float posZ, float dirX, float dirY, float dirZ, int colorR, int colorG, int colorB, float distance, float brightness, float roundness, float radius, float falloff, int shadowId);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_DrawSprite(IntPtr plugin, IntPtr textureDict, IntPtr textureName, float screenX, float screenY, float width, float height, float heading, int red, int green, int blue, int alpha);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_DrawTvChannel(IntPtr plugin, float xPos, float yPos, float xScale, float yScale, float rotation, int red, int green, int blue, int alpha);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_EnableAlienBloodVfx(IntPtr plugin, bool Toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_EnableClownBloodVfx(IntPtr plugin, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_EnableMovieSubtitles(IntPtr plugin, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_EndScaleformMovieMethod(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Graphics_EndScaleformMovieMethodReturn(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_EndTextCommandScaleformString(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_EndTextCommandScaleformString2(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_EntityDescriptionText(IntPtr plugin, int entity);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_FadeDecalsInRange(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_GetActiveScreenResolution(IntPtr plugin, ref int x, ref int y);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern float Native_Graphics_GetAspectRatio(IntPtr plugin, bool b);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern float Native_Graphics_GetDecalWashLevel(IntPtr plugin, int decal);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Graphics_GetExtraTimecycleModifierIndex(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Graphics_GetIsHidef(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Graphics_GetIsWidescreen(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Graphics_GetMaximumNumberOfPhotos(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Graphics_GetMaximumNumberOfPhotos2(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Graphics_GetNumberOfPhotos(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern float Native_Graphics_GetSafeZoneSize(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Graphics_GetScaleformMovieFunctionReturnBool(IntPtr plugin, int method_return);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Graphics_GetScaleformMovieFunctionReturnInt(IntPtr plugin, int method_return);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern IntPtr Native_Graphics_GetScaleformMovieFunctionReturnString(IntPtr plugin, int method_return);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Graphics_GetScreenCoordFromWorldCoord(IntPtr plugin, float worldX, float worldY, float worldZ, ref float screenX, ref float screenY);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Graphics_GetScreenEffectIsActive(IntPtr plugin, IntPtr effectName);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_GetScreenResolution(IntPtr plugin, ref int x, ref int y);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_GetScriptGfxPosition(IntPtr plugin, float x, float y, ref float calculatedX, ref float calculatedY);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern IntPtr Native_Graphics_GetTextureResolution(IntPtr plugin, IntPtr textureDict, IntPtr textureName);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Graphics_GetTimecycleModifierIndex(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Graphics_GetTvChannel(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern float Native_Graphics_GetTvVolume(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Graphics_HasHudScaleformLoaded(IntPtr plugin, int hudComponent);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Graphics_HasNamedScaleformMovieLoaded(IntPtr plugin, IntPtr scaleformName);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Graphics_HasScaleformContainerMovieLoadedIntoParent(IntPtr plugin, int scaleformHandle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Graphics_HasScaleformMovieLoaded(IntPtr plugin, int scaleformHandle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Graphics_HasStreamedTextureDictLoaded(IntPtr plugin, IntPtr textureDict);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Graphics_IsDecalAlive(IntPtr plugin, int decal);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Graphics_IsNightvisionActive(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern float Native_Graphics_IsParticleFxDelayedBlink(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Graphics_IsSeethroughActive(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Graphics_IsTrackedPointVisible(IntPtr plugin, int point);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Graphics_LoadMovieMeshSet(IntPtr plugin, IntPtr movieMeshSetName);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Graphics_LoadTvChannel(IntPtr plugin, ulong tvChannel);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_LoadTvChannelSequence(IntPtr plugin, int TV_Channel, IntPtr VideoSequence, bool Restart);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_MoveVehicleDecals(IntPtr plugin, ulong p0, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x0218BA067D249DEA(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x02369D5C8A51FDCF(IntPtr plugin, bool p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Graphics__0x02AC28F3A01FA04A(IntPtr plugin, float p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x03300B57FCAC6DDB(IntPtr plugin, bool p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x03FC694AE06C5A20(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x06F761EA47C1D3ED(IntPtr plugin, bool p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x0A123435A26C36CD(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x0A46AF8A78DC5E0A(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x0AE73D8DF3A762B2(IntPtr plugin, bool p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Graphics__0x0C0C4E81E1AC60A0(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x0C8FAC83902A62DF(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Graphics__0x0D6CA79EEEBD8CA3(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x0E4299C549F0D1F1(IntPtr plugin, bool p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x1072F115DAB0717E(IntPtr plugin, bool p0, bool p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x1086127B3A63505E(IntPtr plugin, ulong p0, ulong p1, ulong p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x108BE26959A9D9BB(IntPtr plugin, bool p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x12995F2E53FFA601(IntPtr plugin, int p0, int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8, int p9, int p10, int p11);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x14FC5833464340A8(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x15E33297C3E8DC60(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x1600FD8CF72EBC12(IntPtr plugin, float p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x1612C45F9E3E0D44(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x1636D7FC127B10D2(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Graphics__0x1670F8D05056F257(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x19E50EB6E33E1D28(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x1A8E2C8B9CF4549C(IntPtr plugin, ref ulong p0, ref ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x1BBC135A4D25EDDE(IntPtr plugin, bool p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x1C4FC5752BCD8E48(IntPtr plugin, float x, float y, float z, float p3, float rotation, float p5, float width, float height, float p8, float scale, float glowIntensity, float normalHeight, float heightDiff);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x1CBA05AE7BD7EE05(IntPtr plugin, float p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Graphics__0x1DD2139A9A20DCE8(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x2201C576FACAEBE8(IntPtr plugin, ulong p0, IntPtr p1, ulong p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x22A249A53034450A(IntPtr plugin, bool p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x23BA6B0C2AD7B0D3(IntPtr plugin, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x2485D34E50A22E84(IntPtr plugin, float p0, float p1, float p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x259BA6D4E6F808F1(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x25FC3E33A31AD0C9(IntPtr plugin, bool p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x27CB772218215325(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x27CFB1B1E078CB2D(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x27E32866E9A5C416(IntPtr plugin, float p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Graphics__0x27FEB5254759CDE3(IntPtr plugin, IntPtr textureDict, bool p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x29280002282F1928(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4, ulong p5, ulong p6, ulong p7, ulong p8, ulong p9, ulong p10, ulong p11, ulong p12, ulong p13, ulong p14, ulong p15, ulong p16, ulong p17, ulong p18, ulong p19, ulong p20, ulong p21, ulong p22, ulong p23);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x2A2A52824DB96700(IntPtr plugin, ref ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Graphics__0x2A893980E96B659A(IntPtr plugin, bool p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x2B40A97646381508(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Graphics__0x2C42340F916C5930(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Graphics__0x2F09F7976C512404(IntPtr plugin, float xCoord, float yCoord, float zCoord, float p3);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x302C91AB2D477F7E(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x312342E1A4874F3F(IntPtr plugin, float p0, float p1, float p2, float p3, float p4, float p5, float p6, float p7, bool p8);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x32F34FF7F617643B(IntPtr plugin, ulong p0, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x346EF3ECAAAB149E(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Graphics__0x35FB78DC42B7BD21(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x3669F1B198DCAA4F(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x36F6626459D91457(IntPtr plugin, float p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Graphics__0x393BD2275CEB7793(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Graphics__0x3DEC726C25A11BAC(IntPtr plugin, int p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x44621483FF966526(IntPtr plugin, ulong p0, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Graphics__0x459FD2C8D0AB78BC(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x46D1A61A21F566FC(IntPtr plugin, float p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Graphics__0x4862437A486F91B0(IntPtr plugin, IntPtr p0, ref ulong p1, ref ulong p2, bool p3);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x4AF92ACD3141D96C(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x4B5CFC83122DF602(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x54E22EA2C1956A8D(IntPtr plugin, float p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Graphics__0x5B0316762AFD4A64(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x5CE62918F8D703C7(IntPtr plugin, int lowR, int lowG, int lowB, int lowAlpha, int R, int G, int B, int Alpha, int highR, int highG, int highB, int highAlpha);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x5DBF05DB5926D089(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x5DEBD9C4DC995692(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Graphics__0x5E657EF1099EDD65(IntPtr plugin, int p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x5E9DAF5A20F15908(IntPtr plugin, float p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x5F0F3F56635809EF(IntPtr plugin, float p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x615D3925E87A3B26(IntPtr plugin, int checkpoint);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x61F95E5BB3E0A8C6(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x649C97D52332341A(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Graphics__0x65E7E78842E74CDB(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x6A12D88881435DCA(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x6A51F78772175A51(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x6D955F6A9E0295B1(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4, ulong p5, ulong p6);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x6DDBF9DFFC4AC080(IntPtr plugin, bool p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x736D7AA1B750856B(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4, ulong p5, ulong p6, ulong p7, ulong p8, ulong p9, ulong p10, ulong p11, ulong p12, ulong p13, ulong p14, ulong p15, ulong p16, ulong p17, ulong p18, ulong p19, ulong p20, ulong p21, ulong p22, ulong p23, ulong p24, ulong p25, ulong p26, ulong p27, ulong p28, ulong p29, ulong p30, ulong p31);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x74C180030FDE4B69(IntPtr plugin, bool p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Graphics__0x759650634F07B6B4(IntPtr plugin, int p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x799017F9E3B10112(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4, ulong p5, ulong p6, ulong p7);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x7A42B2E236E71415(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Graphics__0x7AC24EAB6D74118D(IntPtr plugin, bool p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Graphics__0x7B226C785A52A0A9(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Graphics__0x7FA5D82B8F58EC06(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x814AF7DCAACC597B(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Graphics__0x82ACC484FFA3B05F(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x851CD923176EBA7C(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x8CDE909A0370BB3A(IntPtr plugin, bool p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Graphics__0x90A78ECAA4E78453(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x949F397A288B28B3(IntPtr plugin, float p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Graphics__0x95EB5E34F821BABE(IntPtr plugin, ulong p0, ulong p1, ulong p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x9641588DAB93B4B5(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x967278682CB6967A(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x98EDF76A7271E4F2(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x99AC7F0D8B9C893D(IntPtr plugin, float p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x9B079E5221D984D3(IntPtr plugin, bool p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Graphics__0x9B6E70C5CEEF4EEB(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x9CFDD90B2B844BF7(IntPtr plugin, float p0, float p1, float p2, float p3, float p4);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0x9D75795B9DC6EBBF(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0xA356990E161C9E65(IntPtr plugin, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0xA44FF770DFBC5DAE(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Graphics__0xA4664972A9B8F8BA(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0xA46B73FAA3460AE1(IntPtr plugin, bool p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Graphics__0xA4819F5E23E2FFAD(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0xA51C4B86B71652AE(IntPtr plugin, bool p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Graphics__0xA67C35C56EB1BD9D(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0xA78DE25577300BA1(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0xAE51BC858F32BA66(IntPtr plugin, ulong p0, float p1, float p2, float p3, float p4);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0xB11D94BC55F41932(IntPtr plugin, IntPtr p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0xB1BB03742917A5D6(IntPtr plugin, int type, float xPos, float yPos, float zPos, float p4, int red, int green, int blue, int alpha);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Graphics__0xB2EBE8CBC58B90E9(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0xB3C641F3630BF6DA(IntPtr plugin, float p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0xB569F41F3E7E83A4(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0xB7ED70C49521A61D(IntPtr plugin, int decalType);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0xBA0127DA25FD54C9(IntPtr plugin, ulong p0, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0xBA3D194057C79A7B(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0xBA3D65906822BED5(IntPtr plugin, bool p0, bool p1, float p2, float p3, float p4, float p5);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0xBB90E12CAC1DAB25(IntPtr plugin, float p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0xBBF327DED94E4DEB(IntPtr plugin, IntPtr p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Graphics__0xBCEDB009461DA156(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0xBDEB86F4D5809204(IntPtr plugin, float p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Graphics__0xBE197EAA669238F4(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0xBEB3D46BB7F043C0(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0xBF59707B3E5ED531(IntPtr plugin, IntPtr p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0xC0416B061F2B7E5E(IntPtr plugin, bool p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0xC35A6D07C93802B2(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0xC5C8F970D4EDFF71(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0xC9B18B4619F48F7B(IntPtr plugin, float p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0xCA465D9CC0D231BA(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0xCA4AE345A153D573(IntPtr plugin, bool p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Graphics__0xCB82A0BF0E3E3265(IntPtr plugin, int p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0xD1C55B110E4DF534(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Graphics__0xD1C7CB175E012964(IntPtr plugin, int scaleformHandle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0xD2209BE128B5418C(IntPtr plugin, IntPtr graphicsName);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0xD2300034310557E4(IntPtr plugin, int vehicle, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0xD2936CAB8B58FCBD(IntPtr plugin, ulong p0, bool p1, float p2, float p3, float p4, float p5, bool p6, float p7);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0xD39D13C9FEBF0511(IntPtr plugin, bool p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Graphics__0xD3A10FC7FD8D98CD(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0xD7021272EB0A451E(IntPtr plugin, IntPtr p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0xD7D0B00177485411(IntPtr plugin, ulong p0, float p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0xD801CC02177FA3F1(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Graphics__0xD80A80346A45D761(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0xD9454B5752C857DC(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0xDBAA5EC848BA2D46(IntPtr plugin, ulong p0, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0xDC459CFA0CCE245B(IntPtr plugin, bool p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0xDE81239437E8C5A8(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0xE1C8709406F2C41C(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0xE2892E7E55D7073A(IntPtr plugin, float p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Graphics__0xE35B38A27E8E7179(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0xE3E2C1B4C59DBC77(IntPtr plugin, int unk);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Graphics__0xE59343E9E96529E7(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0xE63D7C6EECECB66B(IntPtr plugin, bool p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0xE6A9F00D4240B519(IntPtr plugin, ulong p0, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Graphics__0xE791DF1F73ED2C8B(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0xE82728F0DE75D13A(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4, ulong p5, ulong p6, ulong p7, ulong p8, ulong p9, ulong p10, ulong p11, ulong p12, ulong p13, ulong p14, ulong p15, ulong p16, ulong p17, ulong p18, ulong p19, ulong p20, ulong p21, ulong p22, ulong p23, ulong p24);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Graphics__0xEB3DAC2C86001E5E(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0xEC52C631A1831C03(IntPtr plugin, int p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Graphics__0xEC72C258667BE5EA(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0xEF398BEEE4EF45F9(IntPtr plugin, bool p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0xEFABC7722293DA7C(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0xEFB55E7C25D3B3BE(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0xEFD97FF47B745B8D(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Graphics__0xF1CEA8A4198D8E9A(IntPtr plugin, IntPtr p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0xF44A5456AC3F4F97(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0xF51D36185993515D(IntPtr plugin, int checkpoint, float posX, float posY, float posZ, float unkX, float unkY, float unkZ);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Graphics__0xF5BED327CEA362B1(IntPtr plugin, bool p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0xF78B803082D4386F(IntPtr plugin, float p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Graphics__0xFE26117A5841B2FF(IntPtr plugin, int vehicle, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0xFEBFBFDFB66039DE(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics__0xFF5992E1C9E65D05(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_PopTimecycleModifier(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_PushScaleformMovieMethodParameterButtonName(IntPtr plugin, IntPtr button);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_PushScaleformMovieMethodParameterString(IntPtr plugin, IntPtr value);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_PushScaleformMovieMethodParameterString2(IntPtr plugin, IntPtr value);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_PushTimecycleModifier(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_ReleaseMovieMeshSet(IntPtr plugin, int movieMeshSet);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_RemoveDecal(IntPtr plugin, int decal);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_RemoveDecalsFromObject(IntPtr plugin, int obj);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_RemoveDecalsFromObjectFacing(IntPtr plugin, int obj, float x, float y, float z);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_RemoveDecalsFromVehicle(IntPtr plugin, int vehicle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_RemoveDecalsInRange(IntPtr plugin, float x, float y, float z, float range);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_RemoveParticleFx(IntPtr plugin, int ptfxHandle, bool p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_RemoveParticleFxFromEntity(IntPtr plugin, int entity);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_RemoveParticleFxInRange(IntPtr plugin, float X, float Y, float Z, float radius);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_RequestHudScaleform(IntPtr plugin, int hudComponent);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Graphics_RequestScaleformMovie(IntPtr plugin, IntPtr scaleformName);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Graphics_RequestScaleformMovieInstance(IntPtr plugin, IntPtr scaleformName);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Graphics_RequestScaleformMovieInteractive(IntPtr plugin, IntPtr scaleformName);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_RequestStreamedTextureDict(IntPtr plugin, IntPtr textureDict, bool p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_ResetExtraTimecycleModifierStrength(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_ResetParticleFxAssetOldToNew(IntPtr plugin, IntPtr name);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_ResetScriptGfxAlign(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Graphics_ReturnTwo(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_ScaleformMovieMethodAddParamBool(IntPtr plugin, bool value);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_ScaleformMovieMethodAddParamFloat(IntPtr plugin, float value);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_ScaleformMovieMethodAddParamInt(IntPtr plugin, int value);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_SetArtificialLightsState(IntPtr plugin, bool state);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_SetCheckpointCylinderHeight(IntPtr plugin, int checkpoint, float nearHeight, float farHeight, float radius);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_SetCheckpointIconRgba(IntPtr plugin, int checkpoint, int red, int green, int blue, int alpha);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_SetCheckpointRgba(IntPtr plugin, int checkpoint, int red, int green, int blue, int alpha);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_SetCheckpointScale(IntPtr plugin, int checkpoint, float p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_SetDebugLinesAndSpheresDrawingActive(IntPtr plugin, bool enabled);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_SetDrawOrigin(IntPtr plugin, float x, float y, float z, ulong p3);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_SetEntityIconColor(IntPtr plugin, int entity, int red, int green, int blue, int alpha);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_SetEntityIconVisibility(IntPtr plugin, int entity, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_SetExtraTimecycleModifier(IntPtr plugin, IntPtr modifierName);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_SetExtraTimecycleModifierStrength(IntPtr plugin, float strength);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_SetFarShadowsSuppressed(IntPtr plugin, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_SetFlash(IntPtr plugin, float p0, float p1, float fadeIn, float duration, float fadeOut);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_SetForcePedFootstepsTracks(IntPtr plugin, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_SetForceVehicleTrails(IntPtr plugin, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_SetFrozenRenderingDisabled(IntPtr plugin, bool enabled);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_SetNightvision(IntPtr plugin, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_SetNoiseoveride(IntPtr plugin, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_SetNoisinessoveride(IntPtr plugin, float value);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_SetParticleFxAssetOldToNew(IntPtr plugin, IntPtr oldAsset, IntPtr newAsset);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_SetParticleFxBloodScale(IntPtr plugin, bool p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_SetParticleFxCamInsideNonplayerVehicle(IntPtr plugin, ulong p0, bool p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_SetParticleFxCamInsideVehicle(IntPtr plugin, bool p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_SetParticleFxLoopedAlpha(IntPtr plugin, int ptfxHandle, float alpha);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_SetParticleFxLoopedColour(IntPtr plugin, int ptfxHandle, float r, float g, float b, bool p4);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_SetParticleFxLoopedEvolution(IntPtr plugin, int ptfxHandle, IntPtr propertyName, float amount, bool Id);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_SetParticleFxLoopedOffsets(IntPtr plugin, int ptfxHandle, float x, float y, float z, float rotX, float rotY, float rotZ);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_SetParticleFxLoopedRange(IntPtr plugin, int ptfxHandle, float range);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_SetParticleFxLoopedScale(IntPtr plugin, int ptfxHandle, float scale);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_SetParticleFxNonLoopedAlpha(IntPtr plugin, float alpha);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_SetParticleFxNonLoopedColour(IntPtr plugin, float r, float g, float b);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_SetParticleFxShootoutBoat(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_SetScaleformMovieAsNoLongerNeeded(IntPtr plugin, ref int scaleformHandle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_SetScaleformMovieToUseSystemTime(IntPtr plugin, int scaleform, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_SetScriptGfxAlign(IntPtr plugin, int horizontalAlign, int verticalAlign);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_SetScriptGfxAlignParams(IntPtr plugin, float x, float y, float w, float h);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_SetScriptGfxDrawBehindPausemenu(IntPtr plugin, bool flag);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_SetScriptGfxDrawOrder(IntPtr plugin, int order);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_SetSeethrough(IntPtr plugin, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_SetStreamedTextureDictAsNoLongerNeeded(IntPtr plugin, IntPtr textureDict);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_SetTimecycleModifier(IntPtr plugin, IntPtr modifierName);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_SetTimecycleModifierStrength(IntPtr plugin, float strength);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_SetTrackedPointInfo(IntPtr plugin, int point, float x, float y, float z, float radius);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_SetTransitionTimecycleModifier(IntPtr plugin, IntPtr modifierName, float transition);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_SetTvAudioFrontend(IntPtr plugin, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_SetTvChannel(IntPtr plugin, int channel);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_SetTvVolume(IntPtr plugin, float volume);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Graphics_StartParticleFxLoopedAtCoord(IntPtr plugin, IntPtr effectName, float x, float y, float z, float xRot, float yRot, float zRot, float scale, bool xAxis, bool yAxis, bool zAxis, bool p11);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Graphics_StartParticleFxLoopedOnEntity(IntPtr plugin, IntPtr effectName, int entity, float xOffset, float yOffset, float zOffset, float xRot, float yRot, float zRot, float scale, bool xAxis, bool yAxis, bool zAxis);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Graphics_StartParticleFxLoopedOnEntityBone(IntPtr plugin, IntPtr effectName, int entity, float xOffset, float yOffset, float zOffset, float xRot, float yRot, float zRot, int boneIndex, float scale, bool xAxis, bool yAxis, bool zAxis);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Graphics_StartParticleFxLoopedOnEntityBone2(IntPtr plugin, IntPtr effectName, int entity, float xOffset, float yOffset, float zOffset, float xRot, float yRot, float zRot, int boneIndex, float scale, bool xAxis, bool yAxis, bool zAxis);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Graphics_StartParticleFxLoopedOnEntity2(IntPtr plugin, IntPtr effectName, int entity, float xOffset, float yOffset, float zOffset, float xRot, float yRot, float zRot, float scale, bool xAxis, bool yAxis, bool zAxis);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Graphics_StartParticleFxLoopedOnPedBone(IntPtr plugin, IntPtr effectName, int ped, float xOffset, float yOffset, float zOffset, float xRot, float yRot, float zRot, int boneIndex, float scale, bool xAxis, bool yAxis, bool zAxis);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Graphics_StartParticleFxNonLoopedAtCoord(IntPtr plugin, IntPtr effectName, float xPos, float yPos, float zPos, float xRot, float yRot, float zRot, float scale, bool xAxis, bool yAxis, bool zAxis);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Graphics_StartParticleFxNonLoopedAtCoord2(IntPtr plugin, IntPtr effectName, float xPos, float yPos, float zPos, float xRot, float yRot, float zRot, float scale, bool xAxis, bool yAxis, bool zAxis);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Graphics_StartParticleFxNonLoopedOnEntity(IntPtr plugin, IntPtr effectName, int entity, float offsetX, float offsetY, float offsetZ, float rotX, float rotY, float rotZ, float scale, bool axisX, bool axisY, bool axisZ);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Graphics_StartParticleFxNonLoopedOnEntity2(IntPtr plugin, IntPtr effectName, int entity, float offsetX, float offsetY, float offsetZ, float rotX, float rotY, float rotZ, float scale, bool axisX, bool axisY, bool axisZ);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Graphics_StartParticleFxNonLoopedOnPedBone(IntPtr plugin, IntPtr effectName, int ped, float offsetX, float offsetY, float offsetZ, float rotX, float rotY, float rotZ, int boneIndex, float scale, bool axisX, bool axisY, bool axisZ);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Graphics_StartParticleFxNonLoopedOnPedBone2(IntPtr plugin, IntPtr effectName, int ped, float offsetX, float offsetY, float offsetZ, float rotX, float rotY, float rotZ, int boneIndex, float scale, bool axisX, bool axisY, bool axisZ);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_StartScreenEffect(IntPtr plugin, IntPtr effectName, int duration, bool looped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_StopAllScreenEffects(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_StopParticleFxLooped(IntPtr plugin, int ptfxHandle, bool p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_StopScreenEffect(IntPtr plugin, IntPtr effectName);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Graphics_TransitionFromBlurred(IntPtr plugin, float transitionTime);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Graphics_TransitionToBlurred(IntPtr plugin, float transitionTime);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_UseParticleFxAssetNextCall(IntPtr plugin, IntPtr name);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_WashDecalsFromVehicle(IntPtr plugin, int vehicle, float p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Graphics_WashDecalsInRange(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4);
}
