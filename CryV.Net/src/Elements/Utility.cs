using System;
using System.Numerics;
using System.Text;
using CryV.Net.Helpers;
using CryV.Net.Native;

namespace CryV.Net.Elements
{
    public static class Utility
    {

        public static void Log(string message)
        {
            using (var converter = new StringConverter())
            {
                var messagePointer = converter.StringToPointer(message);

                CryVNative.Native_Utility_Log(CryVNative.Plugin, messagePointer);
            }
        }

        public static void Wait(int ms)
        {
            CryVNative.Native_Gameplay_Wait(CryVNative.Plugin, 0);
        }

        public static ulong GetHashKey(string name)
        {
            using (var converter = new StringConverter())
            {
                var namePointer = converter.StringToPointer(name);

                return CryVNative.Native_Gameplay_GetHashKey(CryVNative.Plugin, namePointer);
            }
        }

        public static void FreeObject(IntPtr pointer)
        {
            CryVNative.Native_Utility_FreeObject(pointer);
        }

        public static void FreeArray(IntPtr array)
        {
            CryVNative.Native_Utility_FreeArray(array);
        }

        public static bool IsKeyReleased(ConsoleKey key)
        {
            return CryVNative.Native_Utility_IsKeyReleased(CryVNative.Plugin, (ulong) key);
        }

        public static uint Joaat(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                return 0;
            }

            var characters = Encoding.UTF8.GetBytes(data.ToLower());

            uint hash = 0;

            foreach (var t in characters)
            {
                hash += t;
                hash += hash << 10;
                hash ^= hash >> 6;
            }

            hash += hash << 3;
            hash ^= hash >> 11;
            hash += hash << 15;

            return hash;
        }

        public static Vector3 RotationToDirection(Vector3 rotation)
        {
            var x = DegreeToRadian(rotation.X);
            var z = DegreeToRadian(rotation.Z);

            var value = Math.Abs(Math.Cos(x));

            return new Vector3((float) (-Math.Sin(z) * value), (float) (Math.Cos(z) * value), (float) Math.Sin(x));
        }

        private static double DegreeToRadian(double degree)
        {
            return degree * Math.PI / 180.0d;
        }

    }
}