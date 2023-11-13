using System;
using CryV.Net.Server.Common.Interfaces.Api;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace CryV.Net.Server.Api.Elements;

public class Logging : ILogging
{

    private readonly IServiceProvider _serviceProvider;

    public Logging(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public ILogger<T> GetLogger<T>()
    {
        return _serviceProvider.GetRequiredService<ILogger<T>>();
    }

}
