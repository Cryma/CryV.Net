using CryV.Net.Shared.Common.Enums;
using ProtoBuf;

namespace CryV.Net.Shared.Common.Payloads
{
    [ProtoContract]
    public class RemoveSyncPayload : IPayload
    {
        public PayloadType PayloadType { get; } = PayloadType.RemoveSync;

        [ProtoMember(1)]
        public int EntityId { get; set; }

        public RemoveSyncPayload()
        {
        }

        public RemoveSyncPayload(int entityId)
        {
            EntityId = entityId;
        }

    }
}
