using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using CryV.Net.Server.Api.Gamemode;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Nancy;
using Nancy.Bootstrapper;
using Nancy.Owin;
using Nancy.Responses.Negotiation;
using Newtonsoft.Json;

namespace CryV.Net.Server.Api.Http;

public class DownloadServer : IDisposable
{

    private readonly IWebHost _webHost;

    public DownloadServer()
    {
        _webHost = new WebHostBuilder()
#if DEBUG
            .UseEnvironment("Development")
#else
            .UseEnvironment("Production")
#endif
            .UseKestrel(options =>
            {
                options.Listen(IPAddress.Any, 1338);
                options.AllowSynchronousIO = true;
            })
            .UseStartup<Startup>()
            .Build();

        _webHost.Start();
    }

    public void Dispose()
    {
        _webHost.Dispose();
    }

}

public sealed class DownloadModule : NancyModule
{

    public static Dictionary<string, GamemodeEntry> Gamemodes;

    public DownloadModule()
    {
        Get("/{gamemode}/{path**}", parameters =>
        {
            if (Gamemodes == null)
            {
                return 404;
            }

            var gamemodeName = (string) parameters.gamemode;
            if (Gamemodes.ContainsKey(gamemodeName) == false)
            {
                return 404;
            }

            var path = (string) parameters.path;
            if (Gamemodes.Values.Any(x => x.ClientsideFiles.Any(y => y.Path.Replace('\\', '/') == path)) == false)
            {
                return 404;
            }

            var filePath = Path.Combine(Environment.CurrentDirectory, "gamemode", gamemodeName, "client", path);
            if (File.Exists(filePath))
            {
                return Response.AsFile(filePath);
            }

            return 404;
        });

        Get("/filemap.json", _ =>
        {
            if (Gamemodes == null)
            {
                return 404;
            }

            return JsonConvert.SerializeObject(Gamemodes.ToDictionary(x => x.Key, y => y.Value.ClientsideFiles));
        });
    }

}

public class CryVBootstrapper : DefaultNancyBootstrapper
{
    protected override Func<ITypeCatalog, NancyInternalConfiguration> InternalConfiguration
    {
        get
        {
            return NancyInternalConfiguration.WithOverrides(x =>
            {
                x.ResponseProcessors = new List<Type>
                {
                    typeof(ResponseProcessor),
                    typeof(ViewProcessor)
                };
            });
        }
    }
}

public sealed class Startup
{

    private readonly IConfiguration _configuration;

    public Startup(IWebHostEnvironment environment)
    {
        var builder = new ConfigurationBuilder();

        _configuration = builder.Build();
    }

    public void Configure(IApplicationBuilder application)
    {
        application.UseOwin(x => x.UseNancy(options => options.Bootstrapper = new CryVBootstrapper()));
    }

}
