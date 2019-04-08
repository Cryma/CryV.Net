using CryV.Net.Native;
using System;
using System.Collections.Generic;
using System.Text;

namespace CryV.Net.Elements
{
    public static class LocalPlayer
    {

        // TODO: Cache ped or pedId
        public static Ped Character => new Ped(PedId());

        public static ulong Model
        {
            get => _model;
            set
            {
                SetModel(value);
                _model = value;
            }
        }

        private static ulong _model;

        public static int PlayerId()
        {
            return CryVNative.Native_LocalPlayer_PlayerId(CryVNative.Plugin);
        }

        private static int PedId()
        {
            return CryVNative.Native_LocalPlayer_PedId(CryVNative.Plugin);
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

        private static void SetModel(ulong modelHash)
        {
            Streaming.LoadModel(modelHash);

            CryVNative.Native_LocalPlayer_SetPlayerModel(CryVNative.Plugin, PlayerId(), modelHash);

            Utility.Wait(0);

            Character.SetPedDefaultComponentVariation();

            Streaming.UnloadModel(modelHash);
        }

    }
}
