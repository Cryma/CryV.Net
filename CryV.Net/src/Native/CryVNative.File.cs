using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CryV.Net.Native;

internal static partial class CryVNative
{
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_File_GetDlcVehicleData(IntPtr plugin, int dlcVehicleIndex, ref int outData);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_File_GetDlcVehicleFlags(IntPtr plugin, int dlcVehicleIndex);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_File_GetDlcVehicleModel(IntPtr plugin, int dlcVehicleIndex);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_File_GetDlcWeaponComponentData(IntPtr plugin, int dlcWeaponIndex, int dlcWeapCompIndex, ref ulong ComponentDataPtr);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_File_GetDlcWeaponData(IntPtr plugin, int dlcWeaponIndex, ref int outData);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_File_GetForcedComponent(IntPtr plugin, ulong componentHash, int componentId, ref ulong p2, ref ulong p3, ref ulong p4);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_File_GetHashNameForComponent(IntPtr plugin, int entity, int componentId, int drawableVariant, int textureVariant);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_File_GetHashNameForProp(IntPtr plugin, int entity, int componentId, int propIndex, int propTextureIndex);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_File_GetNumDecorations(IntPtr plugin, int character);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_File_GetNumDlcVehicles(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_File_GetNumDlcWeaponComponents(IntPtr plugin, int dlcWeaponIndex);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_File_GetNumDlcWeapons(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_File_GetNumForcedComponents(IntPtr plugin, ulong componentHash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_File_GetNumPropsFromOutfit(IntPtr plugin, int character, int p1, int p2, bool p3, int p4, int componentId);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_File_GetPropFromOutfit(IntPtr plugin, ulong outfit, int slot, ref ulong item);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_File_GetShopPedComponent(IntPtr plugin, ulong p0, ref ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_File_GetShopPedOutfit(IntPtr plugin, ulong p0, ref ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_File_GetShopPedOutfitLocate(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_File_GetShopPedQueryComponent(IntPtr plugin, int componentId, ref int outComponent);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_File_GetShopPedQueryOutfit(IntPtr plugin, ulong p0, ref ulong outfit);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_File_GetShopPedQueryProp(IntPtr plugin, ulong p0, ref ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_File_GetTattooCollectionData(IntPtr plugin, int characterType, int decorationIndex, ref ulong outComponent);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_File_GetVariantComponent(IntPtr plugin, ulong componentHash, int componentId, ref ulong p2, ref ulong p3, ref ulong p4);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_File_InitShopPedComponent(IntPtr plugin, ref int outComponent);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_File_InitShopPedProp(IntPtr plugin, ref int outProp);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_File_IsDlcDataEmpty(IntPtr plugin, ref ulong dlcData);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_File_IsDlcVehicleMod(IntPtr plugin, ulong modData);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_File__0x017568A8182D98A6(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_File__0x341DE7ED1D2A1BFD(IntPtr plugin, ulong componentHash, ulong drawableSlotHash, int componentId);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_File__0x50F457823CE6EB5F(IntPtr plugin, int p0, int p1, int p2, int p3);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_File__0x5D5CAFF661DDF6FC(IntPtr plugin, ulong p0, ref ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_File__0xA9F9C2E0FDE11CBB(IntPtr plugin, ulong p0, ulong p1, ref ulong p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_File__0xC098810437312FFF(IntPtr plugin, int modData);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_File__0xC17AD0E5752BECDA(IntPtr plugin, ulong componentHash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_File__0xE1CA84EBF72E691D(IntPtr plugin, ulong p0, ulong p1, ref ulong p2, ref ulong p3, ref ulong p4);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_File__0xF3FBE2D50A6A8C28(IntPtr plugin, int character, bool p1);
}
