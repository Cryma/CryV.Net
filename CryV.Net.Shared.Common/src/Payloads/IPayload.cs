using CryV.Net.Shared.Common.Enums;

namespace CryV.Net.Shared.Common.Payloads
{
    public interface IPayload
    {
        
        PayloadType PayloadType { get; }

    }
}