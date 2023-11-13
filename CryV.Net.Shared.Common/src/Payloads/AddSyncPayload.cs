using CryV.Net.Shared.Common.Enums;
using ProtoBuf;

namespace CryV.Net.Shared.Common.Payloads;

[ProtoContract]
public class AddSyncPayload : IPayload
{
    public PayloadType PayloadType { get; } = PayloadType.AddSync;

    [ProtoMember(1)]
    public int EntityId { get; set; }

    public AddSyncPayload()
    {
    }

    public AddSyncPayload(int entityId)
    {
        EntityId = entityId;
    }

}
