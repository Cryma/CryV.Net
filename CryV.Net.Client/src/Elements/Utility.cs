using System;
using System.Text;
using CryV.Net.Client.Native;

namespace CryV.Net.Client.Elements
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

    }
}