using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CryV.Net.Native
{
    internal static partial class CryVNative
    {
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_System_Ceil(IntPtr plugin, float value);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_System_Cos(IntPtr plugin, float value);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_System_Floor(IntPtr plugin, float value);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_System__0x42B65DEEF2EDF2A1(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_System_Pow(IntPtr plugin, float @base, float exponent);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_System_Round(IntPtr plugin, float value);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_System_Settimera(IntPtr plugin, int value);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_System_Settimerb(IntPtr plugin, int value);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_System_ShiftLeft(IntPtr plugin, int value, int bitShift);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_System_ShiftRight(IntPtr plugin, int value, int bitShift);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_System_Sin(IntPtr plugin, float value);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_System_Sqrt(IntPtr plugin, float value);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_System_StartNewScript(IntPtr plugin, IntPtr scriptName, int stackSize);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_System_StartNewScriptWithArgs(IntPtr plugin, IntPtr scriptName, ref ulong args, int argCount, int stackSize);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_System_StartNewScriptWithNameHash(IntPtr plugin, ulong scriptHash, int stackSize);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_System_StartNewScriptWithNameHashAndArgs(IntPtr plugin, ulong scriptHash, ref ulong args, int argCount, int stackSize);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_System_Timera(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_System_Timerb(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_System_Timestep(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_System_ToFloat(IntPtr plugin, int value);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_System_Vdist(IntPtr plugin, float x1, float y1, float z1, float x2, float y2, float z2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_System_Vdist2(IntPtr plugin, float x1, float y1, float z1, float x2, float y2, float z2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_System_Vmag(IntPtr plugin, float x, float y, float z);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_System_Vmag2(IntPtr plugin, float x, float y, float z);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_System_Wait(IntPtr plugin, ref int ms);
    }
}
