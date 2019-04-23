using CryV.Net.Elements;

namespace CryV.Net.Client.Players
{
    public partial class Player
    {

        private void UpdateWeaponAnimation()
        {
            // TODO: Interpolate and improve aim prop handling

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

            var isPedAiming = NativePed.GetIsTaskActive(290);

            if (isPedAiming == false || _ticks % 100 == 0)
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

    }
}
