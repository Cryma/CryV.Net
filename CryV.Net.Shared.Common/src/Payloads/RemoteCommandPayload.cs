using CryV.Net.Shared.Common.Enums;
using ProtoBuf;

namespace CryV.Net.Shared.Common.Payloads;

[ProtoContract]
public class RemoteCommandPayload : IPayload
{
    public PayloadType PayloadType { get; } = PayloadType.RemoteCommand;

    [ProtoMember(1)]
    public string Command { get; set; }

    // Empty construct is needed due to reflection
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public RemoteCommandPayload()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    {

    }

    public RemoteCommandPayload(string command)
    {
        Command = command;
    }

}
