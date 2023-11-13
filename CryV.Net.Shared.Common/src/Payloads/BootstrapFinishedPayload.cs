using CryV.Net.Shared.Common.Enums;
using ProtoBuf;

namespace CryV.Net.Shared.Common.Payloads;

[ProtoContract]
public class BootstrapFinishedPayload : IPayload
{
    public PayloadType PayloadType { get; } = PayloadType.BootstrapFinished;

    [ProtoMember(1)]
    public int Id { get; set; }

}
