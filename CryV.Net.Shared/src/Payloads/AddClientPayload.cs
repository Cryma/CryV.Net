using CryV.Net.Shared.Enums;
using CryV.Net.Shared.Payloads.Partials;
using ProtoBuf;

namespace CryV.Net.Shared.Payloads
{
    [ProtoContract]
    public class AddClientPayload : IPayload
    {

        public PayloadType PayloadType { get; } = PayloadType.AddClient;

        [ProtoMember(1)]
        public ClientPayload Client { get; set; }

        public AddClientPayload()
        {
        }

        public AddClientPayload(ClientPayload clientPayload)
        {
            Client = clientPayload;
        }

    }
}
