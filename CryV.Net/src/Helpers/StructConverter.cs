using System;
using System.Runtime.InteropServices;
using CryV.Net.Native;

namespace CryV.Net.Helpers
{
    internal static class StructConverter
    {

        public static T PointerToStruct<T>(IntPtr pointer, bool freePointer = true)
        {
            var value = Marshal.PtrToStructure<T>(pointer);

            if (freePointer)
            {
                CryVNative.Native_Utility_FreeObject(pointer);
            }

            return value;
        }

    }
}
