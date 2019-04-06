using System.Numerics;
using ProtoBuf;

namespace CryV.Net.Shared.Payloads.Partials
{
    [ProtoContract]
    public class ClientPayload
    {
        
        [ProtoMember(1)]
        public int Id { get; set; }

        [ProtoMember(2)]
        public SerializableVector3 Position { get; set; }

        [ProtoMember(3)]
        public SerializableVector3 Velocity { get; set; }

        [ProtoMember(4)]
        public float Heading { get; set; }

        [ProtoMember(5)]
        public int Speed { get; set; }

        public ClientPayload()
        {
        }

        public ClientPayload(int id, Vector3 position, Vector3 velocity, float heading, int speed)
        {
            Id = id;
            Position = position;
            Velocity = velocity;
            Heading = heading;
            Speed = speed;
        }

    }
}
