using CryV.Net.Native;
using CryV.Net.Enums;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CryV.Net.Helpers;

namespace CryV.Net.Elements;

public static class World
{

    public static void SetWeather(WeatherType weatherType)
    {
        var weatherName = ConvertWeatherTypeToName(weatherType);
        if(string.IsNullOrEmpty(weatherName))
        {
            return;
        }

        using var converter = new StringConverter();
        var weatherPointer = converter.StringToPointer(weatherName);

        CryVNative.Native_Misc_SetWeatherTypeNow(CryVNative.Plugin, weatherPointer);
    }

    public static List<Ped> GetAllPeds(bool includeSelf = true)
    {
        var pedsPointer = CryVNative.Native_Misc_GetAllPeds(CryVNative.Plugin);
        var arrayLength = Marshal.ReadInt32(pedsPointer);

        var start = IntPtr.Add(pedsPointer, 4);
        var peds = new int[arrayLength];

        Marshal.Copy(start, peds, 0, arrayLength);

        Utility.FreeArray(pedsPointer);

        var pedList = new List<Ped>();
        foreach (var ped in peds)
        {
            if (includeSelf && ped == LocalPlayer.Character.Handle)
            {
                continue;
            }

            pedList.Add(new Ped(ped));
        }

        return pedList;
    }

    public static List<Vehicle> GetAllVehicles()
    {
        var vehiclesPointer = CryVNative.Native_Misc_GetAllVehicles(CryVNative.Plugin);
        var arrayLength = Marshal.ReadInt32(vehiclesPointer);

        var start = IntPtr.Add(vehiclesPointer, 4);
        var vehicles = new int[arrayLength];

        Marshal.Copy(start, vehicles, 0, arrayLength);

        Utility.FreeArray(vehiclesPointer);

        var vehicleList = new List<Vehicle>();
        foreach (var vehicle in vehicles)
        {
            vehicleList.Add(new Vehicle(vehicle));
        }

        return vehicleList;
    }

    public static void SetRandomTrains(bool enabled)
    {
        CryVNative.Native_Vehicle_SetRandomTrains(CryVNative.Plugin, enabled);
    }

    public static void SetRandomBoats(bool enabled)
    {
        CryVNative.Native_Vehicle_SetRandomBoats(CryVNative.Plugin, enabled);
    }

    public static void SetNumberOfParkedVehicles(int amount)
    {
        CryVNative.Native_Vehicle_SetNumberOfParkedVehicles(CryVNative.Plugin, amount);
    }

    public static void SetParkedVehicleDensityMultiplierThisFrame(float multiplier)
    {
        CryVNative.Native_Vehicle_SetParkedVehicleDensityMultiplierThisFrame(CryVNative.Plugin, multiplier);
    }

    public static void SetRandomVehicleDensityMultiplierThisFrame(float multiplier)
    {
        CryVNative.Native_Vehicle_SetRandomVehicleDensityMultiplierThisFrame(CryVNative.Plugin, multiplier);
    }

    public static void SetVehicleDensityMultiplierThisFrame(float multiplier)
    {
        CryVNative.Native_Vehicle_SetVehicleDensityMultiplierThisFrame(CryVNative.Plugin, multiplier);
    }

    public static void SetFarDrawVehicles(bool enabled)
    {
        CryVNative.Native_Vehicle_SetFarDrawVehicles(CryVNative.Plugin, enabled);
    }

    public static void SetAllLowPriorityVehicleGeneratorsActive(bool active)
    {
        CryVNative.Native_Vehicle_SetAllLowPriorityVehicleGeneratorsActive(CryVNative.Plugin, active);
    }

    public static void DisplayDistantVehicles(bool enabled)
    {
        CryVNative.Native_Vehicle_DisplayDistantVehicles(CryVNative.Plugin, enabled);
    }

    public static void SetCreateRandomCops(bool enabled)
    {
        CryVNative.Native_Ped_SetCreateRandomCops(CryVNative.Plugin, enabled);
    }

    public static void CanCreateRandomPed(bool p1)
    {
        CryVNative.Native_Ped_CanCreateRandomPed(CryVNative.Plugin, p1);
    }

    public static void SetPedDensityMultiplierThisFrame(float multiplier)
    {
        CryVNative.Native_Ped_SetPedDensityMultiplierThisFrame(CryVNative.Plugin, multiplier);
    }

    public static void SetScenarioPedDensityMultiplierThisFrame(float p1, float p2)
    {
        CryVNative.Native_Ped_SetScenarioPedDensityMultiplierThisFrame(CryVNative.Plugin, p1, p2);
    }

    private static string? ConvertWeatherTypeToName(WeatherType weatherType)
    {
        if(Enum.IsDefined(typeof(WeatherType), weatherType) == false)
        {
            return null;
        }

        return weatherType.ToString().ToUpperInvariant();
    }

}
