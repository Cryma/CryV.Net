using CryV.Net.Shared.Common.Enums;
using ProtoBuf;

namespace CryV.Net.Shared.Common.Payloads
{
    [ProtoContract]
    public class AddClientPayload : IPayload
    {
        public PayloadType PayloadType { get; } = PayloadType.AddClient;

        [ProtoMember(1)]
        public ClientUpdatePayload Data { get; set; }

        public AddClientPayload()
        {
        }

        public AddClientPayload(ClientUpdatePayload data)
        {
            Data = data;
        }

    }
}
