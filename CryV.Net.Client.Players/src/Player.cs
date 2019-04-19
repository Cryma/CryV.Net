using System;
using System.Collections.Generic;
using System.Numerics;
using CryV.Net.Client.Common.Helpers;
using CryV.Net.Client.Common.Interfaces;
using CryV.Net.Elements;
using CryV.Net.Helpers;
using CryV.Net.Shared.Common.Flags;
using CryV.Net.Shared.Common.Interfaces;
using CryV.Net.Shared.Common.Payloads;
using CryV.Net.Shared.Events.Types;

namespace CryV.Net.Client.Players
{
    public class Player : IPlayer
    {

        public int Id { get; }

        public Vector3 Position
        {
            get => _ped.Position;
            set => _ped.Position = value;
        }

        public Vector3 TargetPosition { get; set; }

        public Vector3 Velocity { get; set; }

        public Vector3 Rotation
        {
            get => _ped.Rotation;
            set => _ped.Rotation = value;
        }

        public float TargetHeading { get; set; }

        public Vector3 AimTarget { get; set; }

        public int Speed { get; set; }

        public ulong Model
        {
            get => _ped.Model;
            set => _ped.Model = value;
        }

        public ulong WeaponModel
        {
            get => _ped.GetSelectedPedWeapon();
            set => _ped.GiveWeaponToPed(value, 999, true, true);
        }

        public bool IsJumping { get; set; }

        public bool IsClimbing { get; set; }

        public bool IsClimbingLadder { get; set; }

        public bool IsRagdoll { get; set; }

        public bool IsAiming { get; set; }

        public bool IsEnteringVehicle { get; set; }

        public bool IsInVehicle { get; set; }

        private Ped _ped;

        private static float _interpolationFactor = 3.0f;

        private float _lastRange;
        private bool _wasNegative;
        private bool _wasJumping;
        private bool _wasClimbing;
        private bool _wasRagdoll;

        private Prop _aimProp;
        private Prop _followProp;

        private int _ticks;

        private readonly List<ISubscription> _eventSubscriptions = new List<ISubscription>();

        private readonly IEventHandler _eventHandler;
        private readonly IEntityPool _entityPool;

        public Player(IEventHandler eventHandler, IEntityPool entityPool, PlayerUpdatePayload payload)
        {
            _eventHandler = eventHandler;
            _entityPool = entityPool;

            Id = payload.Id;
            TargetPosition = payload.Position;
            TargetHeading = payload.Heading;
            AimTarget = payload.AimTarget;

            _eventSubscriptions.Add(_eventHandler.Subscribe<NetworkEvent<PlayerUpdatePayload>>(update => ReadPayload(update.Payload), x => x.Payload.Id == Id));

            ThreadHelper.Run(() =>
            {
                _ped = new Ped(payload.Model, payload.Position, payload.Heading)
                {
                    Velocity = Velocity
                };

                _entityPool.AddEntity(_ped);
            });

            NativeHelper.OnNativeTick += Tick;
        }

        public Ped GetPed()
        {
            return _ped;
        }

        public void ReadPayload(PlayerUpdatePayload payload)
        {
            TargetPosition = payload.Position;
            TargetHeading = payload.Heading;
            Velocity = payload.Velocity;
            Speed = payload.Speed;
            AimTarget = payload.AimTarget;

            IsJumping = (payload.PedData & (int) PedData.IsJumping) > 0;
            if (IsJumping == false)
            {
                _wasJumping = false;
            }

            IsClimbing = (payload.PedData & (int) PedData.IsClimbing) > 0;
            if (IsClimbing == false)
            {
                _wasClimbing = false;
            }

            IsClimbingLadder = (payload.PedData & (int) PedData.IsClimbingLadder) > 0;

            IsRagdoll = (payload.PedData & (int) PedData.IsRagdoll) > 0;

            IsAiming = (payload.PedData & (int) PedData.IsAiming) > 0;

            IsEnteringVehicle = (payload.PedData & (int) PedData.IsEnteringVehicle) > 0;

            IsInVehicle = (payload.PedData & (int) PedData.IsInVehicle) > 0;

            // TODO: Optimize
            ThreadHelper.Run(() =>
            {
                if (Model != payload.Model)
                {
                    Model = payload.Model;
                }

                if (WeaponModel != payload.WeaponModel)
                {
                    WeaponModel = payload.WeaponModel;
                }
            });
        }

        private void Tick(float deltaTime)
        {
            _ticks++;

            if (IsClimbingLadder)
            {
                var animationName = GetLadderClimbingAnimationName();

                if (_ped.IsEntityPlayingAnim("laddersbase", animationName, 3) == false)
                {
                    _ped.ClearPedTasks();
                    Streaming.LoadAnimationDictionary("laddersbase");
                    _ped.TaskPlayAnim("laddersbase", animationName, 8.0f, 10f, -1, 1 | 2147483648, 1.0f, true, true, true);
                }
            }

            UpdatePosition(deltaTime);
            UpdateHeading(deltaTime);

            if (IsAiming)
            {
                UpdateWeaponAnimation();
            }
            else
            {
                UpdateMovementAnimation();
            }

            UpdateRagdoll();

            if (IsJumping && _wasJumping == false)
            {
                _ped.TaskJump();

                _wasJumping = true;
            }

            if (IsClimbing && _wasClimbing == false)
            {
                _ped.TaskClimb();

                _wasClimbing = true;
            }
        }

        private void UpdatePosition(float deltaTime)
        {
            Position = Vector3.Lerp(Position, TargetPosition, deltaTime * _interpolationFactor);
            _ped.Velocity = Velocity;
        }

        private void UpdateHeading(float deltaTime)
        {
            var interpolatedHeading = Interpolation.LerpDegrees(Rotation.Z, TargetHeading, deltaTime * _interpolationFactor);

            Rotation = new Vector3(Rotation.X, Rotation.Y, interpolatedHeading);
        }

        private void UpdateRagdoll()
        {
            if (IsRagdoll && _wasRagdoll == false)
            {
                _ped.ClearPedTasksImmediately();
                _ped.SetPedCanRagdoll(true);

                _ped.SetPedToRagdoll(-1, -1, 0, false, false, false);

                _wasRagdoll = true;
            }

            if (IsRagdoll == false && (_wasRagdoll || _ped.IsPedRagdoll()))
            {
                _ped.ClearPedTasks();

                _wasRagdoll = false;
            }
        }

        private void UpdateMovementAnimation()
        {
            if (IsJumping || IsClimbing || IsClimbingLadder || IsRagdoll)
            {
                return;
            }

            var end = TargetPosition + Velocity;
            var range = Vector3.Distance(TargetPosition, end);
            var deltaRange = range - _lastRange;

            _lastRange = range;

            if (deltaRange < 0)
            {
                _wasNegative = true;

                if (_ped.IsPedSprinting())
                {
                    _ped.TaskStandStill(2000);

                    return;
                }
            }
            else if (deltaRange > 0)
            {
                _wasNegative = false;
            }

            switch (Speed)
            {
                case 1:
                    {
                        if (_ped.IsPedWalking() && range < 0.1f || _wasNegative)
                        {
                            break;
                        }

                        _ped.TaskGoStraightToCoord(end.X, end.Y, end.Z, 1.0f, -1, 0.0f, 0.0f);
                        _ped.SetPedDesiredMoveBlendRatio(1.0f);

                        break;
                    }

                case 2:
                    {
                        if (_ped.IsPedRunning() && range < 0.2f || _wasNegative)
                        {
                            break;
                        }

                        _ped.TaskGoStraightToCoord(end.X, end.Y, end.Z, 2.0f, -1, 0.0f, 0.0f);
                        _ped.SetPedDesiredMoveBlendRatio(1.0f);

                        break;
                    }

                case 3:
                    {
                        if (_ped.IsPedSprinting() && range < 0.3f || _wasNegative)
                        {
                            break;
                        }

                        _ped.TaskGoStraightToCoord(end.X, end.Y, end.Z, 3.0f, -1, 0.0f, 0.0f);
                        _ped.SetPedDesiredMoveBlendRatio(1.0f);

                        break;
                    }

                default:
                    _ped.TaskStandStill(2000);

                    break;
            }
        }

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
                _followProp = new Prop(3120582510, TargetPosition + Velocity * 3.0f);
                _followProp.SetEntityCollision(false);
                _followProp.SetEntityAlpha(0);
            }

            if (_followProp != null && _followProp.DoesExist())
            {
                _followProp.Position = TargetPosition + Velocity * 3.0f;
            }

            var isPedAiming = _ped.GetIsTaskActive(290);

            if (isPedAiming == false || _ticks % 100 == 0)
            {
                if (Speed == 0)
                {
                    _ped.TaskAimGunAtEntity(_aimProp.Handle, -1, false);
                }
                else
                {
                    _ped.TaskGoToEntityWhileAimingAtEntity(_followProp.Handle, _aimProp.Handle, Speed, false, 3.0f, 1082130432, true, false, 3337513804);
                    _ped.SetPedDesiredMoveBlendRatio(Speed);
                }
            }
        }

        private string GetLadderClimbingAnimationName()
        {
            if (Math.Abs(Velocity.Z) < 0.5)
            {
                return "base_left_hand_up";
            }

            if (Velocity.Z > 0)
            {
                return "climb_up";
            }

            if (Velocity.Z < -2)
            {
                return "slide_climb_down";
            }

            if (Velocity.Z < 0)
            {
                return "climb_down";
            }

            return null;
        }

        public void Dispose()
        {
            foreach (var subscription in _eventSubscriptions)
            {
                _eventHandler.Unsubscribe(subscription);
            }

            NativeHelper.OnNativeTick -= Tick;

            _entityPool.RemoveEntity(_ped);

            ThreadHelper.Run(() =>
            {
                _aimProp?.Delete();
                _followProp?.Delete();

                _ped.Delete();
            });
        }

    }
}
