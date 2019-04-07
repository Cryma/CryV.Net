using System;
using System.Numerics;
using CryV.Net.Client.Elements;
using CryV.Net.Client.Helpers;
using CryV.Net.Client.Native;

namespace CryV.Net.Client.Networking
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

        private readonly Ped _ped;

        private DateTime _lastTick;

        public static float InterpolationFactor = 3f;

        private float _lastRange;
        private bool _wasNegative;

        public Client(int id, ulong model, Vector3 position, Vector3 velocity, float heading)
        {
            Id = id;
            TargetPosition = position;
            TargetHeading = heading;

            _lastTick = DateTime.UtcNow;

            _ped = new Ped(model, position, heading)
            {
                Velocity = velocity
            };
        }

        public void Tick()
        {
            var now = DateTime.UtcNow;
            var deltaTime = (float) (now - _lastTick).TotalSeconds;

            var interpolatedPosition = Vector3.Lerp(Position, TargetPosition, deltaTime * InterpolationFactor);
            Position = interpolatedPosition;
            _ped.Velocity = Velocity;

            var interpolatedHeading = Interpolation.LerpDegrees(Rotation.Z, TargetHeading, deltaTime * InterpolationFactor);
            Rotation = new Vector3(Rotation.X, Rotation.Y, interpolatedHeading);

            var end = TargetPosition + Velocity;
            var range = Vector3.Distance(TargetPosition, end);
            var deltaRange = range - _lastRange;

            _lastRange = range;
            _lastTick = now;

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

        public void Dispose()
        {
            _ped.Delete();
        }
    }
}
