using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CryV.Net.Native
{
    internal static partial class CryVNative
    {
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Clock_AddToClockTime(IntPtr plugin, int hours, int minutes, int seconds);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Clock_AdvanceClockTimeTo(IntPtr plugin, int hour, int minute, int second);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Clock_GetClockDayOfMonth(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Clock_GetClockDayOfWeek(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Clock_GetClockHours(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Clock_GetClockMinutes(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Clock_GetClockMonth(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Clock_GetClockSeconds(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Clock_GetClockYear(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Clock_GetLocalTime(IntPtr plugin, ref int year, ref int month, ref int day, ref int hour, ref int minute, ref int second);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Clock_GetMillisecondsPerGameMinute(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Clock_GetPosixTime(IntPtr plugin, ref int year, ref int month, ref int day, ref int hour, ref int minute, ref int second);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Clock_GetUtcTime(IntPtr plugin, ref int year, ref int month, ref int day, ref int hour, ref int minute, ref int second);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Clock_PauseClock(IntPtr plugin, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Clock_SetClockDate(IntPtr plugin, int day, int month, int year);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Clock_SetClockTime(IntPtr plugin, int hour, int minute, int second);
    }
}
