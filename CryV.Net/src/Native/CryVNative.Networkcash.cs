using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CryV.Net.Native;

internal static partial class CryVNative
{
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash_NetworkBuyAirstrike(IntPtr plugin, int cost, bool p1, bool p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash_NetworkBuyBounty(IntPtr plugin, int amount, int victim, bool p2, bool p3);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash_NetworkBuyFairgroundRide(IntPtr plugin, int amountSpent, ulong p1, bool p2, bool p3);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash_NetworkBuyHealthcare(IntPtr plugin, int cost, bool p1, bool p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash_NetworkBuyHeliStrike(IntPtr plugin, int cost, bool p1, bool p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash_NetworkBuyItem(IntPtr plugin, int player, ulong item, ulong p2, ulong p3, bool p4, IntPtr item_name, ulong p6, ulong p7, ulong p8, bool p9);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash_NetworkBuyProperty(IntPtr plugin, float propertyCost, ulong propertyName, bool p2, bool p3);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Networkcash_NetworkCanBet(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Networkcash_NetworkCanReceivePlayerCash(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Networkcash_NetworkCanSpendMoney(IntPtr plugin, ulong p0, bool p1, bool p2, bool p3, ulong p4);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash_NetworkClearCharacterWallet(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash_NetworkDeleteCharacter(IntPtr plugin, int characterIndex, bool p1, bool p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash_NetworkEarnFromAiTargetKill(IntPtr plugin, ulong p0, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash_NetworkEarnFromAmbientJob(IntPtr plugin, int p0, IntPtr p1, ref ulong p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash_NetworkEarnFromArmourTruck(IntPtr plugin, int amount);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash_NetworkEarnFromBetting(IntPtr plugin, int amount, IntPtr p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash_NetworkEarnFromBounty(IntPtr plugin, int amount, ref int networkHandle, ref ulong p2, ulong p3);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash_NetworkEarnFromChallengeWin(IntPtr plugin, ulong p0, ref ulong p1, bool p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash_NetworkEarnFromCrateDrop(IntPtr plugin, int amount);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash_NetworkEarnFromDailyObjective(IntPtr plugin, int p0, IntPtr p1, int p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash_NetworkEarnFromGangPickup(IntPtr plugin, int amount);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash_NetworkEarnFromHoldups(IntPtr plugin, int amount);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash_NetworkEarnFromImportExport(IntPtr plugin, ulong p0, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash_NetworkEarnFromJob(IntPtr plugin, int amount, IntPtr p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash_NetworkEarnFromJobBonus(IntPtr plugin, ulong p0, ref ulong p1, ref ulong p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash_NetworkEarnFromMissionH(IntPtr plugin, int amount, IntPtr heistHash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash_NetworkEarnFromNotBadsport(IntPtr plugin, int amount);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash_NetworkEarnFromPersonalVehicle(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4, ulong p5, ulong p6, ulong p7, ulong p8);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Networkcash_NetworkEarnFromPickup(IntPtr plugin, int amount);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash_NetworkEarnFromProperty(IntPtr plugin, int amount, ulong propertyName);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash_NetworkEarnFromRockstar(IntPtr plugin, int amount);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash_NetworkEarnFromVehicle(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4, ulong p5, ulong p6, ulong p7);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern IntPtr Native_Networkcash_NetworkGetBankBalanceString(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Networkcash_NetworkGetVcBalance(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Networkcash_NetworkGetVcBankBalance(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Networkcash_NetworkGetVcWalletBalance(IntPtr plugin, int character);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash_NetworkGivePlayerJobshareCash(IntPtr plugin, int amount, ref int networkHandle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash_NetworkInitializeCash(IntPtr plugin, int p0, int p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Networkcash_NetworkMoneyCanBet(IntPtr plugin, ulong p0, bool p1, bool p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash_NetworkPayEmployeeWage(IntPtr plugin, ulong p0, bool p1, bool p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash_NetworkPayMatchEntryFee(IntPtr plugin, int value, ref int p1, bool p2, bool p3);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash_NetworkPayUtilityBill(IntPtr plugin, ulong p0, bool p1, bool p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash_NetworkReceivePlayerJobshareCash(IntPtr plugin, int value, ref int networkHandle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash_NetworkRefundCash(IntPtr plugin, int index, IntPtr context, IntPtr reason, bool unk);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash_NetworkSpentAmmoDrop(IntPtr plugin, ulong p0, bool p1, bool p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash_NetworkSpentArrestBail(IntPtr plugin, ulong p0, bool p1, bool p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash_NetworkSpentBetting(IntPtr plugin, ulong p0, ulong p1, ref ulong p2, bool p3, bool p4);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash_NetworkSpentBoatPickup(IntPtr plugin, ulong p0, bool p1, bool p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash_NetworkSpentBounty(IntPtr plugin, ulong p0, bool p1, bool p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash_NetworkSpentBullShark(IntPtr plugin, ulong p0, bool p1, bool p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash_NetworkSpentBuyOfftheradar(IntPtr plugin, ulong p0, bool p1, bool p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash_NetworkSpentBuyPassiveMode(IntPtr plugin, ulong p0, bool p1, bool p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash_NetworkSpentBuyRevealPlayers(IntPtr plugin, ulong p0, bool p1, bool p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash_NetworkSpentBuyWantedlevel(IntPtr plugin, ulong p0, ref ulong p1, bool p2, bool p3);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash_NetworkSpentCallPlayer(IntPtr plugin, ulong p0, ref ulong p1, bool p2, bool p3);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash_NetworkSpentCarwash(IntPtr plugin, ulong p0, ulong p1, ulong p2, bool p3, bool p4);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash_NetworkSpentCashDrop(IntPtr plugin, int amount, bool p1, bool p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash_NetworkSpentCinema(IntPtr plugin, ulong p0, ulong p1, bool p2, bool p3);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash_NetworkSpentFromRockstar(IntPtr plugin, int bank, bool p1, bool p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash_NetworkSpentHeliPickup(IntPtr plugin, ulong p0, bool p1, bool p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash_NetworkSpentHireMercenary(IntPtr plugin, ulong p0, bool p1, bool p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash_NetworkSpentHireMugger(IntPtr plugin, ulong p0, bool p1, bool p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash_NetworkSpentHoldups(IntPtr plugin, ulong p0, bool p1, bool p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash_NetworkSpentInStripclub(IntPtr plugin, ulong p0, bool p1, ulong p2, bool p3);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash_NetworkSpentNoCops(IntPtr plugin, ulong p0, bool p1, bool p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash_NetworkSpentPayVehicleInsurancePremium(IntPtr plugin, int amount, ulong vehicleModel, ref int networkHandle, bool notBankrupt, bool hasTheMoney);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash_NetworkSpentPlayerHealthcare(IntPtr plugin, ulong p0, ulong p1, bool p2, bool p3);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash_NetworkSpentProstitutes(IntPtr plugin, ulong p0, bool p1, bool p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash_NetworkSpentRequestHeist(IntPtr plugin, ulong p0, bool p1, bool p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash_NetworkSpentRequestJob(IntPtr plugin, ulong p0, bool p1, bool p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash_NetworkSpentRobbedByMugger(IntPtr plugin, int amount, bool p1, bool p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash_NetworkSpentTaxi(IntPtr plugin, int amount, bool p1, bool p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash_NetworkSpentTelescope(IntPtr plugin, ulong p0, bool p1, bool p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Networkcash__0x1C2473301B1C66BA(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Networkcash__0x6FCF8DDEA146C45B(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Networkcash__0x7303E27CC6532080(IntPtr plugin, ulong p0, bool p1, bool p2, bool p3, ref ulong p4, ulong p5);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Networkcash__0x7C4FCCD2E4DEB394(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Networkcash__0xDC18531D7019A535(IntPtr plugin, ulong p0, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Networkcash__0xE154B48B68EF72BC(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Networkcash__0xE260E0BB9CD995AC(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Networkcash__0xF70EFA14FE091429(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern IntPtr Native_Networkcash_ProcessCashGift(IntPtr plugin, ref int p0, ref int p1, IntPtr p2);
}
