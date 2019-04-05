using System.Numerics;

namespace CryV.Net.Shared.Payloads.Partials
{
    public class ClientPayload
    {
        
        public int Id { get; set; }

        public Vector3 Position { get; set; }

        public float Heading { get; set; }

        public ClientPayload(int id, Vector3 position, float heading)
        {
            Id = id;
            Position = position;
            Heading = heading;
        }

    }
}
