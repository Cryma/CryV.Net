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

        public int Speed
        {
            get => _ped.FakeSpeed;
            set => _ped.FakeSpeed = value;
        }

        private readonly Ped _ped;

        public Client(int id, Vector3 position, Vector3 velocity, float heading)
        {
            Id = id;

            _ped = new Ped("mp_m_freemode_01", position, heading)
            {
                Velocity = velocity
            };
        }

        public void Dispose()
        {
            _ped.Delete();
        }
    }
}
