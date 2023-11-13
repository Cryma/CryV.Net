using System.Numerics;
using ProtoBuf;

namespace CryV.Net.Shared.Common.Payloads.Partials;

[ProtoContract]
public class SerializableVector3
{
    
    [ProtoMember(1)]
    public float X { get; set; }

    [ProtoMember(2)]
    public float Y { get; set; }

    [ProtoMember(3)]
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
