using CryV.Net.Shared.Enums;
using ProtoBuf;

namespace CryV.Net.Shared.Payloads
{
    [ProtoContract]
    public class PointingUpdatePayload : IPayload
    {

        public PayloadType PayloadType { get; } = PayloadType.UpdatePointing;

        [ProtoMember(1)]
        public int Id { get; set; }

        [ProtoMember(2)]
        public float Pitch { get; set; }

        [ProtoMember(3)]
        public float Heading { get; set; }

        public PointingUpdatePayload()
        {
        }

        public PointingUpdatePayload(int id, float pitch, float heading)
        {
            Id = id;
            Pitch = pitch;
            Heading = heading;
        }

    }
}
