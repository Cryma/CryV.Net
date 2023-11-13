using System;
using System.Runtime.InteropServices;

namespace CryV.Net.Native;

internal static partial class CryVNative
{
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Memory_IsPedInVehicle(IntPtr plugin, int pedId);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Memory_GetVehiclePedIsIn(IntPtr plugin, int pedId);

    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Memory_SetWheelSpeed(IntPtr plugin, int vehicleId, float wheelSpeed);

    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern float Native_Memory_GetWheelSpeed(IntPtr plugin, int vehicleId);

    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Memory_SetCurrentGear(IntPtr plugin, int vehicleId, byte gear);

    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern byte Native_Memory_GetCurrentGear(IntPtr plugin, int vehicleId);

    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Memory_SetCurrentRPM(IntPtr plugin, int vehicleId, float rpm);

    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern float Native_Memory_GetCurrentRPM(IntPtr plugin, int vehicleId);

    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Memory_SetClutch(IntPtr plugin, int vehicleId, float clutch);

    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern float Native_Memory_GetClutch(IntPtr plugin, int vehicleId);

    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Memory_SetTurbo(IntPtr plugin, int vehicleId, float turbo);

    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern float Native_Memory_GetTurbo(IntPtr plugin, int vehicleId);

    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Memory_SetAcceleration(IntPtr plugin, int vehicleId, float acceleration);

    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern float Native_Memory_GetAcceleration(IntPtr plugin, int vehicleId);

    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Memory_SetBrake(IntPtr plugin, int vehicleId, float brake);

    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern float Native_Memory_GetBrake(IntPtr plugin, int vehicleId);

    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Memory_SetSteeringAngle(IntPtr plugin, int vehicleId, float steeringAngle);

    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern float Native_Memory_GetSteeringAngle(IntPtr plugin, int vehicleId);

    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern short Native_Memory_GetPedSeat(IntPtr plugin, int pedId);

    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Memory_SetSlowmotion(IntPtr plugin, bool toggle);

}
