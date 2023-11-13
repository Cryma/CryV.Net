using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CryV.Net.Native;

internal static partial class CryVNative
{
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Socialclub_GetTotalScInboxIds(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Socialclub_IsScInboxValid(IntPtr plugin, int p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Socialclub__0x07C61676E5BB52CD(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Socialclub__0x07DBD622D9533857(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Socialclub__0x0F73393BAC7E6730(IntPtr plugin, ref ulong p0, ref int p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Socialclub__0x116FB94DC4B79F17(IntPtr plugin, IntPtr p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Socialclub__0x16DA8172459434AA(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Socialclub__0x19853B5B17D77BCA(IntPtr plugin, ulong p0, ref ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Socialclub__0x1989C6E6F67E76A8(IntPtr plugin, ref ulong p0, ref ulong p1, ref ulong p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Socialclub__0x1D4446A62D35B0D0(IntPtr plugin, ulong p0, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Socialclub__0x1F1E9682483697C7(IntPtr plugin, ulong p0, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Socialclub__0x225798743970412B(IntPtr plugin, ref int p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Socialclub__0x287F1F75D2803595(IntPtr plugin, ulong p0, ref ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Socialclub__0x2E89990DDFF670C3(IntPtr plugin, ulong p0, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Socialclub__0x3001BEF2FECA3680(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Socialclub__0x418DC16FAE452C1C(IntPtr plugin, int p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Socialclub__0x44ACA259D67651DB(IntPtr plugin, ref ulong p0, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Socialclub__0x4737980E8A283806(IntPtr plugin, int p0, ref ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Socialclub__0x487912FD248EFDDF(IntPtr plugin, ulong p0, float p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Socialclub__0x4A7D6E727F941747(IntPtr plugin, ref ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Socialclub__0x5C4EBFFA98BDB41C(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Socialclub__0x675721C9F644D161(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Socialclub__0x699E4A5C8C893A18(IntPtr plugin, int p0, IntPtr p1, ref ulong p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Socialclub__0x6AFD2CD753FEEF83(IntPtr plugin, IntPtr playerName);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Socialclub__0x6BFB12CE158E3DD4(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Socialclub__0x700569DBA175A77C(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Socialclub__0x7DB18CA8CAD5B098(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Socialclub__0x8147FFF6A718E1AD(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Socialclub__0x8416FE4E4629D7D7(IntPtr plugin, IntPtr p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Socialclub__0x85535ACF97FC0969(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Socialclub__0x87E0052F08BD64E6(IntPtr plugin, ulong p0, ref int p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Socialclub__0x8CC469AB4D349B7C(IntPtr plugin, int p0, IntPtr p1, ref ulong p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Socialclub__0x9237E334F6E43156(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Socialclub__0x92DA6E70EF249BD1(IntPtr plugin, IntPtr p0, ref int p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Socialclub__0x930DE22F07B1CCE3(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Socialclub__0xA68D3D229F4F3B06(IntPtr plugin, IntPtr p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Socialclub__0xBC1CC91205EC8D6E(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Socialclub__0xBFA0A56A817C6C7D(IntPtr plugin, bool p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Socialclub__0xD0EE05FE193646EA(IntPtr plugin, ref ulong p0, ref ulong p1, ref ulong p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Socialclub__0xD302E99EDF0449CF(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Socialclub__0xD8122C407663B995(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Socialclub__0xDA024BDBD600F44A(IntPtr plugin, ref int networkHandle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Socialclub__0xDF649C4E9AFDD788(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Socialclub__0xEB2BF817463DFA28(IntPtr plugin, ulong p0, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Socialclub__0xF22CA0FD74B80E7A(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Socialclub__0xF6BAAAF762E1BF40(IntPtr plugin, IntPtr p0, ref int p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Socialclub__0xFE4C1D0D3B9CC17E(IntPtr plugin, ulong p0, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Socialclub__0xFF8F3A92B75ED67A(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Socialclub_ScEmailMessageClearRecipList(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Socialclub_ScEmailMessagePushGamerToRecipList(IntPtr plugin, ref int player);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Socialclub_ScGetCheckStringStatus(IntPtr plugin, int taskHandle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Socialclub_ScGetNickname(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Socialclub_ScHasCheckStringTaskCompleted(IntPtr plugin, int taskHandle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Socialclub_ScInboxGetEmails(IntPtr plugin, int offset, int limit);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Socialclub_ScInboxMessageGetDataBool(IntPtr plugin, int p0, IntPtr p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Socialclub_ScInboxMessageGetDataInt(IntPtr plugin, int p0, IntPtr context, ref int @out);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Socialclub_ScInboxMessageGetDataString(IntPtr plugin, int p0, IntPtr context, IntPtr @out);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern IntPtr Native_Socialclub_ScInboxMessageGetString(IntPtr plugin, int p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Socialclub_ScInboxMessageGetUgcdata(IntPtr plugin, ulong p0, ref ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Socialclub_ScInboxMessageInit(IntPtr plugin, int p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Socialclub_ScInboxMessagePop(IntPtr plugin, int p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Socialclub_ScInboxMessagePush(IntPtr plugin, int p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Socialclub_ScStartCheckStringTask(IntPtr plugin, IntPtr @string, ref int taskHandle);
}
