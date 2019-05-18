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

        public Vector3 Position { get; set; }

        public Vector3 Velocity { get; set; }

        public float Heading { get; set; }

        public Vector3 AimTarget { get; set; }

        public int Speed { get; set; }

        public ulong Model { get; set; }

        public ulong WeaponModel { get; set; }

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

        public Ped NativePed { get; private set; }

        private static float _interpolationFactor = 3.0f;

        private Prop _aimProp;
        private Prop _followProp;

        private int _ticks;

        private PlayerUpdatePayload _lastPayload;

        private readonly List<ISubscription> _eventSubscriptions = new List<ISubscription>();

        private readonly IEventHandler _eventHandler;
        private readonly IVehicleManager _vehicleManager;

        public Player(IEventHandler eventHandler, IVehicleManager vehicleManager, PlayerUpdatePayload payload)
        {
            _eventHandler = eventHandler;
            _vehicleManager = vehicleManager;

            _lastPayload = payload;

            Id = payload.Id;
            Model = payload.Model;

            ReadPayload(payload);

            _eventSubscriptions.Add(_eventHandler.Subscribe<NetworkEvent<PlayerUpdatePayload>>(update =>
            {
                ReadPayload(update.Payload);
            }, x => x.Payload.Id == Id));

            ThreadHelper.Run(() =>
            {
                NativePed = new Ped(Model, Position, Heading)
                {
                    Velocity = Velocity
                };
            });

            NativeHelper.OnNativeTick += Tick;
        }

        public void ReadPayload(PlayerUpdatePayload payload)
        {
            Position = payload.Position;
            Heading = payload.Heading;
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

            _lastPayload = payload;
        }

        private void CheckForChanges()
        {
            if (Model != _lastPayload.Model)
            {
                    NativePed.Model = _lastPayload.Model;
                    Model = _lastPayload.Model;
            }

            if (WeaponModel != _lastPayload.WeaponModel)
            {
                NativePed.GiveWeaponToPed(_lastPayload.WeaponModel, 999, true, true);
                WeaponModel = _lastPayload.WeaponModel;
            }
        }

        private void Tick(float deltaTime)
        {
            _ticks++;

            CheckForChanges();

            if (IsClimbingLadder)
            {
                var animationName = GetLadderClimbingAnimationName();

                if (NativePed.IsEntityPlayingAnim("laddersbase", animationName, 3) == false)
                {
                    NativePed.ClearPedTasks();
                    Streaming.LoadAnimationDictionary("laddersbase");
                    NativePed.TaskPlayAnim("laddersbase", animationName, 8.0f, 10f, -1, 1 | 2147483648, 1.0f, true, true, true);
                }
            }

            UpdateWeaponAnimation();

            if (UpdateVehicleAnimations())
            {
                return;
            }

            UpdatePosition(deltaTime);
            UpdateHeading(deltaTime);

            UpdateMovementAnimation();

            UpdateRagdoll();

            ExecutionHelper.ExecuteOnce($"PLAYER_{Id}_JUMPING", IsJumping, () =>
            {
                NativePed.TaskJump();
            });

            ExecutionHelper.ExecuteOnce($"PLAYER_{Id}_CLIMBING", IsClimbing, () =>
            {
                NativePed.TaskClimb();
            });
        }

        private void UpdatePosition(float deltaTime)
        {
            if (IsClimbing && IsClimbingLadder == false)
            {
                return;
            }

            var pedPosition = NativePed.Position;
            
            if (IsClimbingLadder)
            {
                Position = Vector3.Lerp(pedPosition, Position + Velocity * 0.2f, deltaTime * 3);

                return;
            }

            if (Vector3.DistanceSquared(pedPosition, Position) > 6.25f)
            {
                NativePed.Position = Position;
            }

            var positionDifference = Position - pedPosition;
            NativePed.Velocity = Velocity + positionDifference * 0.75f;
        }

        private void UpdateHeading(float deltaTime)
        {
            var pedRotation = NativePed.Rotation;

            var interpolatedHeading = Interpolation.LerpDegrees(pedRotation.Z, Heading, deltaTime * _interpolationFactor);

            NativePed.Rotation = new Vector3(pedRotation.X, pedRotation.Y, interpolatedHeading);
        }

        private void UpdateRagdoll()
        {
            ExecutionHelper.ExecuteOnce($"PLAYER_{Id}_RAGDOLL", IsRagdoll, () =>
            {
                NativePed.SetPedCanRagdoll(true);

                var forward = NativePed.Forward;
                NativePed.SetPedToRagdollWithFall(99999, 2000, 1, forward.X, forward.Y, forward.Z, 2.0f);
            }, () =>
            {
                NativePed.ClearPedTasks();

                NativePed.SetPedCanRagdoll(false);
            });
        }

        private void UpdateMovementAnimation()
        {
            if (IsJumping || IsClimbing || IsClimbingLadder || IsRagdoll || IsAiming)
            {
                return;
            }

            var end = Position + Velocity;
            var range = Vector3.Distance(Position, end);

            switch (Speed)
            {
                case 1:
                    {
                        if (NativePed.IsPedWalking() && range < 0.1f)
                        {
                            break;
                        }

                        NativePed.TaskGoStraightToCoord(end.X, end.Y, end.Z, 1.0f, -1, 0.0f, 0.0f);
                        NativePed.SetPedDesiredMoveBlendRatio(1.0f);

                        break;
                    }

                case 2:
                    {
                        if (NativePed.IsPedRunning() && range < 0.2f)
                        {
                            break;
                        }

                        NativePed.TaskGoStraightToCoord(end.X, end.Y, end.Z, 2.0f, -1, 0.0f, 0.0f);
                        NativePed.SetPedDesiredMoveBlendRatio(1.0f);

                        break;
                    }

                case 3:
                    {
                        if (NativePed.IsPedSprinting() && range < 0.3f)
                        {
                            break;
                        }

                        NativePed.TaskGoStraightToCoord(end.X, end.Y, end.Z, 3.0f, -1, 0.0f, 0.0f);
                        NativePed.SetPedDesiredMoveBlendRatio(1.0f);

                        break;
                    }

                default:
                    NativePed.TaskStandStill(2000);

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
                _aimProp?.Delete();
                _followProp?.Delete();

                NativePed.Delete();
            });
        }

    }
}
