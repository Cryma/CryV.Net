using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CryV.Net.Client.Native
{
    public static partial class CryVNative
    {

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_LocalPlayer_PlayerId(IntPtr plugin);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_LocalPlayer_PedId(IntPtr plugin);

        //

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_LocalPlayer__0xD2B315B6689D537D(IntPtr plugin, int playerId, bool p1);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_LocalPlayer_SetAutoGiveParachuteWhenEnterPlane(IntPtr plugin, int playerId, bool enabled);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_LocalPlayer_SetPlayerHealthRechargeMultiplier(IntPtr plugin, int playerId, float multiplier);

        //

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_LocalPlayer_SetPlayerWantedLevel(IntPtr plugin, int playerId, int wantedLevel, bool disableNoMission);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_LocalPlayer_SetPlayerWantedLevelNow(IntPtr plugin, int playerId, bool p1);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_LocalPlayer_SetMaxWantedLevel(IntPtr plugin, int maxWantedLevel);

        //

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_LocalPLayer_SetPlayerModel(IntPtr plugin, int playerId, ulong model);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_LocalPLayer_SetPedDefaultComponentVariation(IntPtr plugin, int pedId);
    }
}
