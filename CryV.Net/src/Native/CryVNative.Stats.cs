using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CryV.Net.Native
{
    internal static partial class CryVNative
    {
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Stats_GetNgstatBoolHash(IntPtr plugin, int index, bool spStat, bool charStat, int character, IntPtr section);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Stats_GetNgstatIntHash(IntPtr plugin, int index, bool spStat, bool charStat, int character, IntPtr section);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Stats_GetPstatBoolHash(IntPtr plugin, int index, bool spStat, bool charStat, int character);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Stats_GetPstatIntHash(IntPtr plugin, int index, bool spStat, bool charStat, int character);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Stats_GetTupstatBoolHash(IntPtr plugin, int index, bool spStat, bool charStat, int character);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Stats_GetTupstatIntHash(IntPtr plugin, int index, bool spStat, bool charStat, int character);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Stats_Leaderboards2ReadByHandle(IntPtr plugin, ref ulong p0, ref ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Stats_Leaderboards2ReadByRadius(IntPtr plugin, ref ulong p0, ulong p1, ref ulong p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Stats_Leaderboards2ReadByRank(IntPtr plugin, ref ulong p0, ulong p1, ulong p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Stats_Leaderboards2ReadByRow(IntPtr plugin, ref ulong p0, ref ulong p1, ulong p2, ref ulong p3, ulong p4, ref ulong p5, ulong p6);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Stats_Leaderboards2ReadByScoreFloat(IntPtr plugin, ref ulong p0, float p1, ulong p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Stats_Leaderboards2ReadByScoreInt(IntPtr plugin, ref ulong p0, ulong p1, ulong p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Stats_Leaderboards2ReadFriendsByRow(IntPtr plugin, ref ulong p0, ref ulong p1, ulong p2, bool p3, ulong p4, ulong p5);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Stats_Leaderboards2WriteData(IntPtr plugin, ref ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Stats_LeaderboardsCacheDataRow(IntPtr plugin, ref ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats_LeaderboardsClearCacheData(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats_LeaderboardsDeaths(IntPtr plugin, ulong statName, float value);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Stats_LeaderboardsGetCacheDataRow(IntPtr plugin, ulong p0, ulong p1, ref ulong p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Stats_LeaderboardsGetCacheExists(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Stats_LeaderboardsGetCacheTime(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Stats_LeaderboardsGetColumnId(IntPtr plugin, ulong p0, ulong p1, ulong p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Stats_LeaderboardsGetColumnType(IntPtr plugin, ulong p0, ulong p1, ulong p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Stats_LeaderboardsGetNumberOfColumns(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Stats_LeaderboardsReadClear(IntPtr plugin, ulong p0, ulong p1, ulong p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Stats_LeaderboardsReadClearAll(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Stats_LeaderboardsReadPending(IntPtr plugin, ulong p0, ulong p1, ulong p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Stats_LeaderboardsReadSuccessful(IntPtr plugin, ulong p0, ulong p1, ulong p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x015B03EE1C43E6EC(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x03C2EEBB04B3FB72(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4, ulong p5, ulong p6);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x047CBED6F6F8B63C(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x04D90BA8207ADA2D(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x06EAF70AE066441E(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x098760C7461724CD(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x0A50D2604E05CB94(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x0A9C7F36E5D7B683(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x0B565B0AAE56A0E8(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4, ulong p5, ulong p6);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Stats__0x0B8B7F74BF061C6D(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x0BCA1D2C47B0D269(IntPtr plugin, ulong p0, ulong p1, float p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x0D01D20616FC73FB(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x0EACDF8487D5155A(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x11FF1C80276097ED(IntPtr plugin, IntPtr p0, ulong p1, ulong p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x121FB4DDDC2D5291(IntPtr plugin, ulong p0, ulong p1, ulong p2, float p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x14E0B2D1AD1044E0(IntPtr plugin, ref ulong p0, ref ulong p1, ref ulong p2, ref ulong p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x14EDA9EE27BD1626(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x164C5FF663790845(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x1A7CE7CD3E653485(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Stats__0x1A8EA222F9C67DBB(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x1CAE5D2E3F9A07F0(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4, ulong p5);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x203B381133817079(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x2605663BD4F23B5D(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x26D7399B9587FE89(IntPtr plugin, int p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x27AA1C973CACFE63(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4, ulong p5, ulong p6, ulong p7, ulong p8, ulong p9);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x282B6739644F4347(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x28ECB8AC2F607DB2(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x2B69F5074C894811(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x2CD90358F67D0AA8(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x2E65248609523599(IntPtr plugin, ulong p0, ulong p1, ulong p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x30A6614C1F7799B8(IntPtr plugin, ulong p0, float p1, ulong p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Stats__0x3270F67EED31FBC1(IntPtr plugin, ulong p0, ref ulong p1, ref ulong p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Stats__0x32CAC93C9DE73D32(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Stats__0x33D72899E24C3365(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Stats__0x34770B9CE0E03B91(IntPtr plugin, ulong p0, ref ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern float Native_Stats__0x38491439B6BA7F7D(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x38BAAA5DD4C9D19F(IntPtr plugin, int value);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x3DE3AA516FB126A4(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x3EBEAC6C3F81F6BD(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x419615486BBF1956(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x44919CC079BB60BF(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x46326E13DA4E0546(IntPtr plugin, ref ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x47B32F5611E6E483(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Stats__0x4C89FE2BDEB3F169(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Stats__0x4FEF53183C3C6414(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x5009DFD741329729(IntPtr plugin, IntPtr p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x501478855A6074CE(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4, ulong p5);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x516FC96EB88EEFE5(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x53CAE13E9B426993(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x55384438FC55AD8E(IntPtr plugin, int value);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Stats__0x55A8BECAF28A4EB7(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Stats__0x567384DFA67029E6(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x5688585E6D563CD8(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Stats__0x58A651CD201D89AD(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Stats__0x5A556B229A169402(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Stats__0x5BD5F255321C4AAF(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x5DA3A8DE8CB6226F(IntPtr plugin, int time);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Stats__0x5EAD2BF6484852E4(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x5FF2C33B13A02A11(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x60EEDC12AF66E846(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x629526ABA383BCAA(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x6483C25849031C4F(IntPtr plugin, ulong p0, ulong p1, ulong p2, ref ulong p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x6551B1F7F6CD46EA(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x678F86D8FC040BDB(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x6A60E43998228229(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x6BC0ACD0673ACEBE(IntPtr plugin, ulong p0, ulong p1, ulong p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x6BCCF9948492FD85(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Stats__0x6DEE77AFF8C21BD1(IntPtr plugin, ref ulong p0, ref ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Stats__0x6E0A5253375C4584(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x6F361B8889A792A3(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x7033EEFD9B28088E(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x71862B1D855F32E1(IntPtr plugin, ref ulong p0, ulong p1, ulong p2, ulong p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x71B008056E5692D6(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x723C1CE13FBFDB67(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x73001E34F85137F8(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x792271AB35C356A4(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x79AB33F0FBFAC40C(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x7B18DA61F6BAE9D5(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x7D36291161859389(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x7D8BA05688AD64C7(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Stats__0x7E6946F68A38B74F(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x7EEC2A316C250073(IntPtr plugin, ulong p0, ulong p1, ulong p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Stats__0x7F2C4CDF2E82DF4C(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x848B66100EE33B05(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Stats__0x84A810B375E69C0E(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x84DFC579C2FC214C(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x88087EE1F28024AE(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Stats__0x88578F6EC36B4A3A(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Stats__0x886913BBEACA68C1(IntPtr plugin, ref ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x8989CBD7B4E82534(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4, ulong p5, ulong p6);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x8A800DACCC0DA55D(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Stats__0x8B9CDBD6C566C38C(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x8C9D11605E59D955(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x8D8ADB562F09A245(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x8EC74CEB042E7CFF(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x90D0622866E80445(IntPtr plugin, int p0, IntPtr p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x928DBFB892638EF3(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x930F504203F561C9(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Stats__0x94F12ABF9C79E339(IntPtr plugin, int p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x96E6D5150DBF1C09(IntPtr plugin, ulong p0, ulong p1, ulong p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x98E2BC1CA26287C3(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Stats__0x9A62EC95AE10E011(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0x9B4BD21D69B1E609(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Stats__0x9EC8858184CD253A(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0xA071E0ED98F91286(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Stats__0xA0F93D5465B3094D(IntPtr plugin, ref ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Stats__0xA31FD15197B192BD(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0xA3C53804BDB68ED2(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Stats__0xA5C80D8E768A9E66(IntPtr plugin, ref ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0xA6F54BB2FFCA35EA(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0xA736CF7FB7C5BFF4(IntPtr plugin, ref ulong p0, ref ulong p1, ref ulong p2, ref ulong p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Stats__0xA761D4AC6115623D(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0xA78B8FA58200DA56(IntPtr plugin, int p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0xA8733668D1047B51(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Stats__0xA943FD1722E11EFD(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0xAA525DFF66BB82F5(IntPtr plugin, ulong p0, ulong p1, ulong p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0xADDD1C754E2E2914(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4, ulong p5, ulong p6, ulong p7, ulong p8, ulong p9);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Stats__0xAFF47709F1D5DCCE(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Stats__0xB1D2BB1E1631F5B1(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Stats__0xB3DA2606774A8E2D(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0xB475F27C6A994D65(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0xB7257BA2550EA10A(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4, ulong p5, ulong p6);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Stats__0xBA9749CC94C1FD85(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0xBAA2F0490E146BE8(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Stats__0xBE3DB208333D9844(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0xBE509B0A3693DE8B(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Stats__0xBED9F5693F34ED17(IntPtr plugin, ulong statName, int p1, ref float outValue);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0xBF371CD2B64212FD(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0xBFAFDB5FAAA5C5AB(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Stats__0xC0E0D686DDFC6EAE(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0xC141B8917E0017EC(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Stats__0xC38DC1E90D22547C(IntPtr plugin, ref ulong p0, ref ulong p1, ref ulong p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0xC5BE134EC7BA96A0(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Stats__0xC6E0E2616A7576BB(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Stats__0xC70DDCE56D0D3A99(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0xC729991A9065376E(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0xC847B43F369AC0B5(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Stats__0xC980E62E33DF1D5C(IntPtr plugin, ref ulong p0, ref ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0xCB00196B31C39EB1(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0xCC25A4553DFBF9EA(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Stats__0xCE5AA445ABA8DEE0(IntPtr plugin, ref ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0xCEA553E35C2246E1(IntPtr plugin, ulong p0, ulong p1, ulong p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0xD1032E482629049E(IntPtr plugin, bool p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0xD1A1EE3B4FA8E760(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0xD1C9B92BDD3F151D(IntPtr plugin, ulong p0, ulong p1, ulong p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0xD558BEC0BBA7E8D2(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0xD6781E42755531F7(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0xDAC073C7901F9E15(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0xDAF80797FC534BEC(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Stats__0xDEAAF77EB3687E97(IntPtr plugin, ulong p0, ref ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0xE3261D791EB44ACB(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Stats__0xE496A53BA5F50A56(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Stats__0xE8853FBCE7D8D0D6(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0xE95C8A1875A02CA4(IntPtr plugin, ulong p0, ulong p1, ulong p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Stats__0xECB41AC6AB754401(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0xEDBF6C9B0D2C65C8(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0xF06A6F41CB445443(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Stats__0xF11F01D98113536A(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0xF1A1803D3476F215(IntPtr plugin, int value);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Stats__0xF1AE5DCDBFCA2721(IntPtr plugin, ref ulong p0, ref ulong p1, ref ulong p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0xF434A10BA01C37D0(IntPtr plugin, bool p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Stats__0xF4D8E7AC2A27758C(IntPtr plugin, int p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0xF4FF020A08BC8863(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0xF534D94DFA2EAD26(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0xF5BB8DAC426A52C0(IntPtr plugin, ref ulong p0, ref ulong p1, ref ulong p2, ref ulong p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0xF6792800AC95350D(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0xF8C54A461C3E11DC(IntPtr plugin, ref ulong p0, ref ulong p1, ref ulong p2, ref ulong p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Stats__0xF9F2922717B819EC(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats__0xFCC228E07217FCAC(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats_PlaystatsAmbientMissionCrateCreated(IntPtr plugin, float p0, float p1, float p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats_PlaystatsAwardXp(IntPtr plugin, ulong p0, ulong p1, ulong p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats_PlaystatsCheatApplied(IntPtr plugin, IntPtr cheat);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats_PlaystatsClothChange(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats_PlaystatsFriendActivity(IntPtr plugin, ulong p0, ulong p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats_PlaystatsMatchStarted(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4, ulong p5, ulong p6);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats_PlaystatsMissionCheckpoint(IntPtr plugin, ref ulong p0, ulong p1, ulong p2, ulong p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats_PlaystatsMissionOver(IntPtr plugin, ref ulong p0, ulong p1, ulong p2, bool p3, bool p4, bool p5);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats_PlaystatsMissionStarted(IntPtr plugin, ref ulong p0, ulong p1, ulong p2, bool p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats_PlaystatsNpcInvite(IntPtr plugin, ref ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats_PlaystatsOddjobDone(IntPtr plugin, ulong p0, ulong p1, ulong p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats_PlaystatsPropChange(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats_PlaystatsRaceCheckpoint(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats_PlaystatsRankUp(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats_PlaystatsShopItem(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats_PlaystatsWebsiteVisited(IntPtr plugin, ulong scaleformHash, int p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Stats_StatClearSlotForReload(IntPtr plugin, int statSlot);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Stats_StatDeleteSlot(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Stats_StatGetBool(IntPtr plugin, ulong statHash, ref bool outValue, ulong p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Stats_StatGetBoolMasked(IntPtr plugin, ulong statName, int mask, int p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Stats_StatGetDate(IntPtr plugin, ulong statHash, ref ulong p1, ulong p2, ulong p3);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Stats_StatGetFloat(IntPtr plugin, ulong statHash, ref float outValue, ulong p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Stats_StatGetInt(IntPtr plugin, ulong statHash, ref int outValue, int p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Native_Stats_StatGetLicensePlate(IntPtr plugin, ulong statName);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Stats_StatGetMaskedInt(IntPtr plugin, ulong p0, ref ulong p1, ulong p2, ulong p3, ulong p4);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Stats_StatGetNumberOfDays(IntPtr plugin, ulong statName);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Stats_StatGetNumberOfHours(IntPtr plugin, ulong statName);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Stats_StatGetNumberOfMinutes(IntPtr plugin, ulong statName);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern int Native_Stats_StatGetNumberOfSeconds(IntPtr plugin, ulong statName);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Stats_StatGetPos(IntPtr plugin, ulong p0, ref ulong p1, ref ulong p2, ref ulong p3, ulong p4);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Native_Stats_StatGetString(IntPtr plugin, ulong statHash, int p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Native_Stats_StatGetUserId(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats_StatIncrement(IntPtr plugin, ulong statName, float value);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Stats_StatLoad(IntPtr plugin, int p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Stats_StatLoadPending(IntPtr plugin, ulong p0);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Stats_StatSave(IntPtr plugin, int p0, bool p1, int p2);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Stats_StatSavePending(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern ulong Native_Stats_StatSavePendingOrRequested(IntPtr plugin);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Stats_StatSetBool(IntPtr plugin, ulong statName, bool value, bool save);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Stats_StatSetBoolMasked(IntPtr plugin, ulong statName, bool value, int mask, bool save);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Stats_StatSetCurrentPosixTime(IntPtr plugin, ulong statName, bool p1);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Stats_StatSetDate(IntPtr plugin, ulong statName, ref ulong value, int numFields, bool save);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Stats_StatSetFloat(IntPtr plugin, ulong statName, float value, bool save);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Stats_StatSetGxtLabel(IntPtr plugin, ulong statName, IntPtr value, bool save);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Stats_StatSetInt(IntPtr plugin, ulong statName, int value, bool save);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Stats_StatSetLicensePlate(IntPtr plugin, ulong statName, IntPtr str);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Stats_StatSetMaskedInt(IntPtr plugin, ulong statName, ulong p1, ulong p2, int p3, bool save);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Stats_StatSetPos(IntPtr plugin, ulong statName, float x, float y, float z, bool save);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern void Native_Stats_StatSetProfileSetting(IntPtr plugin, int profileSetting, int value);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Stats_StatSetString(IntPtr plugin, ulong statName, IntPtr value, bool save);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Stats_StatSetUserId(IntPtr plugin, ulong statName, IntPtr value, bool save);
        [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Native_Stats_StatSlotIsLoaded(IntPtr plugin, ulong p0);
    }
}
