using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CryV.Net.Native
{
    internal static partial class CryVNative
    {
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Decorator_DecorExistOn(IntPtr plugin, int entity, IntPtr propertyName);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Decorator_DecorGetBool(IntPtr plugin, int entity, IntPtr propertyName);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Decorator_DecorGetFloat(IntPtr plugin, int entity, IntPtr propertyName);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Decorator_DecorGetInt(IntPtr plugin, int entity, IntPtr propertyName);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Decorator_DecorIsRegisteredAsType(IntPtr plugin, IntPtr propertyName, int type);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Decorator_DecorRegister(IntPtr plugin, IntPtr propertyName, int type);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Decorator_DecorRegisterLock(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Decorator_DecorRemove(IntPtr plugin, int entity, IntPtr propertyName);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Decorator_DecorSetBool(IntPtr plugin, int entity, IntPtr propertyName, bool value);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Decorator_DecorSetFloat(IntPtr plugin, int entity, IntPtr propertyName, float value);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Decorator_DecorSetInt(IntPtr plugin, int entity, IntPtr propertyName, int value);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Decorator_DecorSetTime(IntPtr plugin, int entity, IntPtr propertyName, int timestamp);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Decorator__0x241FCA5B1AA14F75(IntPtr plugin);
    }
}
