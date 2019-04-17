using System.Numerics;
using CryV.Net.Server.Common.Interfaces;
using CryV.Net.Shared.Common.Payloads;

namespace CryV.Net.Server.Vehicles
{
    public class Vehicle : IVehicle
    {
        
        public int Id { get; }

        public Vector3 Position { get; set; }

        public Vector3 Velocity { get; set; }

        public Vector3 Rotation { get; set; }

        public Vehicle(int id, Vector3 position, Vector3 rotation)
        {
            Id = id;
            Position = position;
            Rotation = rotation;
        }

        public VehicleUpdatePayload GetPayload()
        {
            return new VehicleUpdatePayload(Id, Position, Velocity, Rotation);
        }

        public void ReadPayload(VehicleUpdatePayload payload)
        {
            Position = payload.Position;
            Velocity = payload.Velocity;
            Rotation = payload.Rotation;
        }

    }
}
