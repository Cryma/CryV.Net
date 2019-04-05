using System;
using System.Runtime.InteropServices;

namespace CryV.Net.Client.Native
{
    public static partial class CryVNative
    {

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_UserInterface_SetTextFont(IntPtr plugin, int fontType);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_UserInterface_SetTextScale(IntPtr plugin, float scale, float size);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_UserInterface_SetTextColour(IntPtr plugin, int red, int green, int blue, int alpha);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_UserInterface_SetTextWrap(IntPtr plugin, float start, float end);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_UserInterface_SetTextCentre(IntPtr plugin, bool align);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_UserInterface_SetTextDropshadow(IntPtr plugin, int distance, int red, int green, int blue, int alpha);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_UserInterface_SetTextEdge(IntPtr plugin, int p0, int red, int green, int blue, int alpha);

        //

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_UserInterface_BeginTextCommandDisplayText(IntPtr plugin, IntPtr componentType);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_UserInterface_AddTextComponentSubstringPlayerName(IntPtr plugin, IntPtr text);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_UserInterface_EndTextCommandDisplayText(IntPtr plugin, float x, float y);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_UserInterface_GetScreenResolution(IntPtr plugin, ref int x, ref int y);

        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_UserInterface_DrawRect(IntPtr plugin, float x, float y, float width, float height, int red, int green, int blue, int alpha);

    }
}