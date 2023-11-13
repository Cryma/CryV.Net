using System.Collections.Generic;

namespace CryV.Net.Server.Common.Interfaces.Api;

public interface IPlayerPool
{

    ICollection<IServerPlayer> GetPlayers();

}
