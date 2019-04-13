using CryV.Net.Shared.Common.Enums;
using ProtoBuf;

namespace CryV.Net.Shared.Common.Payloads
{
    [ProtoContract]
    public class StopPointingPayload : IPayload
    {
        public PayloadType PayloadType { get; } = PayloadType.StopPointing;

        [ProtoMember(1)]
        public int Id { get; set; }

        public StopPointingPayload()
        {
        }

        public StopPointingPayload(int id)
        {
            Id = id;
        }

    }
}
