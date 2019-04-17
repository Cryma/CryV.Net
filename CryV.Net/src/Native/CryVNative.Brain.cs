using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CryV.Net.Native
{
    internal static partial class CryVNative
    {
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_AddCoverBlockingArea(IntPtr plugin, float playerX, float playerY, float playerZ, float radiusX, float radiusY, float radiusZ, bool p6, bool p7, bool p8, bool p9);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_AddPatrolRouteLink(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_AddPatrolRouteNode(IntPtr plugin, int p0, IntPtr p1, float x1, float y1, float z1, float x2, float y2, float z2, int p8);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_AddScriptToRandomPed(IntPtr plugin, IntPtr name, ulong model, float p2, float p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_AddVehicleSubtaskAttackCoord(IntPtr plugin, int ped, float x, float y, float z);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_AddVehicleSubtaskAttackPed(IntPtr plugin, int ped, int ped2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Brain_AssistedMovementIsRouteLoaded(IntPtr plugin, IntPtr route);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_AssistedMovementOverrideLoadDistanceThisFrame(IntPtr plugin, float dist);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_AssistedMovementRemoveRoute(IntPtr plugin, IntPtr route);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_AssistedMovementRequestRoute(IntPtr plugin, IntPtr route);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_AssistedMovementSetRouteProperties(IntPtr plugin, IntPtr route, int props);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_ClearDrivebyTaskUnderneathDrivingTask(IntPtr plugin, int ped);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_ClearPedSecondaryTask(IntPtr plugin, int ped);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_ClearPedTasks(IntPtr plugin, int ped);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_ClearPedTasksImmediately(IntPtr plugin, int ped);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Brain_ClearSequenceTask(IntPtr plugin, ref int taskSequence);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_ClosePatrolRoute(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Brain_CloseSequenceTask(IntPtr plugin, int taskSequence);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Brain_ControlMountedWeapon(IntPtr plugin, int ped);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_CreatePatrolRoute(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_DeletePatrolRoute(IntPtr plugin, IntPtr patrolRoute);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_DisableScriptBrainSet(IntPtr plugin, int brainSet);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Brain_DoesScenarioExistInArea(IntPtr plugin, float x, float y, float z, float radius, bool b);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Brain_DoesScenarioGroupExist(IntPtr plugin, IntPtr scenarioGroup);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Brain_DoesScenarioOfTypeExistInArea(IntPtr plugin, float p0, float p1, float p2, ref ulong p3, float p4, bool p5);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Brain_DoesScriptedCoverPointExistAtCoords(IntPtr plugin, float x, float y, float z);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_EnableScriptBrainSet(IntPtr plugin, int brainSet);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Brain_GetActiveVehicleMissionType(IntPtr plugin, int veh);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Native_Brain_GetClipSetForScriptedGunTask(IntPtr plugin, int p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Brain_GetIsTaskActive(IntPtr plugin, int ped, int taskNumber);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Brain_GetIsWaypointRecordingLoaded(IntPtr plugin, IntPtr name);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Brain_GetNavmeshRouteDistanceRemaining(IntPtr plugin, int ped, ref float distRemaining, ref bool isPathReady);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Brain_GetNavmeshRouteResult(IntPtr plugin, int ped);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Brain_GetPedDesiredMoveBlendRatio(IntPtr plugin, int ped);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Brain_GetPedWaypointDistance(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Brain_GetPedWaypointProgress(IntPtr plugin, int ped);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Brain_GetPhoneGestureAnimCurrentTime(IntPtr plugin, int ped);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Brain_GetPhoneGestureAnimTotalTime(IntPtr plugin, int ped);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Brain_GetScriptTaskStatus(IntPtr plugin, int targetPed, ulong taskHash);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Brain_GetSequenceProgress(IntPtr plugin, int ped);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Brain_GetVehicleWaypointProgress(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Brain_GetVehicleWaypointTargetPoint(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Brain_GetWaypointDistanceAlongRoute(IntPtr plugin, IntPtr p0, int p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Brain_IsDrivebyTaskUnderneathDrivingTask(IntPtr plugin, int ped);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Brain_IsMountedWeaponTaskUnderneathDrivingTask(IntPtr plugin, int ped);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Brain_IsMoveBlendRatioRunning(IntPtr plugin, int ped);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Brain_IsMoveBlendRatioSprinting(IntPtr plugin, int ped);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Brain_IsMoveBlendRatioStill(IntPtr plugin, int ped);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Brain_IsMoveBlendRatioWalking(IntPtr plugin, int ped);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Brain_IsObjectWithinBrainActivationRange(IntPtr plugin, int @object);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Brain_IsPedActiveInScenario(IntPtr plugin, int ped);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Brain_IsPedBeingArrested(IntPtr plugin, int ped);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Brain_IsPedCuffed(IntPtr plugin, int ped);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Brain_IsPedGettingUp(IntPtr plugin, int ped);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Brain_IsPedInWrithe(IntPtr plugin, int ped);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Brain_IsPedRunning(IntPtr plugin, int ped);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Brain_IsPedRunningArrestTask(IntPtr plugin, int ped);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Brain_IsPedSprinting(IntPtr plugin, int ped);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Brain_IsPedStill(IntPtr plugin, int ped);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Brain_IsPedStrafing(IntPtr plugin, int ped);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Brain_IsPedWalking(IntPtr plugin, int ped);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Brain_IsPlayingPhoneGestureAnim(IntPtr plugin, int ped);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Brain_IsScenarioGroupEnabled(IntPtr plugin, IntPtr scenarioGroup);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Brain_IsScenarioOccupied(IntPtr plugin, float p0, float p1, float p2, float p3, bool p4);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Brain_IsScenarioTypeEnabled(IntPtr plugin, IntPtr scenarioType);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Brain_IsWaypointPlaybackGoingOnForPed(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Brain_IsWaypointPlaybackGoingOnForVehicle(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Brain_IsWorldPointWithinBrainActivationRange(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain__0x0B40ED49D7D6FF84(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain__0x19D1B791CB3670FE(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain__0x1F351CF1C6475734(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4, ulong p5, ulong p6, ulong p7, ulong p8, ulong p9);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Brain__0x30ED88D5E0C56A37(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Brain__0x3E38E28A1D80DDF6(IntPtr plugin, int ped);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain__0x4D953DF78EBF8158(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Brain__0x621C6E4729388E41(IntPtr plugin, int ped);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain__0x6D6840CEE8845831(IntPtr plugin, IntPtr action);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain__0x6E91B04E08773030(IntPtr plugin, IntPtr action);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Native_Brain__0x717E4D1F2048376D(IntPtr plugin, int ped);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain__0x88E32DB8C1A4AA4B(IntPtr plugin, int ped, float p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain__0x8C33220C8D78CA0D(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain__0x8FD89A6240813FD0(IntPtr plugin, int ped, bool p1, bool p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Brain__0x921CE12C489C4C41(IntPtr plugin, int PlayerID);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain__0x92C360B5F15D2302(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4, ulong p5, ulong p6);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Brain__0xA7FFBA498E4AAF67(IntPtr plugin, int ped, IntPtr p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Brain__0xAB13A5565480B6D9(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Brain__0xB4F47213DF45A64C(IntPtr plugin, int ped, IntPtr p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Brain__0xD01015C7316AE176(IntPtr plugin, int ped, IntPtr p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain__0xE70BA7B90F8390DC(IntPtr plugin, ulong p0, ulong p1, bool p2, ulong p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_OpenPatrolRoute(IntPtr plugin, IntPtr patrolRoute);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Brain_OpenSequenceTask(IntPtr plugin, ref int taskSequence);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Brain_PedHasUseScenarioTask(IntPtr plugin, int ped);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_PlayAnimOnRunningScenario(IntPtr plugin, int ped, IntPtr animDict, IntPtr animName);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_PlayEntityScriptedAnim(IntPtr plugin, ulong p0, ref ulong p1, ref ulong p2, ref ulong p3, float p4, float p5);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_RegisterObjectScriptBrain(IntPtr plugin, IntPtr scriptName, ulong objectName, int p2, float p3, int p4, int p5);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_RegisterWorldPointScriptBrain(IntPtr plugin, ref ulong p0, float p1, ulong p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_RemoveAllCoverBlockingAreas(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_RemoveWaypointRecording(IntPtr plugin, IntPtr name);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_RequestWaypointRecording(IntPtr plugin, IntPtr name);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_ResetExclusiveScenarioGroup(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_ResetScenarioGroupsEnabled(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_ResetScenarioTypesEnabled(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_SetAnimLooped(IntPtr plugin, ulong p0, bool p1, ulong p2, bool p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_SetAnimRate(IntPtr plugin, ulong p0, float p1, ulong p2, bool p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_SetAnimWeight(IntPtr plugin, ulong p0, float p1, ulong p2, ulong p3, bool p4);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_SetDrivebyTaskTarget(IntPtr plugin, int shootingPed, int targetPed, int targetVehicle, float x, float y, float z);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_SetDriveTaskCruiseSpeed(IntPtr plugin, int driver, float cruiseSpeed);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_SetDriveTaskDrivingStyle(IntPtr plugin, int ped, int drivingStyle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_SetDriveTaskMaxCruiseSpeed(IntPtr plugin, ulong p0, float p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_SetExclusiveScenarioGroup(IntPtr plugin, IntPtr scenarioGroup);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_SetGlobalMinBirdFlightHeight(IntPtr plugin, float height);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_SetHighFallTask(IntPtr plugin, int ped, ulong p1, ulong p2, ulong p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_SetMountedWeaponTarget(IntPtr plugin, int shootingPed, int targetPed, int targetVehicle, float x, float y, float z);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_SetNextDesiredMoveState(IntPtr plugin, float p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_SetParachuteTaskTarget(IntPtr plugin, int ped, float x, float y, float z);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_SetParachuteTaskThrust(IntPtr plugin, int ped, float thrust);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_SetPedDesiredMoveBlendRatio(IntPtr plugin, int ped, float p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_SetPedPathAvoidFire(IntPtr plugin, int ped, bool avoidFire);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_SetPedPathCanDropFromHeight(IntPtr plugin, int ped, bool Toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Brain_SetPedPathCanUseClimbovers(IntPtr plugin, int ped, bool Toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Brain_SetPedPathCanUseLadders(IntPtr plugin, int ped, bool Toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_SetPedPathPreferToAvoidWater(IntPtr plugin, int ped, bool avoidWater);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_SetPedPathsWidthPlant(IntPtr plugin, int ped, bool mayEnterWater);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Brain_SetPedWaypointRouteOffset(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_SetScenarioGroupEnabled(IntPtr plugin, IntPtr scenarioGroup, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_SetScenarioTypeEnabled(IntPtr plugin, IntPtr scenarioType, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_SetSequenceToRepeat(IntPtr plugin, int taskSequence, bool repeat);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_SetTaskPropertyBool(IntPtr plugin, int ped, IntPtr p1, bool p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_SetTaskPropertyFloat(IntPtr plugin, int ped, IntPtr p1, float p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_SetTaskVehicleChaseBehaviorFlag(IntPtr plugin, int ped, int flag, bool set);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_SetTaskVehicleChaseIdealPursuitDistance(IntPtr plugin, int ped, float distance);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_StopAnimPlayback(IntPtr plugin, int ped, int p1, bool p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_StopAnimTask(IntPtr plugin, int ped, IntPtr animDictionary, IntPtr animationName, float p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskAchieveHeading(IntPtr plugin, int ped, float heading, int timeout);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskAimGunAtCoord(IntPtr plugin, int ped, float x, float y, float z, int time, bool p5, bool p6);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskAimGunAtEntity(IntPtr plugin, int ped, int entity, int duration, bool p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskAimGunScripted(IntPtr plugin, int ped, ulong scriptTask, bool p2, bool p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskAimGunScriptedWithTarget(IntPtr plugin, ulong p0, ulong p1, float p2, float p3, float p4, ulong p5, bool p6, bool p7);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskArrestPed(IntPtr plugin, int ped, int target);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskBoatMission(IntPtr plugin, int pedDriver, int boat, ulong p2, ulong p3, float x, float y, float z, ulong p7, float maxSpeed, int drivingStyle, float p10, ulong p11);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskChatToPed(IntPtr plugin, int ped, int target, ulong p2, float p3, float p4, float p5, float p6, float p7);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskClearDefensiveArea(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskClearLookAt(IntPtr plugin, int ped);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskClimb(IntPtr plugin, int ped, bool unused);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskClimbLadder(IntPtr plugin, int ped, int p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskCombatHatedTargetsAroundPed(IntPtr plugin, int ped, float radius, int p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskCombatHatedTargetsAroundPedTimed(IntPtr plugin, ulong p0, float p1, ulong p2, ulong p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskCombatHatedTargetsInArea(IntPtr plugin, int ped, float x, float y, float z, float radius, ulong p5);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskCombatPed(IntPtr plugin, int ped, int targetPed, int p2, int p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskCombatPedTimed(IntPtr plugin, ulong p0, int ped, int p2, ulong p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskCower(IntPtr plugin, int ped, int duration);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskDriveBy(IntPtr plugin, int driverPed, int targetPed, int targetVehicle, float targetX, float targetY, float targetZ, float distanceToShoot, int pedAccuracy, bool p8, ulong firingPattern);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskEnterVehicle(IntPtr plugin, int ped, int vehicle, int timeout, int seat, float speed, int flag, ulong p6);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskEveryoneLeaveVehicle(IntPtr plugin, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskExitCover(IntPtr plugin, ulong p0, ulong p1, float p2, float p3, float p4);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskExtendRoute(IntPtr plugin, float x, float y, float z);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskFlushRoute(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskFollowNavMeshToCoord(IntPtr plugin, int ped, float x, float y, float z, float speed, int timeout, float stoppingRange, bool persistFollowing, float unk);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskFollowNavMeshToCoordAdvanced(IntPtr plugin, int ped, float x, float y, float z, float speed, int timeout, float unkFloat, int unkInt, float unkX, float unkY, float unkZ, float unk_40000f);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskFollowPointRoute(IntPtr plugin, int ped, float speed, int unknown);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskFollowToOffsetOfEntity(IntPtr plugin, int ped, int entity, float offsetX, float offsetY, float offsetZ, float movementSpeed, int timeout, float stoppingRange, bool persistFollowing);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskFollowWaypointRecording(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskForceMotionState(IntPtr plugin, int ped, ulong state, bool p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskGetOffBoat(IntPtr plugin, int ped, int boat);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskGoStraightToCoord(IntPtr plugin, int ped, float x, float y, float z, float speed, int timeout, float targetHeading, float distanceToSlide);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskGoStraightToCoordRelativeToEntity(IntPtr plugin, int entity1, int entity2, float p2, float p3, float p4, float p5, ulong p6);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskGoToCoordAndAimAtHatedEntitiesNearCoord(IntPtr plugin, int pedHandle, float goToLocationX, float goToLocationY, float goToLocationZ, float focusLocationX, float focusLocationY, float focusLocationZ, float speed, bool shootAtEnemies, float distanceToStopAt, float noRoadsDistance, bool unkTrue, int unkFlag, int aimingFlag, ulong firingPattern);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskGoToCoordAnyMeans(IntPtr plugin, int ped, float x, float y, float z, float speed, ulong p5, bool p6, int walkingStyle, float p8);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskGoToCoordAnyMeansExtraParams(IntPtr plugin, int ped, float x, float y, float z, float speed, ulong p5, bool p6, int walkingStyle, float p8, ulong p9, ulong p10, ulong p11);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskGoToCoordAnyMeansExtraParamsWithCruiseSpeed(IntPtr plugin, int ped, float x, float y, float z, float speed, ulong p5, bool p6, int walkingStyle, float p8, ulong p9, ulong p10, ulong p11, ulong p12);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskGoToCoordWhileAimingAtCoord(IntPtr plugin, int ped, float x, float y, float z, float aimAtX, float aimAtY, float aimAtZ, float moveSpeed, bool p8, float p9, float p10, bool p11, ulong flags, bool p13, ulong firingPattern);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskGoToCoordWhileAimingAtEntity(IntPtr plugin, ulong p0, float p1, float p2, float p3, ulong p4, float p5, bool p6, float p7, float p8, bool p9, ulong p10, bool p11, ulong p12, ulong p13);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskGoToEntity(IntPtr plugin, int entity, int target, int duration, float distance, float speed, float p5, int p6);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskGotoEntityAiming(IntPtr plugin, int ped, int target, float distanceToStopAt, float StartAimingDist);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskGotoEntityOffset(IntPtr plugin, int ped, ulong p1, ulong p2, float x, float y, float z, int duration);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskGotoEntityOffsetXy(IntPtr plugin, int ped, int entity, int duration, float xOffset, float yOffset, float zOffset, float moveBlendRatio, bool useNavmesh);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskGoToEntityWhileAimingAtCoord(IntPtr plugin, ulong p0, ulong p1, float p2, float p3, float p4, float p5, bool p6, float p7, float p8, bool p9, bool p10, ulong p11);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskGoToEntityWhileAimingAtEntity(IntPtr plugin, int ped, int entityToWalkTo, int entityToAimAt, float speed, bool shootatEntity, float p5, float p6, bool p7, bool p8, ulong firingPattern);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskGuardAssignedDefensiveArea(IntPtr plugin, ulong p0, float p1, float p2, float p3, float p4, float p5, ulong p6);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskGuardCurrentPosition(IntPtr plugin, int p0, float p1, float p2, bool p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskGuardSphereDefensiveArea(IntPtr plugin, int p0, float p1, float p2, float p3, float p4, float p5, ulong p6, float p7, float p8, float p9, float p10);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskHandsUp(IntPtr plugin, int ped, int duration, int facingPed, int p3, bool p4);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskHeliChase(IntPtr plugin, int pilot, int entityToFollow, float x, float y, float z);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskHeliMission(IntPtr plugin, int pilot, int aircraft, int targetVehicle, int targetPed, float destinationX, float destinationY, float destinationZ, int missionFlag, float maxSpeed, float landingRadius, float targetHeading, int unk1, int unk2, ulong unk3, int landingFlags);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskJump(IntPtr plugin, int ped, bool unused);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskLeaveAnyVehicle(IntPtr plugin, int ped, int p1, int p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskLeaveVehicle(IntPtr plugin, int ped, int vehicle, int flags);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskLookAtCoord(IntPtr plugin, int entity, float x, float y, float z, float duration, ulong p5, ulong p6);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskLookAtEntity(IntPtr plugin, int ped, int lookAt, int duration, int unknown1, int unknown2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskMoveNetwork(IntPtr plugin, int ped, IntPtr task, float multiplier, bool p3, IntPtr animDict, int flags);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskMoveNetworkAdvanced(IntPtr plugin, int ped, IntPtr p1, float p2, float p3, float p4, float p5, float p6, float p7, ulong p8, float p9, bool p10, IntPtr animDict, int flags);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskOpenVehicleDoor(IntPtr plugin, int ped, int vehicle, int timeOut, int doorIndex, float speed);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskParachute(IntPtr plugin, int ped, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskParachuteToTarget(IntPtr plugin, int ped, float x, float y, float z);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskPatrol(IntPtr plugin, int ped, IntPtr p1, ulong p2, bool p3, bool p4);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskPause(IntPtr plugin, int ped, int ms);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskPedSlideToCoord(IntPtr plugin, int ped, float x, float y, float z, float heading, float duration);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskPedSlideToCoordHdgRate(IntPtr plugin, int ped, float x, float y, float z, float heading, float p5, float p6);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Brain_TaskPerformSequence(IntPtr plugin, int ped, int taskSequence);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskPerformSequenceFromProgress(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskPlaneChase(IntPtr plugin, int pilot, int entityToFollow, float x, float y, float z);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskPlaneLand(IntPtr plugin, int pilot, int plane, float runwayStartX, float runwayStartY, float runwayStartZ, float runwayEndX, float runwayEndY, float runwayEndZ);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskPlaneMission(IntPtr plugin, int pilot, int aircraft, int targetVehicle, int targetPed, float destinationX, float destinationY, float destinationZ, int missionFlag, float angularDrag, float unk, float targetHeading, float maxZ, float minZ);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskPlantBomb(IntPtr plugin, int ped, float x, float y, float z, float heading);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskPlayAnim(IntPtr plugin, int ped, IntPtr animDictionary, IntPtr animationName, float blendInSpeed, float blendOutSpeed, int duration, int flag, float playbackRate, bool lockX, bool lockY, bool lockZ);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskPlayAnimAdvanced(IntPtr plugin, int ped, IntPtr animDict, IntPtr animName, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, float speed, float speedMultiplier, int duration, ulong flag, float animTime, ulong p14, ulong p15);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskPlayPhoneGestureAnimation(IntPtr plugin, int ped, IntPtr animDict, IntPtr animation, IntPtr boneMaskType, float p4, float p5, bool p6, bool p7);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskPutPedDirectlyIntoCover(IntPtr plugin, int ped, float x, float y, float z, ulong timeout, bool p5, float p6, bool p7, bool p8, ulong p9, bool p10);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskPutPedDirectlyIntoMelee(IntPtr plugin, int ped, int meleeTarget, float p2, float p3, float p4, bool p5);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskRappelFromHeli(IntPtr plugin, int ped, int unused);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskReactAndFleePed(IntPtr plugin, int ped, int fleeTarget);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskReloadWeapon(IntPtr plugin, int ped, bool unused);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskScriptedAnimation(IntPtr plugin, int ped, ref ulong p1, ref ulong p2, ref ulong p3, float p4, float p5);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskSeekCoverFromPed(IntPtr plugin, int ped, int target, int duration, bool p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskSeekCoverFromPos(IntPtr plugin, int ped, float x, float y, float z, int duration, bool p5);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskSeekCoverToCoords(IntPtr plugin, int ped, float x1, float y1, float z1, float x2, float y2, float z2, ulong p7, bool p8);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskSeekCoverToCoverPoint(IntPtr plugin, ulong p0, ulong p1, float p2, float p3, float p4, ulong p5, bool p6);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskSetBlockingOfNonTemporaryEvents(IntPtr plugin, int ped, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskSetDecisionMaker(IntPtr plugin, int p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskSetSphereDefensiveArea(IntPtr plugin, ulong p0, float p1, float p2, float p3, float p4);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskShockingEventReact(IntPtr plugin, int ped, int eventHandle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskShootAtCoord(IntPtr plugin, int ped, float x, float y, float z, int duration, ulong firingPattern);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskShootAtEntity(IntPtr plugin, int entity, int target, int duration, ulong firingPattern);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskShuffleToNextVehicleSeat(IntPtr plugin, int ped, int vehicle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskSkyDive(IntPtr plugin, int ped);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskSmartFleeCoord(IntPtr plugin, int ped, float x, float y, float z, float distance, int time, bool p6, bool p7);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskSmartFleePed(IntPtr plugin, int ped, int fleeTarget, float distance, ulong fleeTime, bool p4, bool p5);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskStandGuard(IntPtr plugin, int ped, float x, float y, float z, float heading, IntPtr scenarioName);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskStandStill(IntPtr plugin, int ped, int time);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskStartScenarioAtPosition(IntPtr plugin, int ped, IntPtr scenarioName, float x, float y, float z, float heading, int duration, bool sittingScenario, bool teleport);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskStartScenarioInPlace(IntPtr plugin, int ped, IntPtr scenarioName, int unkDelay, bool playEnterAnim);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskStayInCover(IntPtr plugin, int ped);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskStealthKill(IntPtr plugin, int killer, int target, ulong actionType, float p3, ulong p4);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskStopPhoneGestureAnimation(IntPtr plugin, int ped);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskSwapWeapon(IntPtr plugin, int ped, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskSweepAimEntity(IntPtr plugin, int ped, IntPtr anim, IntPtr p2, IntPtr p3, IntPtr p4, int p5, int vehicle, float p7, float p8);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskSweepAimPosition(IntPtr plugin, ulong p0, ref ulong p1, ref ulong p2, ref ulong p3, ref ulong p4, ulong p5, float p6, float p7, float p8, float p9, float p10);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskSynchronizedScene(IntPtr plugin, int ped, int scene, IntPtr animDictionary, IntPtr animationName, float speed, float speedMultiplier, int duration, int flag, float playbackRate, ulong p9);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskThrowProjectile(IntPtr plugin, int ped, float x, float y, float z);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskToggleDuck(IntPtr plugin, bool p0, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskTurnPedToFaceCoord(IntPtr plugin, int ped, float x, float y, float z, int duration);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskTurnPedToFaceEntity(IntPtr plugin, int ped, int entity, int duration);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskUseMobilePhone(IntPtr plugin, int ped, int p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskUseMobilePhoneTimed(IntPtr plugin, int ped, int duration);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskUseNearestScenarioChainToCoord(IntPtr plugin, ulong p0, float p1, float p2, float p3, float p4, ulong p5);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskUseNearestScenarioChainToCoordWarp(IntPtr plugin, ulong p0, float p1, float p2, float p3, float p4, ulong p5);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskUseNearestScenarioToCoord(IntPtr plugin, int ped, float x, float y, float z, float distance, int duration);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskUseNearestScenarioToCoordWarp(IntPtr plugin, int ped, float x, float y, float z, float radius, ulong p5);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskVehicleAimAtCoord(IntPtr plugin, int ped, float x, float y, float z);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskVehicleAimAtPed(IntPtr plugin, int ped, int target);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskVehicleChase(IntPtr plugin, int driver, int targetEnt);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskVehicleDriveToCoord(IntPtr plugin, int ped, int vehicle, float x, float y, float z, float speed, ulong p6, ulong vehicleModel, int drivingMode, float stopRange, float p10);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskVehicleDriveToCoordLongrange(IntPtr plugin, int ped, int vehicle, float x, float y, float z, float speed, int driveMode, float stopRange);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskVehicleDriveWander(IntPtr plugin, int ped, int vehicle, float speed, int drivingStyle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskVehicleEscort(IntPtr plugin, int ped, int vehicle, int targetVehicle, int mode, float speed, int drivingStyle, float minDistance, int p7, float noRoadsDistance);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskVehicleFollow(IntPtr plugin, int driver, int vehicle, int targetEntity, float speed, int drivingStyle, int minDistance);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskVehicleFollowWaypointRecording(IntPtr plugin, int ped, int vehicle, IntPtr WPRecording, int p3, int p4, int p5, int p6, float p7, bool p8, float p9);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskVehicleGotoNavmesh(IntPtr plugin, int ped, int vehicle, float x, float y, float z, float speed, int behaviorFlag, float stoppingRange);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskVehicleHeliProtect(IntPtr plugin, int pilot, int vehicle, int entityToFollow, float targetSpeed, int p4, float radius, int altitude, int p7);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskVehicleMission(IntPtr plugin, int p0, int p1, int veh, ulong p3, float p4, ulong p5, float p6, float p7, bool p8);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskVehicleMissionCoorsTarget(IntPtr plugin, int ped, int vehicle, float x, float y, float z, int p5, int p6, int p7, float p8, float p9, bool p10);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskVehicleMissionPedTarget(IntPtr plugin, int ped, int vehicle, int pedTarget, int mode, float maxSpeed, int drivingStyle, float minDistance, float p7, bool p8);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskVehiclePark(IntPtr plugin, int ped, int vehicle, float x, float y, float z, float heading, int mode, float radius, bool keepEngineOn);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskVehiclePlayAnim(IntPtr plugin, int vehicle, IntPtr animation_set, IntPtr animation_name);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskVehicleShootAtCoord(IntPtr plugin, int ped, float x, float y, float z, float p4);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskVehicleShootAtPed(IntPtr plugin, int ped, int target, float p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskVehicleTempAction(IntPtr plugin, int driver, int vehicle, int action, int time);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskWanderInArea(IntPtr plugin, int ped, float x, float y, float z, float radius, float minimalLength, float timeBetweenWalks);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskWanderStandard(IntPtr plugin, int ped, float p1, int p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskWarpPedIntoVehicle(IntPtr plugin, int ped, int vehicle, int seat);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_TaskWrithe(IntPtr plugin, int ped, int target, int time, int p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_UncuffPed(IntPtr plugin, int ped);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_UpdateTaskAimGunScriptedTarget(IntPtr plugin, int p0, int p1, float p2, float p3, float p4, bool p5);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_UpdateTaskHandsUpDuration(IntPtr plugin, int ped, int duration);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_UpdateTaskSweepAimEntity(IntPtr plugin, int ped, int entity);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_UpdateTaskSweepAimPosition(IntPtr plugin, ulong p0, float p1, float p2, float p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_UseWaypointRecordingAsAssistedMovementRoute(IntPtr plugin, ref ulong p0, bool p1, float p2, float p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_VehicleWaypointPlaybackOverrideSpeed(IntPtr plugin, ulong p0, float p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_VehicleWaypointPlaybackPause(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_VehicleWaypointPlaybackResume(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_VehicleWaypointPlaybackUseDefaultSpeed(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Brain_WaypointPlaybackGetIsPaused(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_WaypointPlaybackOverrideSpeed(IntPtr plugin, ulong p0, float p1, bool p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_WaypointPlaybackPause(IntPtr plugin, ulong p0, bool p1, bool p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_WaypointPlaybackResume(IntPtr plugin, ulong p0, bool p1, ulong p2, ulong p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_WaypointPlaybackStartAimingAtCoord(IntPtr plugin, ulong p0, float p1, float p2, float p3, bool p4);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_WaypointPlaybackStartAimingAtPed(IntPtr plugin, ulong p0, ulong p1, bool p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_WaypointPlaybackStartShootingAtCoord(IntPtr plugin, ulong p0, float p1, float p2, float p3, bool p4, ulong p5);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_WaypointPlaybackStopAimingOrShooting(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Brain_WaypointPlaybackUseDefaultSpeed(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Brain_WaypointRecordingGetClosestWaypoint(IntPtr plugin, IntPtr name, float x, float y, float z, ref int point);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Brain_WaypointRecordingGetNumPoints(IntPtr plugin, IntPtr name, ref int points);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Brain_WaypointRecordingGetSpeedAtPoint(IntPtr plugin, IntPtr name, int point);
    }
}
