using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CryV.Net.Native
{
    internal static partial class CryVNative
    {
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Vehicle_AddSpeedZoneForCoord(IntPtr plugin, float x, float y, float z, float radius, float speed, bool p5);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_AddVehicleStuckCheckWithWarp(IntPtr plugin, ulong p0, float p1, ulong p2, bool p3, bool p4, bool p5, ulong p6);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_AddVehicleUpsidedownCheck(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_AnyPassengersRappeling(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_AreAllVehicleWindowsIntact(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_AreAnyVehicleSeatsFree(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_AreBombBayDoorsOpen(IntPtr plugin, int aircraft);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_ArePropellersUndamaged(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_AreVehicleWingsIntact(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_AttachVehicleToCargobob(IntPtr plugin, int vehicle, int cargobob, int p2, float x, float y, float z);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_AttachVehicleToTowTruck(IntPtr plugin, int towTruck, int vehicle, bool rear, float hookOffsetX, float hookOffsetY, float hookOffsetZ);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_AttachVehicleToTrailer(IntPtr plugin, int vehicle, int trailer, float radius);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_CanShuffleSeat(IntPtr plugin, int vehicle, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_CanVehicleParachuteBeActivated(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Vehicle_ClearVehicleCustomPrimaryColour(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Vehicle_ClearVehicleCustomSecondaryColour(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_CloseBombBayDoors(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_ControlLandingGear(IntPtr plugin, int vehicle, int state);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Vehicle_CreateMissionTrain(IntPtr plugin, int variation, float x, float y, float z, bool direction);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_CreatePickUpRopeForCargobob(IntPtr plugin, int cargobob, int state);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Vehicle_CreateScriptVehicleGenerator(IntPtr plugin, float x, float y, float z, float heading, float p4, float p5, ulong modelHash, int p7, int p8, int p9, int p10, bool p11, bool p12, bool p13, bool p14, bool p15, int p16);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Vehicle_CreateVehicle(IntPtr plugin, ulong modelHash, float x, float y, float z, float heading, bool isNetwork, bool thisScriptCheck);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_DeleteAllTrains(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_DeleteMissionTrain(IntPtr plugin, ref int train);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_DeleteScriptVehicleGenerator(IntPtr plugin, int vehicleGenerator);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_DeleteVehicle(IntPtr plugin, ref int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_DetachVehicleFromAnyCargobob(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_DetachVehicleFromAnyTowTruck(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_DetachVehicleFromCargobob(IntPtr plugin, int vehicle, int cargobob);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_DetachVehicleFromTowTruck(IntPtr plugin, int towTruck, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_DetachVehicleFromTrailer(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_DetachVehicleWindscreen(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_DisablePlaneAileron(IntPtr plugin, int vehicle, bool p1, bool p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_DisableVehicleImpactExplosionActivation(IntPtr plugin, int vehicle, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_DisableVehicleNeonLights(IntPtr plugin, int vehicle, bool disable);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_DisableVehicleWeapon(IntPtr plugin, bool disabled, ulong weaponHash, int vehicle, int owner);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_DisplayDistantVehicles(IntPtr plugin, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_DoesCargobobHavePickupMagnet(IntPtr plugin, int cargobob);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_DoesCargobobHavePickUpRope(IntPtr plugin, int cargobob);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_DoesExtraExist(IntPtr plugin, int vehicle, int extraId);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_DoesScriptVehicleGeneratorExist(IntPtr plugin, int v);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_DoesVehicleExistWithDecorator(IntPtr plugin, IntPtr decorator);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_DoesVehicleHaveDoor(IntPtr plugin, int vehicle, int doorIndex);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_DoesVehicleHaveRoof(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_DoesVehicleHaveStuckVehicleCheck(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_DoesVehicleHaveWeapons(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_EjectJb700Roof(IntPtr plugin, int vehicle, float x, float y, float z);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_ExplodeVehicle(IntPtr plugin, int vehicle, bool isAudible, bool isInvisible);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_ExplodeVehicleInCutscene(IntPtr plugin, int vehicle, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Vehicle_FixVehicleWindow(IntPtr plugin, int vehicle, int index);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Vehicle_GetAircraftBombCount(IntPtr plugin, int aircraft);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Vehicle_GetAircraftCountermeasureCount(IntPtr plugin, int aircraft);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Vehicle_GetAllVehicles(IntPtr plugin, ref ulong vehArray);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_GetBoatAnchor(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Native_Vehicle_GetCargobobHookPosition(IntPtr plugin, int cargobob);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Vehicle_GetClosestVehicle(IntPtr plugin, float x, float y, float z, float radius, ulong modelHash, int flags);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Vehicle_GetConvertibleRoofState(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Vehicle_GetCurrentPlaybackForVehicle(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Native_Vehicle_GetDisplayNameFromVehicleModel(IntPtr plugin, ulong modelHash);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Vehicle_GetEntityAttachedToTowTruck(IntPtr plugin, int towTruck);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Native_Vehicle_GetEntryPositionOfDoor(IntPtr plugin, int vehicle, int doorIndex);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_GetHasLowerableWheels(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Vehicle_GetHeliEngineHealth(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Vehicle_GetHeliMainRotorHealth(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Vehicle_GetHeliTailRotorHealth(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_GetIsLeftVehicleHeadlightDamaged(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_GetIsRightVehicleHeadlightDamaged(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_GetIsVehicleEngineRunning(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_GetIsVehiclePrimaryColourCustom(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_GetIsVehicleSecondaryColourCustom(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Vehicle_GetLandingGearState(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Vehicle_GetLastDrivenVehicle(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Vehicle_GetLastPedInVehicleSeat(IntPtr plugin, int vehicle, int seatIndex);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Native_Vehicle_GetLiveryName(IntPtr plugin, int vehicle, int liveryIndex);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Native_Vehicle_GetModSlotName(IntPtr plugin, int vehicle, int modType);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Native_Vehicle_GetModTextLabel(IntPtr plugin, int vehicle, int modType, int modValue);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Vehicle_GetNumberOfVehicleColours(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Vehicle_GetNumberOfVehicleDoors(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Vehicle_GetNumberOfVehicleNumberPlates(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Vehicle_GetNumModColors(IntPtr plugin, int p0, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Vehicle_GetNumModKits(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Vehicle_GetNumVehicleMods(IntPtr plugin, int vehicle, int modType);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Vehicle_GetNumVehicleWindowTints(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Vehicle_GetPedInVehicleSeat(IntPtr plugin, int vehicle, int index);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Vehicle_GetPedUsingVehicleDoor(IntPtr plugin, int vehicle, int doorIndex);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Vehicle_GetPositionInRecording(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Native_Vehicle_GetPositionOfVehicleRecordingAtTime(IntPtr plugin, int p0, float p1, IntPtr p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Vehicle_GetRandomVehicleBackBumperInSphere(IntPtr plugin, float p0, float p1, float p2, float p3, int p4, int p5, int p6);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Vehicle_GetRandomVehicleFrontBumperInSphere(IntPtr plugin, float p0, float p1, float p2, float p3, int p4, int p5, int p6);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Vehicle_GetRandomVehicleInSphere(IntPtr plugin, float x, float y, float z, float radius, ulong modelHash, int flags);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_GetRandomVehicleModelInMemory(IntPtr plugin, bool p0, ref ulong modelHash, ref int p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Vehicle_GetRotationOfVehicleRecordingAtTime(IntPtr plugin, ulong p0, float p1, ref ulong p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Vehicle_GetTimePositionInRecording(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Vehicle_GetTotalDurationOfVehicleRecording(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Vehicle_GetTotalDurationOfVehicleRecordingId(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Vehicle_GetTrainCarriage(IntPtr plugin, int train, int trailerNumber);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Vehicle_GetVehicleAcceleration(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Vehicle_GetVehicleAttachedToCargobob(IntPtr plugin, int cargobob);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Vehicle_GetVehicleAttachedToEntity(IntPtr plugin, int @object);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Vehicle_GetVehicleBodyHealth(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Vehicle_GetVehicleBodyHealth2(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Vehicle_GetVehicleCauseOfDestruction(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Vehicle_GetVehicleClass(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Vehicle_GetVehicleClassFromName(IntPtr plugin, ulong modelHash);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Vehicle_GetVehicleClassMaxAcceleration(IntPtr plugin, int vehicleClass);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Vehicle_GetVehicleClassMaxAgility(IntPtr plugin, int vehicleClass);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Vehicle_GetVehicleClassMaxBraking(IntPtr plugin, int vehicleClass);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Vehicle_GetVehicleClassMaxSpeed(IntPtr plugin, int vehicleClass);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Vehicle_GetVehicleClassMaxTraction(IntPtr plugin, int vehicleClass);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_GetVehicleColor(IntPtr plugin, int vehicle, ref int r, ref int g, ref int b);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Vehicle_GetVehicleColourCombination(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_GetVehicleColours(IntPtr plugin, int vehicle, ref int colorPrimary, ref int colorSecondary);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_GetVehicleCustomPrimaryColour(IntPtr plugin, int vehicle, ref int r, ref int g, ref int b);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_GetVehicleCustomSecondaryColour(IntPtr plugin, int vehicle, ref int r, ref int g, ref int b);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_GetVehicleDashboardColour(IntPtr plugin, int vehicle, ref int color);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Native_Vehicle_GetVehicleDeformationAtPos(IntPtr plugin, int vehicle, float offsetX, float offsetY, float offsetZ);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Vehicle_GetVehicleDirtLevel(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Vehicle_GetVehicleDoorAngleRatio(IntPtr plugin, int vehicle, int door);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Vehicle_GetVehicleDoorLockStatus(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_GetVehicleDoorsLockedForPlayer(IntPtr plugin, int vehicle, int player);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Vehicle_GetVehicleEngineHealth(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Vehicle_GetVehicleEnveffScale(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_GetVehicleExtraColours(IntPtr plugin, int vehicle, ref int pearlescentColor, ref int wheelColor);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Vehicle_GetVehicleHeadlightsColour(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Vehicle_GetVehicleHoverModePercentage(IntPtr plugin, int aircraft);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_GetVehicleInteriorColour(IntPtr plugin, int vehicle, ref int color);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Vehicle_GetVehicleLayoutHash(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_GetVehicleLightsState(IntPtr plugin, int vehicle, ref bool lightsOn, ref bool highbeamsOn);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Vehicle_GetVehicleLivery(IntPtr plugin, int trailers2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Vehicle_GetVehicleLiveryCount(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Vehicle_GetVehicleMaxBraking(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Vehicle_GetVehicleMaxNumberOfPassengers(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Vehicle_GetVehicleMaxSpeed(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Vehicle_GetVehicleMaxTraction(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Vehicle_GetVehicleMod(IntPtr plugin, int vehicle, int modType);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_GetVehicleModColor1(IntPtr plugin, int vehicle, ref int paintType, ref int color, ref int pearlescentColor);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Native_Vehicle_GetVehicleModColor1Name(IntPtr plugin, int vehicle, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_GetVehicleModColor2(IntPtr plugin, int vehicle, ref int paintType, ref int color);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Native_Vehicle_GetVehicleModColor2Name(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Vehicle_GetVehicleModData(IntPtr plugin, int vehicle, int modType, int modIndex);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Vehicle_GetVehicleModelAcceleration(IntPtr plugin, ulong modelHash);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Vehicle_GetVehicleModelDownForce(IntPtr plugin, ulong modelHash);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Vehicle_GetVehicleModelHandBrake(IntPtr plugin, ulong modelHash);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Vehicle_GetVehicleModelMaxBraking(IntPtr plugin, ulong modelHash);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Vehicle_GetVehicleModelMaxKnots(IntPtr plugin, ulong modelHash);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Vehicle_GetVehicleModelMaxSpeed(IntPtr plugin, ulong modelHash);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Vehicle_GetVehicleModelMaxTraction(IntPtr plugin, ulong modelHash);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Vehicle_GetVehicleModelMoveResistance(IntPtr plugin, ulong modelHash);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Vehicle_GetVehicleModelNumberOfSeats(IntPtr plugin, ulong modelHash);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Vehicle_GetVehicleModKit(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Vehicle_GetVehicleModKitType(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Vehicle_GetVehicleModModifierValue(IntPtr plugin, int vehicle, int modType, int modIndex);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_GetVehicleModVariation(IntPtr plugin, int vehicle, int modType);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_GetVehicleNeonLightsColour(IntPtr plugin, int vehicle, ref int r, ref int g, ref int b);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Vehicle_GetVehicleNumberOfPassengers(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Native_Vehicle_GetVehicleNumberPlateText(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Vehicle_GetVehicleNumberPlateTextIndex(IntPtr plugin, int elegy);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_GetVehicleOwner(IntPtr plugin, int vehicle, ref int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Vehicle_GetVehiclePetrolTankHealth(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Vehicle_GetVehiclePlateType(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Vehicle_GetVehicleRecordingId(IntPtr plugin, int p0, IntPtr p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Vehicle_GetVehicleSuspensionHeight(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_GetVehicleTrailerVehicle(IntPtr plugin, int vehicle, ref int trailer);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_GetVehicleTyresCanBurst(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_GetVehicleTyreSmokeColor(IntPtr plugin, int vehicle, ref int r, ref int g, ref int b);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Vehicle_GetVehicleWheelType(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Vehicle_GetVehicleWindowTint(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_HasPreloadModsFinished(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_HasVehicleAssetLoaded(IntPtr plugin, int vehicleAsset);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_HasVehicleJumpingAbility(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_HasVehicleParachute(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_HasVehicleRecordingBeenLoaded(IntPtr plugin, ulong p0, ref ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_HasVehicleRocketBoost(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_IsAnyVehicleNearPoint(IntPtr plugin, float x, float y, float z, float radius);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_IsBigVehicle(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_IsCopVehicleInArea3D(IntPtr plugin, float x1, float x2, float y1, float y2, float z1, float z2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_IsHeliPartBroken(IntPtr plugin, int vehicle, bool p1, bool p2, bool p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_IsPlaybackGoingOnForVehicle(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_IsPlaybackUsingAiGoingOnForVehicle(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_IsTaxiLightOn(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_IsThisModelABicycle(IntPtr plugin, ulong model);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_IsThisModelABike(IntPtr plugin, ulong model);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_IsThisModelABoat(IntPtr plugin, ulong model);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_IsThisModelACar(IntPtr plugin, ulong model);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_IsThisModelAHeli(IntPtr plugin, ulong model);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_IsThisModelAJetski(IntPtr plugin, ulong model);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_IsThisModelAnAmphibiousCar(IntPtr plugin, ulong model);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_IsThisModelAPlane(IntPtr plugin, ulong model);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_IsThisModelAQuadbike(IntPtr plugin, ulong model);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_IsThisModelATrain(IntPtr plugin, ulong model);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_IsToggleModOn(IntPtr plugin, int vehicle, int modType);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_IsVehicleAConvertible(IntPtr plugin, int vehicle, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_IsVehicleAlarmActivated(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_IsVehicleAttachedToCargobob(IntPtr plugin, int cargobob, int vehicleAttached);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_IsVehicleAttachedToTowTruck(IntPtr plugin, int towTruck, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_IsVehicleAttachedToTrailer(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_IsVehicleBumperBrokenOff(IntPtr plugin, int vehicle, bool front);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_IsVehicleDamaged(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_IsVehicleDoorDamaged(IntPtr plugin, int veh, int doorID);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_IsVehicleDoorFullyOpen(IntPtr plugin, int vehicle, int doorIndex);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_IsVehicleDriveable(IntPtr plugin, int vehicle, bool isOnFireCheck);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_IsVehicleEngineOnFire(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_IsVehicleExtraTurnedOn(IntPtr plugin, int vehicle, int extraId);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_IsVehicleHighDetail(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_IsVehicleInBurnout(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_IsVehicleInGarageArea(IntPtr plugin, IntPtr garageName, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_IsVehicleModel(IntPtr plugin, int vehicle, ulong model);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_IsVehicleModLoadDone(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_IsVehicleNeonLightEnabled(IntPtr plugin, int vehicle, int index);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_IsVehicleOnAllWheels(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_IsVehicleRocketBoostActive(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_IsVehicleSearchlightOn(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_IsVehicleSeatFree(IntPtr plugin, int vehicle, int seatIndex);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_IsVehicleShopResprayAllowed(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_IsVehicleSirenOn(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_IsVehicleSirenSoundOn(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_IsVehicleStolen(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_IsVehicleStopped(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_IsVehicleStoppedAtTrafficLights(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_IsVehicleStuckOnRoof(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_IsVehicleStuckTimerUp(IntPtr plugin, int vehicle, int p1, int p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_IsVehicleTyreBurst(IntPtr plugin, int vehicle, int wheelID, bool completely);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_IsVehicleVisible(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_IsVehicleWindowIntact(IntPtr plugin, int vehicle, int windowIndex);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_JitterVehicle(IntPtr plugin, int vehicle, bool p1, float yaw, float pitch, float roll);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_LowerConvertibleRoof(IntPtr plugin, int vehicle, bool instantlyLower);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x02398B627547189C(IntPtr plugin, int p0, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Vehicle__0x0419B167EE128F33(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x0581730AB9380412(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4, ulong p5);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x063AE2B2CC273588(IntPtr plugin, ulong p0, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x06582AFF74894C75(IntPtr plugin, int vehicle, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x065D03A9D6B2C6B5(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x0A436B8643716D14(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x0A6A279F3AA4FD70(IntPtr plugin, int vehicle, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x0AD9E8F87FF7C16F(IntPtr plugin, ulong p0, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x0CDDA42F9E360CA6(IntPtr plugin, int vehicle, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x0D5F65A8F4EBDAB5(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x0F3B4D4E43177236(IntPtr plugin, ulong p0, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x10655FAB9915623D(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x1087BC8EC540DAEB(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x1093408B4B9D1146(IntPtr plugin, ulong p0, float p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x1201E8A3290A3B98(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x1312DDD8385AEE4E(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x16B5E274BDE402F8(IntPtr plugin, int vehicle, int trailer, float p2, float p3, float p4, float p5, float p6, float p7, float p8, float p9, float p10, float p11);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x182F266C2D9E2BEB(IntPtr plugin, int vehicle, float p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x192547247864DFDD(IntPtr plugin, int vehicle, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x1A78AD3D8240536F(IntPtr plugin, int vehicle, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x1AA8A837D2169D94(IntPtr plugin, int vehicle, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x1B212B26DD3C04DF(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x1BBAC99C0BC53656(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x1D97D1E3A70A649F(IntPtr plugin, int vehicle, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Vehicle__0x1DA0DA9CB3F0C8BF(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x1DDA078D12879EEE(IntPtr plugin, ulong p0, ulong p1, ulong p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x1F2E4E06DEA8992B(IntPtr plugin, ulong p0, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x1F34B0626C594380(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x1F9FB66F3A3842D2(IntPtr plugin, int vehicle, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x206BC5DC9D1AC70A(IntPtr plugin, int vehicle, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x21115BCD6E44656A(IntPtr plugin, ulong p0, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x21973BBF8D17EDFA(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x2311DD7159F00582(IntPtr plugin, int vehicle, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Vehicle__0x2467A2D807D37CA3(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x25367DE49D64CF16(IntPtr plugin, int vehicle, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x26D99D5A82FD18E8(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x279D50DE5652D935(IntPtr plugin, ulong p0, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle__0x27B926779DEB502D(IntPtr plugin, int vehicle, bool frontBumper);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x28B18377EB6E25F6(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x2A86A0475B6A1434(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x2A8F319B392E7B3F(IntPtr plugin, int vehicle, float p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Vehicle__0x2B6747FAA9DB9D6B(IntPtr plugin, int vehicle, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Vehicle__0x2C1D8B3B19E517CC(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x2C4A1590ABF43E8B(IntPtr plugin, int vehicle, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Vehicle__0x2C8CBFE1EA5FC631(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x2FA2494B47FDD009(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x32CAEDF24A583345(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x33506883545AC0DF(IntPtr plugin, int vehicle, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x3441CAD2F2231923(IntPtr plugin, int vehicle, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x35BB21DE06784373(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x35E0654F4BAD7971(IntPtr plugin, bool p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Vehicle__0x36492C2F0D134C56(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x374706271354CB18(IntPtr plugin, int vehicle, int p1, float p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x3B458DDB57038F08(IntPtr plugin, ulong p0, ulong p1, ulong p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Vehicle__0x3DE51E9C80B116CF(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x4056EA1105F5ABD7(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x41290B40FA63E6DA(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x428AD3E26C8D9EB0(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x428BACCDF5E26EAD(IntPtr plugin, int vehicle, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Vehicle__0x42A4BEB35D372407(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x4419966C9936071A(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x44CD1F493DB2A0A6(IntPtr plugin, ulong p0, ulong p1, ulong p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Vehicle__0x45A561A9421AB6AD(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x48ADC8A773564670(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Vehicle__0x48C633E94A8142A7(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Vehicle__0x4C815EB175086F84(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x4D9D109F63FEE1D4(IntPtr plugin, ulong p0, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Vehicle__0x4E20D2A627011E8E(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Vehicle__0x4E417C547182C84D(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x4E74E62E0A97E901(IntPtr plugin, int vehicle, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x500873A45724C863(IntPtr plugin, int vehicle, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Vehicle__0x50634E348C8D44EF(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x51BB2D88D31A914B(IntPtr plugin, int vehicle, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x51DB102F4A3BA5E0(IntPtr plugin, bool p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x5335BE58C083E74E(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x544996C0081ABDEB(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Vehicle__0x54B0F614960F4A5F(IntPtr plugin, float p0, float p1, float p2, float p3, float p4, float p5, float p6);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Vehicle__0x563B65A643ED072E(IntPtr plugin, ulong p0, ulong p1, ulong p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x56B94C6D7127DFBA(IntPtr plugin, ulong p0, float p1, bool p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x56EB5E94318D3FB6(IntPtr plugin, int vehicle, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x571FEB383F629926(IntPtr plugin, int cargobob, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x5845066D8A1EA7F7(IntPtr plugin, int vehicle, float x, float y, float z, ulong p4);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Vehicle__0x5873C14A52D74236(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x5B91B229243351A8(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Vehicle__0x5BA68A0840D546AC(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x5E569EC46EC21CAE(IntPtr plugin, int vehicle, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Vehicle__0x5ECB40269053C0D4(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x5EE5632F47AE9695(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Vehicle__0x60190048C0764A26(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle__0x62CA17B74C435651(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle__0x634148744F385576(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle__0x639431E895B9AA57(IntPtr plugin, int ped, int vehicle, bool p2, bool p3, bool p4);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x6501129C9E0FFA05(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x65B080555EA48149(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Vehicle__0x6636C535F6CC2725(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x66979ACF5102FD2F(IntPtr plugin, int cargobob, float p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x66E3AAFACE2D1EB8(IntPtr plugin, ulong p0, ulong p1, ulong p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x685D5561680D088B(IntPtr plugin, int vehicle, float p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x6A98C2ECF57FA5D4(IntPtr plugin, int vehicle, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Vehicle__0x6ADAABD3068C5235(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x6D6AF961B72728AE(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x6D8EAC07506291FB(IntPtr plugin, int cargobob, float p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Vehicle__0x6EAAEFC76ACC311F(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x6EBFB22D646FFC18(IntPtr plugin, int vehicle, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Vehicle__0x725012A415DBA050(IntPtr plugin, ulong p0, ref ulong p1, ulong p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x72BECCF4B829522E(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x73561D4425A021A2(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x737E398138550FFF(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x756AE6E962168A04(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x76D26A22750E849E(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x78CEEE41F49F421F(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x796A877E459B99EA(IntPtr plugin, ulong p0, float p1, float p2, float p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x79DF7E806202CE01(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x7BBE7FF626A591FE(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x7C0043FDFF6436BC(IntPtr plugin, int x);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x7C06330BFDDA182E(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x7D6F9A3EF26136A0(IntPtr plugin, int vehicle, bool p1, bool p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x80E3357FDEF45C21(IntPtr plugin, int vehicle, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Vehicle__0x8181CE2F25CB9BB7(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x84EA99C62CB3EF0C(IntPtr plugin, ulong p0, ulong p1, ulong p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Vehicle__0x8533CAFDE1F0F336(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x86B4B6212CB8B627(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x870B8B7A766615C8(IntPtr plugin, ulong p0, ulong p1, ulong p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Vehicle__0x878C75C09FBDB942(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x88BC673CA9E0AE99(IntPtr plugin, int vehicle, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle__0x89D630CF5EA96D23(IntPtr plugin, int vehicle, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x8AA9180DE2FEDD45(IntPtr plugin, int vehicle, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x8EA86DF356801C7D(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x8F719973E1445BA2(IntPtr plugin, int vehicle, int p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x9007A2F21DC108D4(IntPtr plugin, ulong p0, float p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x91A0BD635321F145(IntPtr plugin, int vehicle, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle__0x91D6DD290888CBAB(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Vehicle__0x92523B76657A517D(IntPtr plugin, ulong p0, float p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x95CF53B3D687F9FA(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x9737A37136F07E75(IntPtr plugin, int vehicle, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Vehicle__0x99093F60746708CA(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x99AD4CCCB128CBC9(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x99CAD8E7AFDB60FA(IntPtr plugin, int vehicle, float p1, float p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x9A75585FB2E54FAD(IntPtr plugin, float p0, float p1, float p2, float p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x9BDDC73CC6A115D4(IntPtr plugin, int vehicle, bool p1, bool p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x9BECD4B9FEF3F8A6(IntPtr plugin, int vehicle, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x9D30687C57BAA0BB(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0x9F3F689B814F2599(IntPtr plugin, int vehicle, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Vehicle__0xA01BC64DD4BFBBAC(IntPtr plugin, int vehicle, int p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0xA17BAD153B51547E(IntPtr plugin, int cargobob, float p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Vehicle__0xA1A9FC1C76A6730D(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0xA1DD82F3CCF9A01E(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4, ulong p5);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0xA247F9EF01D8082E(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0xA7DCDF4DED40A8F4(IntPtr plugin, int vehicle, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0xAA3F739ABDDCF21F(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0xAB04325045427AAE(IntPtr plugin, int vehicle, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0xAB31EF4DE6800CE9(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle__0xAE3FEE8709B39DCB(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Vehicle__0xAF03011701811146(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0xAF60E6A2936F982A(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0xB055A34527CB8FD7(IntPtr plugin, int vehicle, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0xB088E9A47AE6EDD5(IntPtr plugin, int vehicle, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Vehicle__0xB09D25E77C33EB3F(IntPtr plugin, ulong p0, ulong p1, ulong p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Vehicle__0xB0AD1238A709B1A2(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0xB264C4D2F2B0A78B(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0xB28B1FE5BFADD7F5(IntPtr plugin, int vehicle, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0xB2E0C0D6922D31F2(IntPtr plugin, int vehicle, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0xB9562064627FF9DB(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Vehicle__0xBA91D045575699AD(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0xBAA045B4E42F3C06(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0xBB2333BB87DDD87F(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0xBC3CCA5844452B06(IntPtr plugin, float p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0xBD32E46AA95C1DD2(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0xBE5C1255A1830FF5(IntPtr plugin, int vehicle, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0xC0ED6438E6D39BA8(IntPtr plugin, ulong p0, ulong p1, ulong p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0xC1F981A6F74F0C23(IntPtr plugin, ulong p0, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0xC24075310A8B9CD1(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0xC361AA040D6637A8(IntPtr plugin, int vehicle, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0xC45C27EF50F36ADC(IntPtr plugin, int vehicle, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0xC4B3347BD68BD609(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0xC50CE861B55EAB8B(IntPtr plugin, int vehicle, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Vehicle__0xCA4AC3EAAE46EC7B(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0xCAC66558B944DA67(IntPtr plugin, IntPtr vehicle, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0xCF1182F682F65307(IntPtr plugin, ulong p0, int p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0xCF9159024555488C(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0xCFD778E7904C255E(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0xD3301660A57C9272(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Vehicle__0xD3E51C0AB8C26EEE(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Vehicle__0xD4196117AF7BB974(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle__0xD4C4642CB7F50B5D(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0xD565F438137F0E10(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0xDBA3C090E3D74690(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0xDBC631F109350B8C(IntPtr plugin, int vehicle, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Vehicle__0xDCE97BDF8A0EABC8(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0xDFFCEF48E511DB48(IntPtr plugin, ulong p0, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0xE01903C47C7AC89E(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0xE05DD0E9707003A3(IntPtr plugin, ulong p0, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0xE16142B94664DEFD(IntPtr plugin, int vehicle, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0xE2F53F172B45EDE1(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0xE301BD63E9E13CF0(IntPtr plugin, int vehicle, int cargobob);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0xE30524E1871F481D(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle__0xE33FFA906CE74880(IntPtr plugin, int vehicle, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0xE3EBAAE484798530(IntPtr plugin, int vehicle, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0xE44A982368A4AF23(IntPtr plugin, int vehicle, int vehicle2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0xE4E2FD323574965C(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0xE5810AC70602F2F5(IntPtr plugin, int vehicle, float p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Vehicle__0xE6B0E8CFC3633BF0(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0xE6C0C80B8C867537(IntPtr plugin, bool p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0xE6F13851780394DA(IntPtr plugin, int vehicle, float p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0xE842A9398079BD82(IntPtr plugin, int vehicle, float p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0xE851E480B814D4BA(IntPtr plugin, int vehicle, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0xED5EDE9E676643C9(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0xED8286F71A819BAA(IntPtr plugin, int cargobob, float p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0xEDBC8405B3895CC9(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Vehicle__0xEEBFC7A7EFDC35B4(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0xEFC13B1CE30D755D(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0xF051D9BFB6BA39C0(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0xF06A16CA55D138D8(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0xF0E4BA16D1DB546C(IntPtr plugin, int vehicle, int p1, int p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Native_Vehicle__0xF0F2103EFAF8CBA7(IntPtr plugin, ulong p0, float p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0xF25E02CB9C5818F8(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Vehicle__0xF3B0E0AED097A3F5(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0xF488C566413B4232(IntPtr plugin, ulong p0, float p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle__0xF78F94D60248C737(IntPtr plugin, ulong p0, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle__0xF7F203E31F96F6A1(IntPtr plugin, int vehicle, bool flag);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0xF87D9F2301F7D206(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0xF8EBCCC96ADB9FB7(IntPtr plugin, ulong p0, float p1, bool p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0xFAF2A78061FD9EF4(IntPtr plugin, ulong p0, float p1, float p2, float p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0xFC40CBF7B90CA77C(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle__0xFE205F38AAA58E5B(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_OpenBombBayDoors(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_PausePlaybackRecordedVehicle(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_PreloadVehicleMod(IntPtr plugin, ulong p0, int modType, ulong p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_RaiseConvertibleRoof(IntPtr plugin, int vehicle, bool instantlyRaise);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_RaiseLowerableWheels(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_ReleasePreloadMods(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_RemovePickUpRopeForCargobob(IntPtr plugin, int cargobob);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_RemoveSpeedZone(IntPtr plugin, int speedzone);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_RemoveVehicleAsset(IntPtr plugin, int vehicleAsset);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_RemoveVehicleHighDetailModel(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_RemoveVehicleMod(IntPtr plugin, int vehicle, int modType);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_RemoveVehicleRecording(IntPtr plugin, ulong p0, ref ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_RemoveVehiclesFromGeneratorsInArea(IntPtr plugin, float x1, float y1, float z1, float x2, float y2, float z2, ulong unk);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_RemoveVehicleStuckCheck(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_RemoveVehicleUpsidedownCheck(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_RemoveVehicleWindow(IntPtr plugin, int vehicle, int windowIndex);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_RequestVehicleAsset(IntPtr plugin, ulong vehicleHash, int vehicleAsset);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_RequestVehicleHighDetailModel(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_RequestVehiclePhoneExplosion(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_RequestVehicleRecording(IntPtr plugin, int i, IntPtr name);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_ResetVehicleStuckTimer(IntPtr plugin, int vehicle, int nullAttributes);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_ResetVehicleWheels(IntPtr plugin, int vehicle, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Vehicle_RollDownWindow(IntPtr plugin, int vehicle, int windowIndex);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_RollDownWindows(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Vehicle_RollUpWindow(IntPtr plugin, int vehicle, int windowIndex);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetAircraftBombCount(IntPtr plugin, int aircraft, int bombCount);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetAircraftCountermeasureCount(IntPtr plugin, int aircraft, int count);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetAllLowPriorityVehicleGeneratorsActive(IntPtr plugin, bool active);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetAllVehicleGeneratorsActive(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetAllVehicleGeneratorsActiveInArea(IntPtr plugin, float x1, float y1, float z1, float x2, float y2, float z2, bool p6, bool p7);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Vehicle_SetAllVehiclesSpawn(IntPtr plugin, int p0, bool p1, bool p2, bool p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetBikeLeanAngle(IntPtr plugin, int vehicle, float x, float y);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetBoatAnchor(IntPtr plugin, int vehicle, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetCanResprayVehicle(IntPtr plugin, int vehicle, bool state);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetCargobobHookPosition(IntPtr plugin, int cargobob, float xOffset, float yOffset, int state);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetCargobobPickupMagnetActive(IntPtr plugin, int cargobob, bool isActive);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetCargobobPickupMagnetStrength(IntPtr plugin, int cargobob, float strength);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetCarHighSpeedBumpSeverityMultiplier(IntPtr plugin, float multiplier);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetConvertibleRoof(IntPtr plugin, int vehicle, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetDesiredVerticalFlightPhase(IntPtr plugin, int vehicle, float angleRatio);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetDisableVehiclePetrolTankDamage(IntPtr plugin, int vehicle, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetDisableVehiclePetrolTankFires(IntPtr plugin, int vehicle, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetFarDrawVehicles(IntPtr plugin, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetForceHdVehicle(IntPtr plugin, int vehicle, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetForkliftForkHeight(IntPtr plugin, int vehicle, float height);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Vehicle_SetGarbageTrucks(IntPtr plugin, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetHeliBladesFullSpeed(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetHeliBladesSpeed(IntPtr plugin, int vehicle, float speed);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetHelicopterRollPitchYawMult(IntPtr plugin, int helicopter, float multiplier);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetLastDrivenVehicle(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetMissionTrainAsNoLongerNeeded(IntPtr plugin, ref int train, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetMissionTrainCoords(IntPtr plugin, int train, float x, float y, float z);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Vehicle_SetNumberOfParkedVehicles(IntPtr plugin, int value);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetParkedVehicleDensityMultiplierThisFrame(IntPtr plugin, float multiplier);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_SetPedEnabledBikeRingtone(IntPtr plugin, int vehicle, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetPedTargettableVehicleDestroy(IntPtr plugin, int vehicle, int doorIndex, int destroyType);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetPlaneMinHeightAboveTerrain(IntPtr plugin, int plane, int height);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetPlaneTurbulenceMultiplier(IntPtr plugin, int vehicle, float multiplier);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetPlaybackSpeed(IntPtr plugin, int vehicle, float speed);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetPlaybackToUseAi(IntPtr plugin, int vehicle, int flag);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetPlaybackToUseAiTryToRevertBackLater(IntPtr plugin, ulong p0, ulong p1, ulong p2, bool p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Vehicle_SetPlayersLastVehicle(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetRampVehicleReceivesRampDamage(IntPtr plugin, int vehicle, bool receivesDamage);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Vehicle_SetRandomBoats(IntPtr plugin, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetRandomTrains(IntPtr plugin, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetRandomVehicleDensityMultiplierThisFrame(IntPtr plugin, float multiplier);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetRenderTrainAsDerailed(IntPtr plugin, int train, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetScriptVehicleGenerator(IntPtr plugin, int vehicleGenerator, bool enabled);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetSomethingMultiplierThisFrame(IntPtr plugin, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetSomeVehicleDensityMultiplierThisFrame(IntPtr plugin, float value);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetTaxiLights(IntPtr plugin, int vehicle, bool state);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetTowTruckCraneHeight(IntPtr plugin, int towTruck, float height);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Vehicle_SetTrainCruiseSpeed(IntPtr plugin, int train, float speed);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Vehicle_SetTrainSpeed(IntPtr plugin, int train, float speed);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleAlarm(IntPtr plugin, int vehicle, bool state);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleAllowNoPassengersLockon(IntPtr plugin, int veh, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Vehicle_SetVehicleAutomaticallyAttaches(IntPtr plugin, int vehicle, bool p1, ulong p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleBodyHealth(IntPtr plugin, int vehicle, float value);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleBrakeLights(IntPtr plugin, int vehicle, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleBurnout(IntPtr plugin, int vehicle, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleCanBeTargetted(IntPtr plugin, int vehicle, bool state);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleCanBeUsedByFleeingPeds(IntPtr plugin, int vehicle, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleCanBeVisiblyDamaged(IntPtr plugin, int vehicle, bool state);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleCanBreak(IntPtr plugin, int vehicle, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleCeilingHeight(IntPtr plugin, int vehicle, float p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleColourCombination(IntPtr plugin, int vehicle, int colorCombination);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleColours(IntPtr plugin, int vehicle, int colorPrimary, int colorSecondary);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleCustomPrimaryColour(IntPtr plugin, int vehicle, int r, int g, int b);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleCustomSecondaryColour(IntPtr plugin, int vehicle, int r, int g, int b);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleDamage(IntPtr plugin, int vehicle, float xOffset, float yOffset, float zOffset, float damage, float radius, bool p6);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleDashboardColour(IntPtr plugin, int vehicle, int color);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleDeformationFixed(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleDensityMultiplierThisFrame(IntPtr plugin, float multiplier);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleDirtLevel(IntPtr plugin, int vehicle, float dirtLevel);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleDoorBroken(IntPtr plugin, int vehicle, int doorIndex, bool deleteDoor);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleDoorCanBreak(IntPtr plugin, int vehicle, int doorIndex, bool isBreakable);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleDoorControl(IntPtr plugin, int vehicle, int doorIndex, int speed, float angle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleDoorLatched(IntPtr plugin, int vehicle, int doorIndex, bool forceClose, bool @lock, bool p4);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleDoorOpen(IntPtr plugin, int vehicle, int doorIndex, bool loose, bool openInstantly);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleDoorShut(IntPtr plugin, int vehicle, int doorIndex, bool closeInstantly);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleDoorsLocked(IntPtr plugin, int vehicle, int doorLockStatus);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleDoorsLockedForAllPlayers(IntPtr plugin, int vehicle, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleDoorsLockedForPlayer(IntPtr plugin, int vehicle, int player, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleDoorsLockedForTeam(IntPtr plugin, int vehicle, int team, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleDoorsShut(IntPtr plugin, int vehicle, bool closeInstantly);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleDropsMoneyWhenBlownUp(IntPtr plugin, int vehicle, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleEngineCanDegrade(IntPtr plugin, int vehicle, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleEngineHealth(IntPtr plugin, int vehicle, float health);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleEngineOn(IntPtr plugin, int vehicle, bool value, bool instantly, bool otherwise);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleEnginePowerMultiplier(IntPtr plugin, int vehicle, float value);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleEngineTorqueMultiplier(IntPtr plugin, int vehicle, float value);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleEnveffScale(IntPtr plugin, int vehicle, float fade);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleExclusiveDriver(IntPtr plugin, int vehicle, int ped);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleExclusiveDriver2(IntPtr plugin, int vehicle, int ped, int p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleExplodesOnHighExplosionDamage(IntPtr plugin, int vehicle, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleExtra(IntPtr plugin, int vehicle, int extraId, bool disable);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleExtraColours(IntPtr plugin, int vehicle, int pearlescentColor, int wheelColor);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleFixed(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleForwardSpeed(IntPtr plugin, int vehicle, float speed);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleFrictionOverride(IntPtr plugin, int vehicle, float friction);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleFullbeam(IntPtr plugin, int vehicle, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleGravity(IntPtr plugin, int vehicle, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleHalt(IntPtr plugin, int vehicle, float distance, int killEngine, bool unknown);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleHandbrake(IntPtr plugin, int vehicle, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleHasBeenOwnedByPlayer(IntPtr plugin, int vehicle, bool owned);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleHasStrongAxles(IntPtr plugin, int vehicle, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleHeadlightsColour(IntPtr plugin, int vehicle, int color);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleHudSpecialAbilityBarActive(IntPtr plugin, int vehicle, bool active);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleIndicatorLights(IntPtr plugin, int vehicle, int turnSignal, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleInteriorColour(IntPtr plugin, int vehicle, int color);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleInteriorlight(IntPtr plugin, int vehicle, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleIsConsideredByPlayer(IntPtr plugin, int vehicle, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Vehicle_SetVehicleIsStolen(IntPtr plugin, int vehicle, bool isStolen);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleIsWanted(IntPtr plugin, int vehicle, bool state);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleJetEngineOn(IntPtr plugin, int vehicle, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleLightMultiplier(IntPtr plugin, int vehicle, float multiplier);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleLights(IntPtr plugin, int vehicle, int state);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleLightsMode(IntPtr plugin, int vehicle, int p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleLivery(IntPtr plugin, int vehicle, int liveryIndex);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleLodMultiplier(IntPtr plugin, int vehicle, float multiplier);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleMod(IntPtr plugin, int vehicle, int modType, int modIndex, bool customTires);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleModColor1(IntPtr plugin, int vehicle, int paintType, int color, int p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleModColor2(IntPtr plugin, int vehicle, int paintType, int color);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleModelIsSuppressed(IntPtr plugin, ulong model, bool suppressed);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleModKit(IntPtr plugin, int vehicle, int modKit);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleNameDebug(IntPtr plugin, int vehicle, IntPtr name);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleNeedsToBeHotwired(IntPtr plugin, int vehicle, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleNeonLightEnabled(IntPtr plugin, int vehicle, int index, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleNeonLightsColour(IntPtr plugin, int vehicle, int r, int g, int b);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleNumberPlateText(IntPtr plugin, int vehicle, IntPtr plateText);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleNumberPlateTextIndex(IntPtr plugin, int vehicle, int plateIndex);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_SetVehicleOnGroundProperly(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleOutOfControl(IntPtr plugin, int vehicle, bool killDriver, bool explodeOnImpact);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleParachuteActive(IntPtr plugin, int vehicle, bool active);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehiclePetrolTankHealth(IntPtr plugin, int vehicle, float health);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleProvidesCover(IntPtr plugin, int vehicle, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleReduceGrip(IntPtr plugin, int vehicle, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleRocketBoostActive(IntPtr plugin, int vehicle, bool active);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleRocketBoostPercentage(IntPtr plugin, int vehicle, float percentage);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleRocketBoostRefillTime(IntPtr plugin, int vehicle, float time);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleRoofLivery(IntPtr plugin, int vehicle, int livery);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleRudderBroken(IntPtr plugin, int vehicle, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleSearchlight(IntPtr plugin, int heli, bool toggle, bool canBeUsedByAI);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleShootAtTarget(IntPtr plugin, int driver, int entity, float xTarget, float yTarget, float zTarget);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleSilent(IntPtr plugin, int vehicle, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleSiren(IntPtr plugin, int vehicle, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleSt(IntPtr plugin, int vehicle, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleSteerBias(IntPtr plugin, int vehicle, float value);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleStrong(IntPtr plugin, int vehicle, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleTimedExplosion(IntPtr plugin, int vehicle, int ped, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleTransformState(IntPtr plugin, int vehicle, float state);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleTyreBurst(IntPtr plugin, int vehicle, int index, bool onRim, float p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleTyreFixed(IntPtr plugin, int vehicle, int tyreIndex);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleTyresCanBurst(IntPtr plugin, int vehicle, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleTyreSmokeColor(IntPtr plugin, int vehicle, int r, int g, int b);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleUndriveable(IntPtr plugin, int vehicle, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Vehicle_SetVehicleWheelsCanBreak(IntPtr plugin, int vehicle, bool enabled);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleWheelsCanBreakOffWhenBlowUp(IntPtr plugin, int vehicle, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleWheelType(IntPtr plugin, int vehicle, int WheelType);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVehicleWindowTint(IntPtr plugin, int vehicle, int tint);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SetVerticalFlightPhase(IntPtr plugin, int vehicle, float angle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SkipTimeInPlaybackRecordedVehicle(IntPtr plugin, ulong p0, float p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SkipToEndAndStopPlaybackRecordedVehicle(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Vehicle_SmashVehicleWindow(IntPtr plugin, int vehicle, int index);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_StartPlaybackRecordedVehicle(IntPtr plugin, int vehicle, int p1, IntPtr playback, bool p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_StartPlaybackRecordedVehicleUsingAi(IntPtr plugin, ulong p0, ulong p1, ref ulong p2, float p3, ulong p4);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_StartPlaybackRecordedVehicleWithFlags(IntPtr plugin, int vehicle, ulong p1, IntPtr playback, ulong p3, ulong p4, ulong p5);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Vehicle_StartVehicleAlarm(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_StartVehicleHorn(IntPtr plugin, int vehicle, int duration, ulong mode, bool forever);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_SteerUnlockBias(IntPtr plugin, int vehicle, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_StopAllGarageActivity(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_StopPlaybackRecordedVehicle(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Vehicle_SwitchTrainTrack(IntPtr plugin, int intersectionId, bool state);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_ToggleVehicleMod(IntPtr plugin, int vehicle, int modType, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_TrackVehicleVisibility(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_TransformStormbergToRoadVehicle(IntPtr plugin, int vehicle, bool instantly);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_TransformStormbergToWaterVehicle(IntPtr plugin, int vehicle, bool instantly);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_UnpausePlaybackRecordedVehicle(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_VehicleHasLandingGear(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_VehicleSetCustomParachuteModel(IntPtr plugin, int vehicle, ulong parachuteModel);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Vehicle_VehicleSetCustomParachuteTexture(IntPtr plugin, int vehicle, int colorIndex);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Vehicle_WasCounterActivated(IntPtr plugin, int vehicle, ulong p1);
    }
}
