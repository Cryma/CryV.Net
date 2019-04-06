using System.Numerics;
using ProtoBuf;

namespace CryV.Net.Shared.Payloads.Partials
{
    [ProtoContract]
    public class SerializableVector3
    {
        
        public float X { get; set; }

        public float Y { get; set; }

        public float Z { get; set; }

        public SerializableVector3()
        {
        }

        public SerializableVector3(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static implicit operator Vector3(SerializableVector3 vector)
        {
            return new Vector3(vector.X, vector.Y, vector.Z);
        }

        public static implicit operator SerializableVector3(Vector3 vector)
        {
            return new SerializableVector3(vector.X, vector.Y, vector.Z);
        }

    }
}
