using CryV.Net.Shared.Enums;
using LiteNetLib.Utils;

namespace CryV.Net.Shared.Payloads
{
    public interface IPayload
    {

        PayloadType PayloadType { get; }

        void Write(NetDataWriter writer);
        void Read(NetDataReader reader);

    }
}
