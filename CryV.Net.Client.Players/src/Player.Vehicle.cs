using System;
using CryV.Net.Enums;
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

            if (IsInVehicle && Ped.IsInAnyVehicle(true) == false && Vehicle.GetVehicle().DoesExist() && (DateTime.UtcNow - _vehicleEnterBegin).TotalSeconds > 2.5f)
            {
                Ped.SetPedIntoVehicle(Vehicle.GetVehicle(), Seat);
            }

            if (_wasEnteringVehicle || IsInVehicle)
            {
                return true;
            }

            if (IsLeavingVehicle && _wasLeavingVehicle == false)
            {
                Ped.ClearPedTasks();
                Ped.ClearPedSecondaryTask();

                Ped.TaskLeaveVehicle(Vehicle.GetVehicle(), 0);

                _wasLeavingVehicle = true;

                return true;
            }

            if (_wasLeavingVehicle)
            {
                return true;
            }

            if (IsEnteringVehicle && _wasEnteringVehicle == false)
            {
                Ped.ClearPedTasks();
                Ped.ClearPedSecondaryTask();
                Ped.ClearPedTasksImmediately();

                Ped.TaskEnterVehicle(Vehicle.GetVehicle(), -1, (VehicleSeat) Seat, Speed, 0);

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
