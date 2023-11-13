using Microsoft.Extensions.Logging;

namespace CryV.Net.Server.Common.Interfaces.Api;

public interface ILogging
{

    ILogger<T> GetLogger<T>();

}
