using CryV.Net.Shared.Enums;
using CryV.Net.Shared.Payloads.Partials;
using ProtoBuf;

namespace CryV.Net.Shared.Payloads
{
    [ProtoContract]
    public class TransformUpdatePayload : IPayload
    {

        public PayloadType PayloadType { get; } = PayloadType.TransformUpdate;

        [ProtoMember(1)]
        public ClientPayload Client { get; set; }

        public TransformUpdatePayload()
        {
        }

        public TransformUpdatePayload(ClientPayload clientPayload)
        {
            Client = clientPayload;
        }

    }
}
