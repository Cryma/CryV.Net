using System;
using System.Runtime.InteropServices;

namespace CryV.Net.Client.Native
{
    public static partial class CryVNative
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
        public static extern void Native_Ped_TaskSetBlockingOfNonTemporaryEvents(IntPtr plugin, int pedId, bool toggle);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Ped_IsPedWalking(IntPtr plugin, int pedId);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Ped_IsPedRunning(IntPtr plugin, int pedId);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Ped_IsPedSprinting(IntPtr plugin, int pedId);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Ped_TaskGoStraightToCoord(IntPtr plugin, int pedId, float x, float y, float z, float speed, int timeout, float targetHeading,
            float distanceToSlide);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Ped_SetPedDesiredMoveBlendRatio(IntPtr plugin, int pedId, float p1);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Ped_TaskStandStill(IntPtr plugin, int pedId, int time);

    }
}
