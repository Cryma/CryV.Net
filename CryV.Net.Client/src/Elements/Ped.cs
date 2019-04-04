using System.Numerics;
using CryV.Net.Client.Helpers;
using CryV.Net.Client.Native;

namespace CryV.Net.Client.Elements
{
    public class Ped : Entity
    {

        public Ped(int handle) : base(handle)
        {
        }

        public Ped(string skin, Vector3 position, float heading) : base(0)
        {
            var model = Utility.GetHashKey(skin);
            Streaming.RequestModel(model);
            while (Streaming.HasModelLoaded(model) == false)
            {
                Utility.Wait(0);
            }

            Handle = CryVNative.Native_Ped_CreatePed(CryVNative.Plugin, 26, model, position.X, position.Y, position.Z, heading, false, false);
            EntityPool.AddEntity(this);

            Utility.Wait(0);

            SetPedDefaultComponentVariation();

            Streaming.SetModelAsNoLongerNeeded(model);

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

        public void SetPedDefaultComponentVariation()
        {
            if (DoesExist() == false)
            {
                Utility.Log("SetPedDefaultComponentVariation - Ped does not exist?");

                return;
            }

            Utility.Log("Ped id: " + Handle);

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

    }
}
