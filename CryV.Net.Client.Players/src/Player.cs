using System;
using System.Collections.Generic;
using System.Numerics;
using CryV.Net.Client.Common.Helpers;
using CryV.Net.Client.Common.Interfaces;
using CryV.Net.Client.Helpers;
using CryV.Net.Elements;
using CryV.Net.Helpers;
using CryV.Net.Shared.Common.Flags;
using CryV.Net.Shared.Common.Interfaces;
using CryV.Net.Shared.Common.Payloads;
using CryV.Net.Shared.Events.Types;

namespace CryV.Net.Client.Players
{
    public partial class Player : IPlayer
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

        public bool IsLeavingVehicle { get; set; }

        public IVehicle Vehicle { get; set; }

        public int Seat { get; set; }

        private Ped _ped;

        private static float _interpolationFactor = 3.0f;

        private float _lastRange;
        private bool _wasNegative;

        private Prop _aimProp;
        private Prop _followProp;

        private int _ticks;

        private readonly List<ISubscription> _eventSubscriptions = new List<ISubscription>();

        private readonly IEventHandler _eventHandler;
        private readonly IVehicleManager _vehicleManager;

        public Player(IEventHandler eventHandler, IVehicleManager vehicleManager, PlayerUpdatePayload payload)
        {
            _eventHandler = eventHandler;
            _vehicleManager = vehicleManager;

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

                EntityPool.AddEntity(_ped);
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
            Seat = payload.Seat;

            IsJumping = (payload.PedData & (int) PedData.IsJumping) > 0;

            IsClimbing = (payload.PedData & (int) PedData.IsClimbing) > 0;

            IsClimbingLadder = (payload.PedData & (int) PedData.IsClimbingLadder) > 0;

            IsRagdoll = (payload.PedData & (int) PedData.IsRagdoll) > 0;

            IsAiming = (payload.PedData & (int) PedData.IsAiming) > 0;

            ReadPayloadVehicleRelated(payload);

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

            if (UpdateVehicleAnimations())
            {
                return;
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

            ExecutionHelper.ExecuteOnce($"PLAYER_{Id}_JUMPING", IsJumping, () =>
            {
                _ped.TaskJump();
            });

            ExecutionHelper.ExecuteOnce($"PLAYER_{Id}_CLIMBING", IsClimbing, () =>
            {
                _ped.TaskClimb();
            });
        }

        private void UpdatePosition(float deltaTime)
        {
            var positionDifference = TargetPosition - Position;
            _ped.Velocity = Velocity + positionDifference;
        }

        private void UpdateHeading(float deltaTime)
        {
            var interpolatedHeading = Interpolation.LerpDegrees(Rotation.Z, TargetHeading, deltaTime * _interpolationFactor);

            Rotation = new Vector3(Rotation.X, Rotation.Y, interpolatedHeading);
        }

        private void UpdateRagdoll()
        {
            ExecutionHelper.ExecuteOnce($"PLAYER_{Id}_RAGDOLL", IsRagdoll, () =>
            {
                _ped.ClearPedTasksImmediately();
                _ped.SetPedCanRagdoll(true);

                _ped.SetPedToRagdoll(-1, -1, 0, false, false, false);
            }, () =>
            {
                _ped.ClearPedTasks();
            });
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

            ThreadHelper.Run(() =>
            {
                EntityPool.RemoveEntity(_ped);

                _aimProp?.Delete();
                _followProp?.Delete();

                _ped.Delete();
            });
        }

    }
}
