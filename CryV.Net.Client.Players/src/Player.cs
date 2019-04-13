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

        public int Speed { get; set; }

        public ulong Model
        {
            get => _ped.Model;
            set => _ped.Model = value;
        }

        public bool IsJumping { get; set; }

        public bool IsClimbing { get; set; }

        public bool IsClimbingLadder { get; set; }

        public bool IsRagdoll { get; set; }

        private Ped _ped;

        private static float _interpolationFactor = 3.0f;

        private DateTime _lastTick = DateTime.UtcNow;

        private float _lastRange;
        private bool _wasNegative;
        private bool _wasJumping;
        private bool _wasClimbing;
        private bool _wasRagdoll;

        private readonly List<ISubscription> _eventSubscriptions = new List<ISubscription>();

        private readonly IEventHandler _eventHandler;
        private readonly IEntityPool _entityPool;

        public Player(IEventHandler eventHandler, IEntityPool entityPool, ClientUpdatePayload payload)
        {
            _eventHandler = eventHandler;
            _entityPool = entityPool;

            Id = payload.Id;
            TargetPosition = payload.Position;
            TargetHeading = payload.Heading;

            _eventSubscriptions.Add(_eventHandler.Subscribe<NetworkEvent<ClientUpdatePayload>>(update => ReadPayload(update.Payload), x => x.Payload.Id == Id));

            Utility.Log("Initialized " + Id);

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

        public void ReadPayload(ClientUpdatePayload payload)
        {
            TargetPosition = payload.Position;
            TargetHeading = payload.Heading;
            Velocity = payload.Velocity;
            Speed = payload.Speed;

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

            // TODO: Optimize
            ThreadHelper.Run(() =>
            {
                if (Model != payload.Model)
                {
                    Model = payload.Model;
                }
            });
        }

        private void Tick()
        {
            var now = DateTime.UtcNow;
            var deltaTime = (float)(now - _lastTick).TotalSeconds;

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

            UpdateMovementAnimation();

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

            _lastTick = now;
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

            _ped.Delete();
        }

    }
}
