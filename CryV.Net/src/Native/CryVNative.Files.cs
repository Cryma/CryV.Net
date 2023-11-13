using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CryV.Net.Native;

internal static partial class CryVNative
{
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Files__0xD40AAC51E8E4C663(IntPtr plugin, ulong propHash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Files__0xD81B7F27BC773E66(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4);
}
