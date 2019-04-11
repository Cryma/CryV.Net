using System;
using System.Numerics;
using CryV.Net.Elements;
using CryV.Net.Client.Helpers;
using CryV.Net.Client.Helpers.Pointing;
using CryV.Net.Shared.Events.Types;
using CryV.Net.Shared.Payloads;
using CryV.Net.Shared.Payloads.Flags;
using EventHandler = CryV.Net.Shared.Events.EventHandler;

namespace CryV.Net.Client.Elements
{
    public class Client : IDisposable
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

        private readonly Ped _ped;
        private readonly FingerPointing _pointing;

        private DateTime _lastTick;

        public static float InterpolationFactor = 3f;

        private float _lastRange;
        private bool _wasNegative;
        private bool _wasJumping;
        private bool _wasClimbing;
        private bool _wasRagdoll;

        public Client(ClientUpdatePayload payload)
        {
            Id = payload.Id;
            TargetPosition = payload.Position;
            TargetHeading = payload.Heading;

            _lastTick = DateTime.UtcNow;
            
            _ped = new Ped(payload.Model, payload.Position, payload.Heading)
            {
                Velocity =  payload.Velocity
            };

            _pointing = new FingerPointing(_ped);

            EventHandler.Subscribe<NetworkEvent<PointingUpdatePayload>>(_pointing.OnPointingUpdate, networkEvent => networkEvent.Payload.Id == Id);
        }

        public void ReadPayload(ClientUpdatePayload payload)
        {
            TargetPosition = payload.Position;
            TargetHeading = payload.Heading;
            Velocity = payload.Velocity;
            Speed = payload.Speed;

            if (Model != payload.Model)
            {
                Model = payload.Model;
            }

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
        }

        public void Tick()
        {
            var now = DateTime.UtcNow;
            var deltaTime = (float) (now - _lastTick).TotalSeconds;

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

            UpdateMovementAnimation(now);

            UpdateRagdoll();

            _pointing.Tick(deltaTime);

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
            Position = Vector3.Lerp(Position, TargetPosition, deltaTime * InterpolationFactor);
            _ped.Velocity = Velocity;
        }

        private void UpdateHeading(float deltaTime)
        {
            var interpolatedHeading = Interpolation.LerpDegrees(Rotation.Z, TargetHeading, deltaTime * InterpolationFactor);

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

        private void UpdateMovementAnimation(DateTime now)
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
            _ped.Delete();
        }
    }
}
