using System.Drawing;
using CryV.Net.Elements;

namespace CryV.Net.Client.Players
{
    public partial class Player
    {

        private bool _wasAiming;

        private void UpdateWeaponAnimation()
        {
            // TODO: Interpolate and improve aim prop handling

            if (IsAiming == false)
            {
                if (_wasAiming)
                {
                    _wasAiming = false;

                    NativePed.ClearPedTasks();
                    NativePed.ClearPedSecondaryTask();
                }

                // TODO: Maybe delete props or add them to some pool

                return;
            }

            UpdateAimProp();
            UpdateFollowProp();

            if (NativePed.GetCurrentPedWeapon() != WeaponModel)
            {
                NativePed.RemoveAllPedWeapons();
                NativePed.GiveWeaponToPed(WeaponModel, 999, true, true);
            }

            var isPedAiming = NativePed.GetIsTaskActive(290);

            if (IsInVehicle)
            {
                UpdateWeaponInVehicle(isPedAiming);
            }
            else
            {
                UpdateWeaponOnFoot(isPedAiming);
            }
        }

        private void UpdateWeaponInVehicle(bool isNativePedAiming)
        {
            if (_wasAiming == false || IsAiming && isNativePedAiming == false)
            {
                NativePed.SetPedCurrentWeaponVisible(false, false, false, false);
                NativePed.TaskDriveBy(0, 0, AimTarget.X, AimTarget.Y, AimTarget.Z, 0.0f, 0, false, 1566631136);
            }
            else
            {
                NativePed.SetPedCurrentWeaponVisible(true, false, false, false);
                NativePed.SetDrivebyTaskTarget(0, 0, AimTarget.X, AimTarget.Y, AimTarget.Z);
            }

            _wasAiming = IsAiming;
        }

        private void UpdateWeaponOnFoot(bool isNativePedAiming)
        {
            if (isNativePedAiming == false || _ticks % 100 == 0)
            {
                if (Speed == 0)
                {
                    NativePed.TaskAimGunAtEntity(_aimProp.Handle, -1, false);
                }
                else
                {
                    NativePed.TaskGoToEntityWhileAimingAtEntity(_followProp.Handle, _aimProp.Handle, Speed, false, 3.0f, 1082130432, true, false, 3337513804);
                    NativePed.SetPedDesiredMoveBlendRatio(Speed);
                }
            }
        }

        private void UpdateAimProp()
        {
            if (_aimProp == null)
            {
                _aimProp = new Prop(3120582510, AimTarget);
                _aimProp.SetEntityCollision(false);
                _aimProp.SetEntityAlpha(0);
            }

            if (_aimProp != null && _aimProp.DoesExist())
            {
                _aimProp.Position = AimTarget;
            }
        }

        private void UpdateFollowProp()
        {
            if (_followProp == null)
            {
                _followProp = new Prop(3120582510, Position + Velocity * 3.0f);
                _followProp.SetEntityCollision(false);
                _followProp.SetEntityAlpha(0);
            }

            if (_followProp != null && _followProp.DoesExist())
            {
                _followProp.Position = Position + Velocity * 3.0f;
            }
        }

    }
}
