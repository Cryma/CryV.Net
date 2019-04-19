using CryV.Net.Shared.Common.Flags;
using CryV.Net.Shared.Common.Payloads;

namespace CryV.Net.Client.Players
{
    public partial class Player
    {

        private bool _wasEnteringVehicle;
        private bool _wasLeavingVehicle;

        private bool UpdateVehicleAnimations()
        {
            if (_wasEnteringVehicle || IsInVehicle)
            {
                return true;
            }

            if (IsLeavingVehicle && _wasLeavingVehicle == false)
            {
                _ped.ClearPedTasks();
                _ped.ClearPedSecondaryTask();

                _ped.TaskLeaveVehicle(Vehicle.GetVehicle(), 0);

                _wasLeavingVehicle = true;

                return true;
            }

            if (_wasLeavingVehicle)
            {
                return true;
            }

            if (IsEnteringVehicle && _wasEnteringVehicle == false)
            {
                _ped.ClearPedTasks();
                _ped.ClearPedSecondaryTask();
                _ped.ClearPedTasksImmediately();

                _ped.TaskEnterVehicle(Vehicle.GetVehicle(), -1, Seat, Speed, 0);

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
