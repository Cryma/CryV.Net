using CryV.Net.Shared.Enums;

namespace CryV.Net.Shared.Payloads
{
    public interface IPayload
    {

        PayloadType PayloadType { get; }

    }
}
