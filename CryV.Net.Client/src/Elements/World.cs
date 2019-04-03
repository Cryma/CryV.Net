﻿using CryV.Net.Client.Native;
using CryV.Net.Client.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Text;

namespace CryV.Net.Client.Elements
{
    public static class World
    {

        public static void SetWeather(WeatherType weatherType)
        {
            var weatherName = ConvertWeatherTypeToName(weatherType);
            if(string.IsNullOrEmpty(weatherName))
            {
                return;
            }

            using (var converter = new StringConverter())
            {
                var weatherPointer = converter.StringToPointer(weatherName);

                CryVNative.Native_World_SetWeather(CryVNative.Plugin, weatherPointer);
            }
        }

        public static List<Ped> GetAllPeds(bool includeSelf = true)
        {
            var pedsPointer = CryVNative.Native_World_GetAllPeds(CryVNative.Plugin);
            var arrayLength = Marshal.ReadInt32(pedsPointer);

            var start = IntPtr.Add(pedsPointer, 4);
            var peds = new int[arrayLength];

            Marshal.Copy(start, peds, 0, arrayLength);

            CryVNative.Native_Utility_FreeArray(pedsPointer);

            var pedList = new List<Ped>();
            foreach (var ped in peds)
            {
                if (includeSelf && ped == LocalPlayer.PedId())
                {
                    continue;
                }

                pedList.Add(new Ped(ped));
            }

            return pedList;
        }

        public static List<Vehicle> GetAllVehicles()
        {
            var vehiclesPointer = CryVNative.Native_World_GetAllVehicles(CryVNative.Plugin);
            var arrayLength = Marshal.ReadInt32(vehiclesPointer);

            var start = IntPtr.Add(vehiclesPointer, 4);
            var vehicles = new int[arrayLength];

            Marshal.Copy(start, vehicles, 0, arrayLength);

            var vehicleList = new List<Vehicle>();
            foreach (var vehicle in vehicles)
            {
                vehicleList.Add(new Vehicle(vehicle));
            }

            return vehicleList;
        }

        public static void SetRandomTrains(bool enabled)
        {
            CryVNative.Native_World_SetRandomTrains(CryVNative.Plugin, enabled);
        }

        public static void SetRandomBoats(bool enabled)
        {
            CryVNative.Native_World_SetRandomBoats(CryVNative.Plugin, enabled);
        }

        public static void SetNumberOfParkedVehicles(int amount)
        {
            CryVNative.Native_World_SetNumberOfParkedVehicles(CryVNative.Plugin, amount);
        }

        public static void SetParkedVehicleDensityMultiplierThisFrame(float multiplier)
        {
            CryVNative.Native_World_SetParkedVehicleDensityMultiplierThisFrame(CryVNative.Plugin, multiplier);
        }

        public static void SetRandomVehicleDensityMultiplierThisFrame(float multiplier)
        {
            CryVNative.Native_World_SetRandomVehicleDensityMultiplierThisFrame(CryVNative.Plugin, multiplier);
        }

        public static void SetVehicleDensityMultiplierThisFrame(float multiplier)
        {
            CryVNative.Native_World_SetVehicleDensityMultiplierThisFrame(CryVNative.Plugin, multiplier);
        }

        public static void SetFarDrawVehicles(bool enabled)
        {
            CryVNative.Native_World_SetFarDrawVehicles(CryVNative.Plugin, enabled);
        }

        public static void SetAllLowPriorityVehicleGeneratorsActive(bool active)
        {
            CryVNative.Native_World_SetAllLowPriorityVehicleGeneratorsActive(CryVNative.Plugin, active);
        }

        public static void DisplayDistantVehicles(bool enabled)
        {
            CryVNative.Native_World_DisplayDistantVehicles(CryVNative.Plugin, enabled);
        }

        public static void SetCreateRandomCops(bool enabled)
        {
            CryVNative.Native_World_SetCreateRandomCops(CryVNative.Plugin, enabled);
        }

        public static void CanCreateRandomPed(bool p1)
        {
            CryVNative.Native_World_CanCreateRandomPed(CryVNative.Plugin, p1);
        }

        public static void SetPedDensityMultiplierThisFrame(float multiplier)
        {
            CryVNative.Native_World_SetPedDensityMultiplierThisFrame(CryVNative.Plugin, multiplier);
        }

        public static void SetScenarioPedDensityMultiplierThisFrame(float p1, float p2)
        {
            CryVNative.Native_World_SetScenarioPedDensityMultiplierThisFrame(CryVNative.Plugin, p1, p2);
        }

        private static string ConvertWeatherTypeToName(WeatherType weatherType)
        {
            if(Enum.IsDefined(typeof(WeatherType), weatherType) == false)
            {
                return null;
            }

            return weatherType.ToString().ToUpperInvariant();
        }

    }
}
