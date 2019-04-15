using System;
using System.Runtime.InteropServices;

namespace CryV.Net.Native
{
    internal static partial class CryVNative
    {

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Ped_SetPedDefaultComponentVariation(IntPtr plugin, int pedId);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Ped_CreatePed(IntPtr plugin, int pedType, ulong modelHash, float x, float y, float z, float heading, bool isNetwork, bool thisScriptCheck);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Ped_SetPedFleeAttribute(IntPtr plugin, int pedId, int attributes, bool p2);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Ped_SetBlockingOfNonTemporaryEvents(IntPtr plugin, int pedId, bool toggle);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Ped_SetPedCombatAttributes(IntPtr plugin, int pedId, int attributesIndex, bool enabled);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Ped_SetPedSeeingRange(IntPtr plugin, int pedId, float range);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Ped_SetPedHearingRange(IntPtr plugin, int pedId, float range);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Ped_SetPedAlertness(IntPtr plugin, int pedId, int value);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Ped_SetPedCanRagdoll(IntPtr plugin, int pedId, bool toggle);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Ped_SetPedCanBeTargetted(IntPtr plugin, int pedId, bool toggle);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Ped_SetPedCanEvasiveDive(IntPtr plugin, int pedId, bool enable);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Ped_SetPedCanBeTargettedByPlayer(IntPtr plugin, int pedId, int playerId, bool toggle);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Ped_SetPedGetOutUpsideDownVehicle(IntPtr plugin, int pedId, bool toggle);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Ped_SetPedAsEnemy(IntPtr plugin, int pedId, bool toggle);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Ped_SetCanAttackFriendly(IntPtr plugin, int pedId, bool toggle, bool p2);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Ped_SetPedToRagdoll(IntPtr plugin, int pedId, int time1, int time2, int ragdollType, bool p4, bool p5, bool p6);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Ped_SetPedToRagdollWithFall(IntPtr plugin, int pedId, int time, int p2, int ragdollType, float x, float y, float z, float p7);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Ped_SetPedDiesWhenInjured(IntPtr plugin, int pedId, bool toggle);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Ped_SetPedConfigFlag(IntPtr plugin, int pedId, int flagId, bool value);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Ped_SetPedCanHeadIK(IntPtr plugin, int pedId, bool toggle);

        //

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Ped_TaskSetBlockingOfNonTemporaryEvents(IntPtr plugin, int pedId, bool toggle);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Ped_TaskJump(IntPtr plugin, int pedId, bool unused);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Ped_TaskClimb(IntPtr plugin, int pedId, bool unused);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Ped_TaskClimbLadder(IntPtr plugin, int pedId, int p1);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Ped_TaskMoveNetwork(IntPtr plugin, int pedId, IntPtr task, float multiplier, bool p3, IntPtr animDict, int flags);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Ped_TaskAimGunAtCoord(IntPtr plugin, int pedId, float x, float y, float z, int time, bool p5, bool p6);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Ped_TaskLookAtCoord(IntPtr plugin, int pedId, float x, float y, float z, float duration, int p5, int p6);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Ped_TaskAimGunAtEntity(IntPtr plugin, int pedId, int entityHandle, int duration, bool p3);

        //

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Ped_IsPedWalking(IntPtr plugin, int pedId);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Ped_IsPedRunning(IntPtr plugin, int pedId);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Ped_IsPedSprinting(IntPtr plugin, int pedId);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Ped_IsPedJumping(IntPtr plugin, int pedId);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Ped_IsPedClimbing(IntPtr plugin, int pedId);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Ped_IsPedRagdoll(IntPtr plugin, int pedId);

        //

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Ped_GetIsTaskActive(IntPtr plugin, int pedId, int taskNumber);

        //

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Ped_TaskGoStraightToCoord(IntPtr plugin, int pedId, float x, float y, float z, float speed, int timeout, float targetHeading,
            float distanceToSlide);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Ped_SetPedDesiredMoveBlendRatio(IntPtr plugin, int pedId, float p1);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Ped_TaskStandStill(IntPtr plugin, int pedId, int time);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Ped_TaskPlayAnim(IntPtr plugin, int pedId, IntPtr animDictionary, IntPtr animationName, float speed, float speedMultiplier,
            int duration, uint flag, float playbackRate, bool lockX, bool lockY, bool lockZ);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Ped_ClearPedTasksImmediately(IntPtr plugin, int pedId);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Ped_ClearPedTasks(IntPtr plugin, int pedId);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Ped_ClearPedSecondaryTask(IntPtr plugin, int pedId);

        //

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Ped_GetCurrentPedWeapon(IntPtr plugin, int pedId);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Ped_GetSelectedPedWeapon(IntPtr plugin, int pedId);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Ped_RemoveAllPedWeapons(IntPtr plugin, int pedId);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Ped_GiveWeaponToPed(IntPtr plugin, int pedId, ulong weaponHash, int ammoCount, bool isHidden, bool equipNow);

        //

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Ped__0xD5BB4025AE449A4E(IntPtr plugin, int pedId, IntPtr p1, float p2);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Ped__0xB0A6CFD2C69C1088(IntPtr plugin, int pedId, IntPtr p1, bool p2);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Ped__0xD01015C7316AE176(IntPtr plugin, int pedId, IntPtr p1);


    }
}
