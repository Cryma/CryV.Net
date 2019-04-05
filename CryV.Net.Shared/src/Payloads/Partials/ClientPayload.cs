using System.Numerics;
using LiteNetLib.Utils;

namespace CryV.Net.Shared.Payloads.Partials
{
    public class ClientPayload
    {
        
        public int Id { get; set; }

        public Vector3 Position { get; set; }

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

        public void Write(NetDataWriter writer)
        {
            writer.Put(Id);

            writer.Put(Position.X);
            writer.Put(Position.Y);
            writer.Put(Position.Z);

            writer.Put(Heading);
        }

        public void Read(NetDataReader reader)
        {
            Id = reader.GetInt();
            Position = new Vector3(reader.GetFloat(), reader.GetFloat(), reader.GetFloat());
            Heading = reader.GetFloat();
        }

    }
}
