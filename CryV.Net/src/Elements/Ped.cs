﻿using System;
using System.Numerics;
using CryV.Net.Client.Helpers;
using CryV.Net.Native;

namespace CryV.Net.Elements
{
    public class Ped : Entity
    {

        public ulong Model
        {
            get => _model;
            set
            {
                SetSkin(value);
                _model = value;
            }
        }

        private ulong _model;

        public Ped(int handle) : base(handle)
        {
        }

        public Ped(ulong model, Vector3 position, float heading) : base(0)
        {
            _model = model;
            Streaming.LoadModel(model);

            Handle = CryVNative.Native_Ped_CreatePed(CryVNative.Plugin, 26, model, position.X, position.Y, position.Z, heading, false, false);
            EntityPool.AddEntity(this);

            Utility.Wait(0);

            SetPedDefaultComponentVariation();

            Streaming.UnloadModel(model);

            SetPedFleeAttributes(0, false);
            SetBlockingOfNonTemporaryEvents(true);
            SetPedCombatAttributes(17, true);
            SetPedCombatAttributes(46, true);
            SetPedSeeingRange(0.0f);
            SetPedHearingRange(0.0f);
            SetPedAlertness(0);
            SetPedCanRagdoll(false);
            SetPedCanBeTargetted(true);
            SetPedCanEvasiveDive(false);
            SetPedCanBeTargettedByPlayer(true);
            SetPedGetOutUpsideDownVehicle(false);
            SetPedAsEnemy(false);
            SetCanAttackFriendly(true, true);

            TaskSetBlockingOfNonTemporaryEvents(true);
        }

        public int Speed()
        {
            if (IsPedWalking())
            {
                return 1;
            }

            if (IsPedRunning())
            {
                return 2;
            }

            if (IsPedSprinting())
            {
                return 3;
            }

            return 0;
        }

        public void SetPedDefaultComponentVariation()
        {
            if (DoesExist() == false)
            {
                Utility.Log("SetPedDefaultComponentVariation - Ped does not exist?");

                return;
            }

            CryVNative.Native_Ped_SetPedDefaultComponentVariation(CryVNative.Plugin, Handle);
        }

        public void SetPedFleeAttributes(int attribute, bool p2)
        {
            CryVNative.Native_Ped_SetPedFleeAttribute(CryVNative.Plugin, Handle, attribute, p2);
        }

        public void SetBlockingOfNonTemporaryEvents(bool toggle)
        {
            CryVNative.Native_Ped_SetBlockingOfNonTemporaryEvents(CryVNative.Plugin, Handle, toggle);
        }

        public void SetPedCombatAttributes(int attributesIndex, bool enabled)
        {
            CryVNative.Native_Ped_SetPedCombatAttributes(CryVNative.Plugin, Handle, attributesIndex, enabled);
        }

        public void SetPedSeeingRange(float range)
        {
            CryVNative.Native_Ped_SetPedSeeingRange(CryVNative.Plugin, Handle, range);
        }

        public void SetPedHearingRange(float range)
        {
            CryVNative.Native_Ped_SetPedHearingRange(CryVNative.Plugin, Handle, range);
        }

        public void SetPedAlertness(int value)
        {
            CryVNative.Native_Ped_SetPedAlertness(CryVNative.Plugin, Handle, value);
        }

        public void SetPedCanRagdoll(bool toggle)
        {
            CryVNative.Native_Ped_SetPedCanRagdoll(CryVNative.Plugin, Handle, toggle);
        }

        public void SetPedCanBeTargetted(bool toggle)
        {
            CryVNative.Native_Ped_SetPedCanBeTargetted(CryVNative.Plugin, Handle, toggle);
        }

        public void SetPedCanEvasiveDive(bool enable)
        {
            CryVNative.Native_Ped_SetPedCanEvasiveDive(CryVNative.Plugin, Handle, enable);
        }

        public void SetPedCanBeTargettedByPlayer(bool toggle)
        {
            CryVNative.Native_Ped_SetPedCanBeTargettedByPlayer(CryVNative.Plugin, Handle, LocalPlayer.PlayerId(), toggle);
        }

        public void SetPedGetOutUpsideDownVehicle(bool toggle)
        {
            CryVNative.Native_Ped_SetPedGetOutUpsideDownVehicle(CryVNative.Plugin, Handle, toggle);
        }

        public void SetPedAsEnemy(bool toggle)
        {
            CryVNative.Native_Ped_SetPedAsEnemy(CryVNative.Plugin, Handle, toggle);
        }

        public void SetCanAttackFriendly(bool toggle, bool p2)
        {
            CryVNative.Native_Ped_SetCanAttackFriendly(CryVNative.Plugin, Handle, toggle, p2);
        }

        public void TaskSetBlockingOfNonTemporaryEvents(bool toggle)
        {
            CryVNative.Native_Ped_TaskSetBlockingOfNonTemporaryEvents(CryVNative.Plugin, Handle, toggle);
        }

        public bool IsPedWalking()
        {
            return CryVNative.Native_Ped_IsPedWalking(CryVNative.Plugin, Handle);
        }

        public bool IsPedRunning()
        {
            return CryVNative.Native_Ped_IsPedRunning(CryVNative.Plugin, Handle);
        }

        public bool IsPedSprinting()
        {
            return CryVNative.Native_Ped_IsPedSprinting(CryVNative.Plugin, Handle);
        }

        public void TaskGoStraightToCoord(float x, float y, float z, float speed, int timeout, float targetHeading, float distanceToSlide)
        {
            CryVNative.Native_Ped_TaskGoStraightToCoord(CryVNative.Plugin, Handle, x, y, z, speed, timeout, targetHeading, distanceToSlide);
        }

        public void SetPedDesiredMoveBlendRatio(float p1)
        {
            CryVNative.Native_Ped_SetPedDesiredMoveBlendRatio(CryVNative.Plugin, Handle, p1);
        }

        public void TaskStandStill(int time)
        {
            CryVNative.Native_Ped_TaskStandStill(CryVNative.Plugin, Handle, time);
        }

        private void SetSkin(ulong model)
        {
            Streaming.LoadModel(model);

            CryVNative.Native_LocalPlayer_SetPlayerModel(CryVNative.Plugin, Handle, model);

            Utility.Wait(0);

            SetPedDefaultComponentVariation();

            Streaming.UnloadModel(model);
        }

    }
}