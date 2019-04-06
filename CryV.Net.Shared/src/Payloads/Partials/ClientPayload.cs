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
        public float Heading { get; set; }

        public ClientPayload()
        {
        }

        public ClientPayload(int id, Vector3 position, float heading)
        {
            Id = id;
            Position = position;
            Heading = heading;
        }

    }
}
