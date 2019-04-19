using CryV.Net.Client.Helpers;
using CryV.Net.Helpers;
using CryV.Net.Native;
using System.Numerics;

namespace CryV.Net.Elements
{
    public class Ped : Entity
    {

        public ulong Model
        {
            get => _model;
            set => SetSkin(value);
        }

        private ulong _model;

        public Ped(int handle) : base(handle)
        {
        }

        public Ped(ulong model, Vector3 position, float heading) : base(0)
        {
            CreatePed(model, position, heading);
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
            CryVNative.Native_Ped_SetPedFleeAttributes(CryVNative.Plugin, Handle, attribute, p2);
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

        public void SetPedToRagdoll(int time1, int time2, int ragdollType, bool p4, bool p5, bool p6)
        {
            CryVNative.Native_Ped_SetPedToRagdoll(CryVNative.Plugin, Handle, time1, time2, ragdollType, p4, p5, p6);
        }

        public void SetPedToRagdollWithFall(int time, int p2, int ragdollType, float x, float y, float z, float p7)
        {
            CryVNative.Native_Ped_SetPedToRagdollWithFall(CryVNative.Plugin, Handle, time, p2, ragdollType, x, y, z, p7, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f);
        }

        public void SetPedDiesWhenInjured(bool toggle)
        {
            CryVNative.Native_Ped_SetPedDiesWhenInjured(CryVNative.Plugin, Handle, toggle);
        }

        public void SetPedConfigFlag(int flagId, bool value)
        {
            CryVNative.Native_Ped_SetPedConfigFlag(CryVNative.Plugin, Handle, flagId, value);
        }

        public void SetPedCanHeadIK(bool toggle)
        {
            CryVNative.Native_Ped_SetPedCanHeadIk(CryVNative.Plugin, Handle, toggle);
        }

        public void SetPedIntoVehicle(Vehicle vehicle, int seatIndex)
        {
            CryVNative.Native_Ped_SetPedIntoVehicle(CryVNative.Plugin, Handle, vehicle.Handle, seatIndex);
        }

        public void TaskSetBlockingOfNonTemporaryEvents(bool toggle)
        {
            CryVNative.Native_Brain_TaskSetBlockingOfNonTemporaryEvents(CryVNative.Plugin, Handle, toggle);
        }

        public void TaskJump(bool unused = true)
        {
            CryVNative.Native_Brain_TaskJump(CryVNative.Plugin, Handle, unused);
        }

        public void TaskClimb(bool unused = true)
        {
            CryVNative.Native_Brain_TaskClimb(CryVNative.Plugin, Handle, unused);
        }

        public void TaskClimbLadder(int p1 = 1)
        {
            CryVNative.Native_Brain_TaskClimbLadder(CryVNative.Plugin, Handle, p1);
        }

        public void TaskMoveNetwork(string task, float multiplier, bool p3, string animDict, int flags)
        {
            using (var converter = new StringConverter())
            {
                var taskPointer = converter.StringToPointer(task);
                var animDictPointer = converter.StringToPointer(animDict);

                CryVNative.Native_Brain_TaskMoveNetwork(CryVNative.Plugin, Handle, taskPointer, multiplier, p3, animDictPointer, flags);
            }
        }

        public void TaskAimGunAtCoord(Vector3 coordinates, int time, bool p5, bool p6)
        {
            CryVNative.Native_Brain_TaskAimGunAtCoord(CryVNative.Plugin, Handle, coordinates.X, coordinates.Y, coordinates.Z, time, p5, p6);
        }

        public void TaskLookAtCoord(Vector3 coordinates, float duration, ulong p5, ulong p6)
        {
            CryVNative.Native_Brain_TaskLookAtCoord(CryVNative.Plugin, Handle, coordinates.X, coordinates.Y, coordinates.Z, duration, p5, p6);
        }

        public void TaskAimGunAtEntity(int entityHandle, int duration, bool p3)
        {
            CryVNative.Native_Brain_TaskAimGunAtEntity(CryVNative.Plugin, Handle, entityHandle, duration, p3);
        }

        public void TaskGoToEntityWhileAimingAtEntity(int entityToWalkTo, int entityToAimAt, float speed, bool shootAtEntity, float p5, float p6, bool p7, bool p8,
            ulong firingPattern)
        {
            CryVNative.Native_Brain_TaskGoToEntityWhileAimingAtEntity(CryVNative.Plugin, Handle, entityToWalkTo, entityToAimAt, speed, shootAtEntity, p5, p6, p7, p8, firingPattern);
        }

        public void TaskEnterVehicle(Vehicle vehicle, int timeout, int seat, float speed, int flag, ulong p6 = 0)
        {
            CryVNative.Native_Brain_TaskEnterVehicle(CryVNative.Plugin, Handle, vehicle.Handle, timeout, seat, speed, flag, p6);
        }

        public void TaskLeaveVehicle(Vehicle vehicle, int flags)
        {
            CryVNative.Native_Brain_TaskLeaveVehicle(CryVNative.Plugin, Handle, vehicle.Handle, flags);
        }

        public void TaskVehicleTempAction(Vehicle vehicle, int action, int time)
        {
            CryVNative.Native_Brain_TaskVehicleTempAction(CryVNative.Plugin, Handle, vehicle.Handle, action, time);
        }

        public bool IsPedWalking()
        {
            return CryVNative.Native_Brain_IsPedWalking(CryVNative.Plugin, Handle);
        }

        public bool IsPedRunning()
        {
            return CryVNative.Native_Brain_IsPedRunning(CryVNative.Plugin, Handle);
        }

        public bool IsPedSprinting()
        {
            return CryVNative.Native_Brain_IsPedSprinting(CryVNative.Plugin, Handle);
        }

        public bool IsPedJumping()
        {
            return CryVNative.Native_Ped_IsPedJumping(CryVNative.Plugin, Handle);
        }

        public bool IsPedClimbing()
        {
            return CryVNative.Native_Ped_IsPedClimbing(CryVNative.Plugin, Handle);
        }

        public bool IsPedRagdoll()
        {
            return CryVNative.Native_Ped_IsPedRagdoll(CryVNative.Plugin, Handle);
        }

        public bool IsInAnyVehicle(bool atGetIn = false)
        {
            return CryVNative.Native_Ped_IsPedInAnyVehicle(CryVNative.Plugin, Handle, atGetIn);
        }

        public Vehicle GetVehiclePedIsIn()
        {
            if (IsInAnyVehicle() == false)
            {
                return new Vehicle(0);
            }

            return new Vehicle(CryVNative.Native_Ped_GetVehiclePedIsIn(CryVNative.Plugin, Handle, false));
        }

        public Vehicle GetLastVehiclePedIsIn()
        {
            return new Vehicle(CryVNative.Native_Ped_GetVehiclePedIsIn(CryVNative.Plugin, Handle, true));
        }

        public bool GetIsTaskActive(int taskNumber)
        {
            return CryVNative.Native_Brain_GetIsTaskActive(CryVNative.Plugin, Handle, taskNumber);
        }

        public void TaskGoStraightToCoord(float x, float y, float z, float speed, int timeout, float targetHeading, float distanceToSlide)
        {
            CryVNative.Native_Brain_TaskGoStraightToCoord(CryVNative.Plugin, Handle, x, y, z, speed, timeout, targetHeading, distanceToSlide);
        }

        public void SetPedDesiredMoveBlendRatio(float p1)
        {
            CryVNative.Native_Brain_SetPedDesiredMoveBlendRatio(CryVNative.Plugin, Handle, p1);
        }

        public void TaskStandStill(int time)
        {
            CryVNative.Native_Brain_TaskStandStill(CryVNative.Plugin, Handle, time);
        }

        public void TaskPlayAnim(string animDictionary, string animationName, float speed, float speedMultiplier, int duration, uint flag, float playbackRate,
            bool lockX, bool lockY, bool lockZ)
        {
            using (var converter = new StringConverter())
            {
                CryVNative.Native_Brain_TaskPlayAnim(CryVNative.Plugin, Handle, converter.StringToPointer(animDictionary), converter.StringToPointer(animationName),
                    speed, speedMultiplier, duration, (int) flag, playbackRate, lockX, lockY, lockZ);
            }
        }

        public void ClearPedTasksImmediately()
        {
            CryVNative.Native_Brain_ClearPedTasksImmediately(CryVNative.Plugin, Handle);
        }

        public void ClearPedTasks()
        {
            CryVNative.Native_Brain_ClearPedTasks(CryVNative.Plugin, Handle);
        }

        public void ClearPedSecondaryTask()
        {
            CryVNative.Native_Brain_ClearPedSecondaryTask(CryVNative.Plugin, Handle);
        }

        public ulong GetCurrentPedWeapon()
        {
            ulong hash = 0;

            CryVNative.Native_Weapon_GetCurrentPedWeapon(CryVNative.Plugin, Handle, ref hash, false);

            return hash;
        }

        public ulong GetSelectedPedWeapon()
        {
            return CryVNative.Native_Weapon_GetSelectedPedWeapon(CryVNative.Plugin, Handle);
        }

        public void RemoveAllPedWeapons()
        {
            CryVNative.Native_Weapon_RemoveAllPedWeapons(CryVNative.Plugin, Handle, true);
        }

        public void GiveWeaponToPed(ulong weaponHash, int ammoCount, bool isHidden, bool equipNow)
        {
            CryVNative.Native_Weapon_GiveWeaponToPed(CryVNative.Plugin, Handle, weaponHash, ammoCount, isHidden, equipNow);
        }

        public Vehicle GetVehiclePedIsTryingToEnter()
        {
            return new Vehicle(CryVNative.Native_Ped_GetVehiclePedIsTryingToEnter(CryVNative.Plugin, Handle));
        }

        public int GetSeatPedIsTryingToEnter()
        {
            return CryVNative.Native_Ped_GetSeatPedIsTryingToEnter(CryVNative.Plugin, Handle);
        }

        public void _0xD5BB4025AE449A4E(string p1, float p2)
        {
            using (var converter = new StringConverter())
            {
                var p1Pointer = converter.StringToPointer(p1);

                CryVNative.Native_Brain_SetTaskPropertyFloat(CryVNative.Plugin, Handle, p1Pointer, p2);
            }
        }

        public void _0xB0A6CFD2C69C1088(string p1, bool p2)
        {
            using (var converter = new StringConverter())
            {
                var p1Pointer = converter.StringToPointer(p1);

                CryVNative.Native_Brain_SetTaskPropertyBool(CryVNative.Plugin, Handle, p1Pointer, p2);
            }
        }

        public void _0xD01015C7316AE176(string p1)
        {
            using (var converter = new StringConverter())
            {
                var p1Pointer = converter.StringToPointer(p1);

                CryVNative.Native_Brain__0xD01015C7316AE176(CryVNative.Plugin, Handle, p1Pointer);
            }
        }

        public bool MemoryIsPedInVehicle()
        {
            return CryVNative.Native_Memory_IsPedInVehicle(CryVNative.Plugin, Handle);
        }

        public Vehicle MemoryGetVehiclePedIsIn()
        {
            if (MemoryIsPedInVehicle() == false)
            {
                return new Vehicle(0);
            }

            return new Vehicle(CryVNative.Native_Memory_GetVehiclePedIsIn(CryVNative.Plugin, Handle));
        }

        public bool IsEnteringVehicle()
        {
            return GetIsTaskActive(160) || GetIsTaskActive(161) || GetIsTaskActive(162) || GetIsTaskActive(163) || GetIsTaskActive(164);
        }

        public bool IsLeavingVehicle()
        {
            return GetIsTaskActive(167) || GetIsTaskActive(168);
        }

        public bool IsClimbingLadder()
        {
            return GetIsTaskActive(47);
        }

        private void SetSkin(ulong model)
        {
            CreatePed(model, Position, Rotation.Z);
        }

        private void CreatePed(ulong model, Vector3 position, float heading)
        {
            if (IsValid() || _model != model)
            {
                Delete();
            }

            _model = model;

            Streaming.LoadModel(model);

            Handle = CryVNative.Native_Ped_CreatePed(CryVNative.Plugin, 26, model, position.X, position.Y, position.Z, heading, false, false);
            EntityPool.AddEntity(this);

            Utility.Wait(0);

            SetPedDefaultComponentVariation();

            Streaming.UnloadModel(model);

            SetPedDefaultBehaviour();
        }

        private void SetPedDefaultBehaviour()
        {
            SetPedDiesWhenInjured(false);
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

            SetEntityInvincible(true);

            TaskSetBlockingOfNonTemporaryEvents(true);
        }

    }
}
