using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CryV.Net.Native
{
    internal static partial class CryVNative
    {
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Pad_DisableAllControlActions(IntPtr plugin, int inputGroup);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Pad_DisableControlAction(IntPtr plugin, int inputGroup, int control, bool disable);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Pad_DisableInputGroup(IntPtr plugin, int inputGroup);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Pad_EnableAllControlActions(IntPtr plugin, int inputGroup);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Pad_EnableControlAction(IntPtr plugin, int inputGroup, int control, bool enable);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Native_Pad_GetControlInstructionalButton(IntPtr plugin, int inputGroup, int control, int p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Pad_GetControlNormal(IntPtr plugin, int inputGroup, int control);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Pad_GetControlValue(IntPtr plugin, int inputGroup, int control);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Pad_GetDisabledControlNormal(IntPtr plugin, int inputGroup, int control);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Pad_GetLocalPlayerAimState(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Pad_IsControlEnabled(IntPtr plugin, int inputGroup, int control);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Pad_IsControlJustPressed(IntPtr plugin, int inputGroup, int control);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Pad_IsControlJustReleased(IntPtr plugin, int inputGroup, int control);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Pad_IsControlPressed(IntPtr plugin, int inputGroup, int control);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Pad_IsControlReleased(IntPtr plugin, int inputGroup, int control);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Pad_IsDisabledControlJustPressed(IntPtr plugin, int inputGroup, int control);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Pad_IsDisabledControlJustReleased(IntPtr plugin, int inputGroup, int control);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Pad_IsDisabledControlPressed(IntPtr plugin, int inputGroup, int control);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Pad_IsInputDisabled(IntPtr plugin, int inputGroup);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Pad_IsInputJustDisabled(IntPtr plugin, int inputGroup);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Pad_IsLookInverted(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Pad__0x0F70731BACCFBB96(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Pad__0x14D29BB12D47F68C(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Pad__0x23F09EADC01449D6(IntPtr plugin, bool p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Pad__0x3D42B92563939375(IntPtr plugin, IntPtr p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Pad__0x4683149ED1DDE7A1(IntPtr plugin, IntPtr p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Pad__0x4F8A26A890FD62FB(IntPtr plugin, int inputGroup, int control);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Pad__0x59B9A7AF4C95133C(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Pad__0x5B73C77D9EB66E24(IntPtr plugin, bool p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Pad__0x5B84D09CEC5209C5(IntPtr plugin, int inputGroup, int control);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Pad__0x643ED62D5EA3BEBD(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Pad__0x6CD79468A1E595C6(IntPtr plugin, int inputGroup);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Native_Pad__0x80C2FD58D720C801(IntPtr plugin, int inputGroup, int control, bool p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Pad__0x8290252FFF36ACB5(IntPtr plugin, int p0, int red, int green, int blue);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Pad__0xA0CEFCEA390AAB9B(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Pad__0xCB0360EFEFB2580D(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Pad__0xD7D22F5592AED8BA(IntPtr plugin, int p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Pad__0xE1615EC03B3BB4FD(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Pad__0xF239400E16C23E08(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Pad__0xFB6C4072E9A32E92(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Pad__0xFC859E2374407556(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Pad_SetControlNormal(IntPtr plugin, int inputGroup, int control, float amount);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Pad_SetCursorLocation(IntPtr plugin, float x, float y);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Pad_SetInputExclusive(IntPtr plugin, int inputGroup, int control);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Pad_SetPadShake(IntPtr plugin, int p0, int duration, int frequency);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Pad_SetPlayerpadShakesWhenControllerDisabled(IntPtr plugin, bool toggle);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Pad_StopPadShake(IntPtr plugin, ulong p0);
    }
}
