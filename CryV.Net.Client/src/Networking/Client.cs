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

        public Client(int id, Vector3 position, Vector3 velocity, float heading)
        {
            Id = id;

            _ped = new Ped("mp_m_freemode_01", position, heading)
            {
                Velocity = velocity
            };
        }

        public void Tick()
        {
            var end = Position + Velocity;
            var range = Vector3.Distance(Position, end);

            switch (Speed)
            {
                case 1:
                {
                    if (_ped.IsPedWalking() && range < 0.25f)
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
                    if (_ped.IsPedRunning() && range < 0.5f)
                    {
                        break;
                    }

                    _ped.TaskGoStraightToCoord(end.X, end.Y, end.Z, Speed, -1, 0.0f, 0.0f);
                    _ped.SetPedDesiredMoveBlendRatio(1.0f);

                    break;
                }

                case 3:
                {
                    if (_ped.IsPedSprinting() && range < 0.75f)
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
        }

        public void Dispose()
        {
            _ped.Delete();
        }
    }
}
