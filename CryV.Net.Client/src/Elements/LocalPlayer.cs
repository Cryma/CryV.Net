using CryV.Net.Client.Native;
using System;
using System.Collections.Generic;
using System.Text;

namespace CryV.Net.Client.Elements
{
    public static class LocalPlayer
    {

        public static int PlayerId()
        {
            return CryVNative.Native_LocalPlayer_PlayerId(CryVNative.Plugin);
        }

        public static int PedId()
        {
            return CryVNative.Native_LocalPlayer_PedId(CryVNative.Plugin);
        }

        public static void SetPosition(float x, float y, float z)
        {
            CryVNative.Native_Entity_SetEntityPosition(CryVNative.Plugin, PedId(), x, y, z);
        }

        public static void _0xD2B315B6689D537D(bool p1)
        {
            CryVNative.Native_LocalPlayer__0xD2B315B6689D537D(CryVNative.Plugin, PlayerId(), p1);
        }

        public static void SetAutoGiveParachuteWhenEnterPlane(bool enabled)
        {
            CryVNative.Native_LocalPlayer_SetAutoGiveParachuteWhenEnterPlane(CryVNative.Plugin, PlayerId(), enabled);
        }

        public static void SetHealthRechargeMultiplier(float multiplier)
        {
            CryVNative.Native_LocalPlayer_SetPlayerHealthRechargeMultiplier(CryVNative.Plugin, PlayerId(), multiplier);
        }

        public static void SetWantedLevel(int wantedLevel, bool disableNoMission)
        {
            CryVNative.Native_LocalPlayer_SetPlayerWantedLevel(CryVNative.Plugin, PlayerId(), wantedLevel, disableNoMission);
        }

        public static void SetWantedLevelNow(bool p1)
        {
            CryVNative.Native_LocalPlayer_SetPlayerWantedLevelNow(CryVNative.Plugin, PlayerId(), p1);
        }

        public static void SetMaxWantedLevel(int maxWantedLevel)
        {
            CryVNative.Native_LocalPlayer_SetMaxWantedLevel(CryVNative.Plugin, maxWantedLevel);
        }

        public static void SetModel(string model)
        {
            var modelHash = Utility.GetHashKey(model);

            CryVNative.Native_Gameplay_RequestModel(CryVNative.Plugin, modelHash);
            while (CryVNative.Native_Gameplay_HasModelLoaded(CryVNative.Plugin, modelHash) == false)
            {
                Utility.Log("waiting...");
                Utility.Wait(0);
            }

            CryVNative.Native_LocalPLayer_SetPlayerModel(CryVNative.Plugin, PlayerId(), modelHash);

            Utility.Wait(0);

            CryVNative.Native_LocalPLayer_SetPedDefaultComponentVariation(CryVNative.Plugin, PedId());

            Utility.Wait(100);

            CryVNative.Native_Gameplay_SetModelAsNoLongerNeeded(CryVNative.Plugin, modelHash);
        }

    }
}
