using CryV.Net.Client.Native;
using CryV.Net.Client.Enums;
using System;
using System.Collections.Generic;
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
