using CryV.Net.Shared.Common.Enums;
using ProtoBuf;

namespace CryV.Net.Shared.Common.Payloads;

[ProtoContract]
public class PlayerRemovePayload : IPayload
{

    public PayloadType PayloadType { get; } = PayloadType.RemovePlayer;

    [ProtoMember(1)]
    public int Id { get; set; }

    public PlayerRemovePayload()
    {
    }

    public PlayerRemovePayload(int id)
    {
        Id = id;
    }

}
