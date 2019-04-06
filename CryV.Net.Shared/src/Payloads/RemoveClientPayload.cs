using CryV.Net.Shared.Enums;
using ProtoBuf;

namespace CryV.Net.Shared.Payloads
{
    [ProtoContract]
    public class RemoveClientPayload : IPayload
    {

        public PayloadType PayloadType { get; } = PayloadType.RemoveClient;

        [ProtoMember(1)]
        public int Id { get; set; }

        public RemoveClientPayload()
        {
        }

        public RemoveClientPayload(int id)
        {
            Id = id;
        }

    }
}
