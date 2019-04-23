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

        public Ped Ped { get; private set; }

        private static float _interpolationFactor = 3.0f;

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
            Model = payload.Model;

            ReadPayload(payload);

            _eventSubscriptions.Add(_eventHandler.Subscribe<NetworkEvent<PlayerUpdatePayload>>(update =>
            {
                ReadPayload(update.Payload);
                CheckForChanges(update.Payload);
            }, x => x.Payload.Id == Id));

            ThreadHelper.Run(() =>
            {
                Ped = new Ped(Model, Position, Heading)
                {
                    Velocity = Velocity
                };

                CheckForChanges(payload);

                EntityPool.AddEntity(Ped);
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
        }

        private void CheckForChanges(PlayerUpdatePayload payload)
        {
            if (Model != payload.Model)
            {
                ThreadHelper.Run(() =>
                {
                    Ped.Model = payload.Model;
                    Model = payload.Model;
                });
            }

            if (WeaponModel != payload.WeaponModel)
            {
                ThreadHelper.Run(() =>
                {
                    Ped.GiveWeaponToPed(payload.WeaponModel, 999, true, true);
                    WeaponModel = payload.WeaponModel;
                });
            }
        }

        private void Tick(float deltaTime)
        {
            _ticks++;

            if (IsClimbingLadder)
            {
                var animationName = GetLadderClimbingAnimationName();

                if (Ped.IsEntityPlayingAnim("laddersbase", animationName, 3) == false)
                {
                    Ped.ClearPedTasks();
                    Streaming.LoadAnimationDictionary("laddersbase");
                    Ped.TaskPlayAnim("laddersbase", animationName, 8.0f, 10f, -1, 1 | 2147483648, 1.0f, true, true, true);
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

            UpdateMovementAnimation();

            UpdateRagdoll();

            ExecutionHelper.ExecuteOnce($"PLAYER_{Id}_JUMPING", IsJumping, () =>
            {
                Ped.TaskJump();
            });

            ExecutionHelper.ExecuteOnce($"PLAYER_{Id}_CLIMBING", IsClimbing, () =>
            {
                Ped.TaskClimb();
            });
        }

        private void UpdatePosition(float deltaTime)
        {
            if (IsClimbing && IsClimbingLadder == false)
            {
                return;
            }

            var pedPosition = Ped.Position;
            
            if (IsClimbingLadder)
            {
                Position = Vector3.Lerp(pedPosition, Position + Velocity * 0.2f, deltaTime * 3);

                return;
            }

            if (Vector3.DistanceSquared(pedPosition, Position) > 6.25f)
            {
                Ped.Position = Position;
            }

            var positionDifference = Position - pedPosition;
            Ped.Velocity = Velocity + positionDifference * 0.75f;
        }

        private void UpdateHeading(float deltaTime)
        {
            var pedRotation = Ped.Rotation;

            var interpolatedHeading = Interpolation.LerpDegrees(pedRotation.Z, Heading, deltaTime * _interpolationFactor);

            Ped.Rotation = new Vector3(pedRotation.X, pedRotation.Y, interpolatedHeading);
        }

        private void UpdateRagdoll()
        {
            ExecutionHelper.ExecuteOnce($"PLAYER_{Id}_RAGDOLL", IsRagdoll, () =>
            {
                Ped.SetPedCanRagdoll(true);

                Ped.ClearPedTasksImmediately();
                Ped.SetPedToRagdoll(-1, -1, 0, false, false, false);
            }, () =>
            {
                Ped.ClearPedTasks();

                Ped.SetPedCanRagdoll(false);
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
                        if (Ped.IsPedWalking() && range < 0.1f)
                        {
                            break;
                        }

                        Ped.TaskGoStraightToCoord(end.X, end.Y, end.Z, 1.0f, -1, 0.0f, 0.0f);
                        Ped.SetPedDesiredMoveBlendRatio(1.0f);

                        break;
                    }

                case 2:
                    {
                        if (Ped.IsPedRunning() && range < 0.2f)
                        {
                            break;
                        }

                        Ped.TaskGoStraightToCoord(end.X, end.Y, end.Z, 2.0f, -1, 0.0f, 0.0f);
                        Ped.SetPedDesiredMoveBlendRatio(1.0f);

                        break;
                    }

                case 3:
                    {
                        if (Ped.IsPedSprinting() && range < 0.3f)
                        {
                            break;
                        }

                        Ped.TaskGoStraightToCoord(end.X, end.Y, end.Z, 3.0f, -1, 0.0f, 0.0f);
                        Ped.SetPedDesiredMoveBlendRatio(1.0f);

                        break;
                    }

                default:
                    Ped.TaskStandStill(2000);

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
                EntityPool.RemoveEntity(Ped);

                _aimProp?.Delete();
                _followProp?.Delete();

                Ped.Delete();
            });
        }

    }
}
