using CryV.Net.Shared.Common.Enums;
using ProtoBuf;

namespace CryV.Net.Shared.Common.Payloads
{
    [ProtoContract]
    public class RemoteCommandPayload : IPayload
    {
        public PayloadType PayloadType { get; } = PayloadType.RemoteCommand;

        [ProtoMember(1)]
        public string Command { get; set; }

        public RemoteCommandPayload()
        {

        }

        public RemoteCommandPayload(string command)
        {
            Command = command;
        }

    }
}
