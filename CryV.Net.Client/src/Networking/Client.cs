using System;
using System.Numerics;
using CryV.Net.Client.Elements;

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

        public Vector3 Velocity
        {
            get => _ped.Velocity;
            set => _ped.Velocity = value;
        }

        public Vector3 Rotation
        {
            get => _ped.Rotation;
            set => _ped.Rotation = value;
        }

        public int Speed { get; set; }

        private readonly Ped _ped;

        private DateTime _lastTick;

        private const float _interpolationFactor = 4.5f;

        public Client(int id, Vector3 position, Vector3 velocity, float heading)
        {
            Id = id;
            TargetPosition = position;

            _lastTick = DateTime.UtcNow;

            _ped = new Ped("mp_m_freemode_01", position, heading)
            {
                Velocity = velocity
            };
        }

        public void Tick()
        {
            var now = DateTime.UtcNow;
            var deltaTime = (float) (now - _lastTick).TotalSeconds;

            var interpolatedPosition = Vector3.Lerp(Position, TargetPosition, deltaTime * _interpolationFactor);
            Position = interpolatedPosition;

            var end = interpolatedPosition + Velocity;
            var range = Vector3.Distance(interpolatedPosition, end);

            switch (Speed)
            {
                case 1:
                {
                    if (_ped.IsPedWalking() && range < 0.1f)
                    {
                        break;
                    }

                    var blend = Math.Min(Math.Pow(range, 2) * 2, 1.0f);

                    _ped.TaskGoStraightToCoord(end.X, end.Y, end.Z, Speed, -1, 0.0f, 0.0f);
                    _ped.SetPedDesiredMoveBlendRatio((float)blend);

                    break;
                }

                case 2:
                {
                    if (_ped.IsPedRunning() && range < 0.2f)
                    {
                        break;
                    }

                    _ped.TaskGoStraightToCoord(end.X, end.Y, end.Z, Speed, -1, 0.0f, 0.0f);
                    _ped.SetPedDesiredMoveBlendRatio(1.0f);

                    break;
                }

                case 3:
                {
                    if (_ped.IsPedSprinting() && range < 0.3f)
                    {
                        break;
                    }

                    _ped.TaskGoStraightToCoord(end.X, end.Y, end.Z, Speed, -1, 0.0f, 0.0f);
                    _ped.SetPedDesiredMoveBlendRatio(1.0f);

                    break;
                }

                default:
                    _ped.TaskStandStill(2000);

                    break;
            }

            _lastTick = now;
        }

        public void Dispose()
        {
            _ped.Delete();
        }
    }
}
