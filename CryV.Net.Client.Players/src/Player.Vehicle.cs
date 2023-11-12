using System;
using CryV.Net.Shared.Common.Enums;
using CryV.Net.Shared.Common.Flags;
using CryV.Net.Shared.Common.Payloads;

namespace CryV.Net.Client.Players
{
    public partial class Player
    {

        private bool _wasEnteringVehicle;
        private bool _wasLeavingVehicle;

        private DateTime _vehicleEnterBegin;

        private bool UpdateVehicleAnimations()
        {
            if (Vehicle == null)
            {
                return false;
            }

            if (IsInVehicle && NativePed.IsInAnyVehicle(true) == false && Vehicle.NativeVehicle.DoesExist() && (DateTime.UtcNow - _vehicleEnterBegin).TotalSeconds > 2.5f)
            {
                NativePed.SetPedIntoVehicle(Vehicle.NativeVehicle, Seat);
            }

            if (_wasEnteringVehicle || IsInVehicle)
            {
                return true;
            }

            if (IsLeavingVehicle && _wasLeavingVehicle == false)
            {
                NativePed.ClearPedTasks();
                NativePed.ClearPedSecondaryTask();

                NativePed.TaskLeaveVehicle(Vehicle.NativeVehicle, 0);

                _wasLeavingVehicle = true;

                return true;
            }

            if (_wasLeavingVehicle)
            {
                return true;
            }

            if (IsEnteringVehicle && _wasEnteringVehicle == false)
            {
                NativePed.ClearPedTasks();
                NativePed.ClearPedSecondaryTask();
                NativePed.ClearPedTasksImmediately();

                NativePed.TaskEnterVehicle(Vehicle.NativeVehicle, -1, (VehicleSeat) Seat, Speed, 0);

                _vehicleEnterBegin = DateTime.UtcNow;

                _wasEnteringVehicle = true;

                return true;
            }

            return false;
        }

        private void ReadPayloadVehicleRelated(PlayerUpdatePayload payload)
        {
            IsEnteringVehicle = (payload.PedData & (int) PedData.IsEnteringVehicle) > 0;
            if (IsEnteringVehicle == false)
            {
                _wasEnteringVehicle = false;
            }

            IsInVehicle = (payload.PedData & (int) PedData.IsInVehicle) > 0;

            if (payload.VehicleId != -1)
            {
                Vehicle = _vehicleManager.GetVehicle(payload.VehicleId);
            }

            IsLeavingVehicle = (payload.PedData & (int) PedData.IsLeavingVehicle) > 0;
            if (IsLeavingVehicle == false)
            {
                _wasLeavingVehicle = false;
            }
        }

    }
}
