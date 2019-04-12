using CryV.Net.Shared.Common.Payloads;

namespace CryV.Net.Server.Common.Interfaces
{
    public interface IPlayer
    {
        
        int Id { get; }

        ClientUpdatePayload GetPayload();

    }
}
