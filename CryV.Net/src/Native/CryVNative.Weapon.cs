using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CryV.Net.Native;

internal static partial class CryVNative
{
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Weapon_AddAmmoToPed(IntPtr plugin, int ped, ulong weaponHash, int ammo);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Weapon_CanUseWeaponOnParachute(IntPtr plugin, ulong weaponHash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Weapon_ClearEntityLastWeaponDamage(IntPtr plugin, int entity);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Weapon_ClearPedLastWeaponDamage(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Weapon_CreateWeaponObject(IntPtr plugin, ulong weaponHash, int ammoCount, float x, float y, float z, bool showWorldModel, float heading, ulong p7);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Weapon_DoesWeaponTakeWeaponComponent(IntPtr plugin, ulong weaponHash, ulong componentHash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Weapon_EnableLaserSightRendering(IntPtr plugin, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Weapon_ExplodeProjectiles(IntPtr plugin, int ped, ulong weaponHash, bool p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Weapon_GetAmmoInClip(IntPtr plugin, int ped, ulong weaponHash, ref int ammo);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Weapon_GetAmmoInPedWeapon(IntPtr plugin, int ped, ulong weaponhash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Weapon_GetBestPedWeapon(IntPtr plugin, int ped, bool p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Weapon_GetCurrentPedVehicleWeapon(IntPtr plugin, int ped, ref ulong weaponHash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Weapon_GetCurrentPedWeapon(IntPtr plugin, int ped, ref ulong weaponHash, bool p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Weapon_GetCurrentPedWeaponEntityIndex(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Weapon_GetIsPedGadgetEquipped(IntPtr plugin, int ped, ulong gadgetHash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern float Native_Weapon_GetLockonRangeOfCurrentPedWeapon(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Weapon_GetMaxAmmo(IntPtr plugin, int ped, ulong weaponHash, ref int ammo);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Weapon_GetMaxAmmoInClip(IntPtr plugin, int ped, ulong weaponHash, bool p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern float Native_Weapon_GetMaxRangeOfCurrentPedWeapon(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Weapon_GetPedAmmoByType(IntPtr plugin, int ped, ulong ammoType);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Weapon_GetPedAmmoTypeFromWeapon(IntPtr plugin, int ped, ulong weaponHash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Weapon_GetPedAmmoTypeFromWeapon2(IntPtr plugin, int ped, ulong weaponHash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Weapon_GetPedWeaponTintIndex(IntPtr plugin, int ped, ulong weaponHash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Weapon_GetPedWeapontypeInSlot(IntPtr plugin, int ped, ulong weaponSlot);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Weapon_GetSelectedPedWeapon(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Weapon_GetWeaponClipSize(IntPtr plugin, ulong weaponHash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Weapon_GetWeaponComponentHudStats(IntPtr plugin, ulong componentHash, ref int outData);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Weapon_GetWeaponComponentTypeModel(IntPtr plugin, ulong componentHash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern float Native_Weapon_GetWeaponDamage(IntPtr plugin, ulong weaponHash, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Weapon_GetWeaponDamageType(IntPtr plugin, ulong weaponHash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Weapon_GetWeaponHudStats(IntPtr plugin, ulong weaponHash, ref ulong outData);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Weapon_GetWeaponObjectFromPed(IntPtr plugin, int ped, bool p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Weapon_GetWeaponObjectTintIndex(IntPtr plugin, int weapon);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Weapon_GetWeaponTintCount(IntPtr plugin, ulong weaponHash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Weapon_GetWeapontypeGroup(IntPtr plugin, ulong weaponHash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Weapon_GetWeapontypeModel(IntPtr plugin, ulong weaponHash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Weapon_GetWeapontypeSlot(IntPtr plugin, ulong weaponHash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Weapon_GiveDelayedWeaponToPed(IntPtr plugin, int ped, ulong weaponHash, int ammoCount, bool equipNow);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Weapon_GiveWeaponComponentToPed(IntPtr plugin, int ped, ulong weaponHash, ulong componentHash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Weapon_GiveWeaponComponentToWeaponObject(IntPtr plugin, int weaponObject, ulong addonHash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Weapon_GiveWeaponObjectToPed(IntPtr plugin, int weaponObject, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Weapon_GiveWeaponToPed(IntPtr plugin, int ped, ulong weaponHash, int ammoCount, bool isHidden, bool equipNow);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Weapon_HasEntityBeenDamagedByWeapon(IntPtr plugin, int entity, ulong weaponHash, int weaponType);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Weapon_HasPedBeenDamagedByWeapon(IntPtr plugin, int ped, ulong weaponHash, int weaponType);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Weapon_HasPedGotWeapon(IntPtr plugin, int ped, ulong weaponHash, bool p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Weapon_HasPedGotWeaponComponent(IntPtr plugin, int ped, ulong weaponHash, ulong componentHash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Weapon_HasVehicleGotProjectileAttached(IntPtr plugin, int driver, int vehicle, ulong weaponHash, ulong p3);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Weapon_HasWeaponAssetLoaded(IntPtr plugin, ulong weaponHash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Weapon_HasWeaponGotWeaponComponent(IntPtr plugin, int weapon, ulong addonHash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Weapon_HidePedWeaponForScriptedCutscene(IntPtr plugin, int ped, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Weapon_IsPedArmed(IntPtr plugin, int ped, int p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Weapon_IsPedCurrentWeaponSilenced(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Weapon_IsPedWeaponComponentActive(IntPtr plugin, int ped, ulong weaponHash, ulong componentHash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Weapon_IsPedWeaponReadyToShoot(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Weapon_IsWeaponValid(IntPtr plugin, ulong weaponHash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Weapon_MakePedReload(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Weapon__0x0ABF535877897560(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Weapon__0x1E45B34ADEBEE48E(IntPtr plugin);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Weapon__0x2472622CE1F2D45F(IntPtr plugin, ulong p0, ulong p1, ulong p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Weapon__0x44F1012B69313374(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Weapon__0x4757F00BC6323CFE(IntPtr plugin, ulong p0, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Weapon__0x4D1CB8DC40208A17(IntPtr plugin, ulong p0, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Weapon__0x585847C5E4E11709(IntPtr plugin, ulong p0, ulong p1, ulong p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Weapon__0x5DA825A85D0EA6E6(IntPtr plugin, ulong p0, ulong p1, ulong p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Weapon__0x6558AC7C17BFEF58(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Weapon__0x68F8BE6AF5CDF8A6(IntPtr plugin, ulong p0, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Weapon__0x91EF34584710BE99(IntPtr plugin, float p0, float p1, float p2, int p3, float p4, float p5, float p6, ulong weaponHash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Weapon__0x977CA98939E82E4B(IntPtr plugin, ulong p0, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Weapon__0x9DA58CDBF6BDBC08(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4, ulong p5, ulong p6, ulong p7, ulong p8, ulong p9, ulong p10);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Weapon__0x9FE5633880ECD8ED(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Weapon__0xA2C9AC24B4061285(IntPtr plugin, ulong p0, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Weapon__0xB3EA4FEABF41464B(IntPtr plugin, ulong p0, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Weapon__0xB4771B9AAF4E68E4(IntPtr plugin, int ped, ulong weaponHash, bool p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern int Native_Weapon__0xB4C8D77C80C0421E(IntPtr plugin, int ped, float p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Weapon__0xCD79A550999D7D4F(IntPtr plugin, ulong p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Weapon__0xDAB963831DBFD3F4(IntPtr plugin, ulong p0, ulong p1, ulong p2, ulong p3, ulong p4);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Weapon__0xE4DCEC7FD5B739A5(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Weapon__0xE620FD3512A04F18(IntPtr plugin, float p0);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Weapon__0xECDC202B25E5CF48(IntPtr plugin, int player, ulong p1, bool p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Weapon__0xEFF296097FF1E509(IntPtr plugin, ulong p0, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Weapon__0xF0A60040BE558F2D(IntPtr plugin, ulong p0, ulong p1, ulong p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Weapon_PedSkipNextReloading(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Weapon_RemoveAllPedWeapons(IntPtr plugin, int ped, bool p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Weapon_RemoveAllProjectilesOfType(IntPtr plugin, ulong weaponHash, bool p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Weapon_RemoveWeaponAsset(IntPtr plugin, ulong weaponHash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Weapon_RemoveWeaponComponentFromPed(IntPtr plugin, int ped, ulong weaponHash, ulong componentHash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Weapon_RemoveWeaponComponentFromWeaponObject(IntPtr plugin, ulong p0, ulong p1);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Weapon_RemoveWeaponFromPed(IntPtr plugin, int ped, ulong weaponHash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Weapon_RequestWeaponAsset(IntPtr plugin, ulong weaponHash, int p1, int p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Weapon_RequestWeaponHighDetailModel(IntPtr plugin, int weaponObject);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Weapon_SetAmmoInClip(IntPtr plugin, int ped, ulong weaponHash, int ammo);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Weapon_SetCurrentPedVehicleWeapon(IntPtr plugin, int ped, ulong weaponHash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Weapon_SetCurrentPedWeapon(IntPtr plugin, int ped, ulong weaponHash, bool equipNow);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern ulong Native_Weapon_SetFlashLightFadeDistance(IntPtr plugin, float distance);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Weapon_SetPedAmmo(IntPtr plugin, int ped, ulong weaponHash, int ammo);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Weapon_SetPedAmmoByType(IntPtr plugin, int ped, ulong ammoType, int ammo);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Weapon_SetPedAmmoToDrop(IntPtr plugin, ulong ammoType, int ammo);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Weapon_SetPedChanceOfFiringBlanks(IntPtr plugin, int ped, float xBias, float yBias);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Weapon_SetPedCurrentWeaponVisible(IntPtr plugin, int ped, bool visible, bool deselectWeapon, bool p3, bool p4);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Weapon_SetPedDropsInventoryWeapon(IntPtr plugin, int ped, ulong weaponHash, float xOffset, float yOffset, float zOffset, int ammoCount);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Weapon_SetPedDropsWeapon(IntPtr plugin, int ped);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Weapon_SetPedDropsWeaponsWhenDead(IntPtr plugin, int ped, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Weapon_SetPedGadget(IntPtr plugin, int ped, ulong gadgetHash, bool p2);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Weapon_SetPedInfiniteAmmo(IntPtr plugin, int ped, bool toggle, ulong weaponHash);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Weapon_SetPedInfiniteAmmoClip(IntPtr plugin, int ped, bool toggle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Weapon_SetPedWeaponTintIndex(IntPtr plugin, int ped, ulong weaponHash, int tintIndex);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Weapon_SetWeaponAnimationOverride(IntPtr plugin, int ped, ulong animStyle);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern void Native_Weapon_SetWeaponObjectTintIndex(IntPtr plugin, int weapon, int tintIndex);
    [DllImport(_dllLocation, CallingConvention = CallingConvention.StdCall)]
    public static extern bool Native_Weapon_SetWeaponSmokegrenadeAssigned(IntPtr plugin, int ped);
}
