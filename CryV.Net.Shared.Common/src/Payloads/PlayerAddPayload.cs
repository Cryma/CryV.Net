using CryV.Net.Shared.Common.Enums;
using ProtoBuf;

namespace CryV.Net.Shared.Common.Payloads
{
    [ProtoContract]
    public class PlayerAddPayload : IPayload
    {
        public PayloadType PayloadType { get; } = PayloadType.AddPlayer;

        [ProtoMember(1)]
        public PlayerUpdatePayload Data { get; set; }

        public PlayerAddPayload()
        {
        }

        public PlayerAddPayload(PlayerUpdatePayload data)
        {
            Data = data;
        }

    }
}
