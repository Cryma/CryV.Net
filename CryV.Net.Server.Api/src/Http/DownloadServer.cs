using System;
using System.Net;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Nancy;
using Nancy.Owin;

namespace CryV.Net.Server.Api.Http
{
    public class DownloadServer : IDisposable
    {

        private readonly IWebHost _webHost;

        public DownloadServer()
        {
            _webHost = new WebHostBuilder()
                .UseKestrel(options =>
                {
                    options.Listen(IPAddress.Any, 1338);
                })
                .UseStartup<Startup>()
                .Build();

            _webHost.Run();
        }

        public void Dispose()
        {
            _webHost.Dispose();
        }

    }

    public sealed class DownloadModule : NancyModule
    {

        public DownloadModule()
        {
            Get("/{resource}/{path*}", parameters =>
            {
                return 404;
            });

            Get("/filemap.json", _ =>
            {
                return 404;
            });
        }

    }

    public sealed class Startup
    {

        private readonly IConfiguration _configuration;

        public Startup(IHostingEnvironment environment)
        {
            var builder = new ConfigurationBuilder();

            _configuration = builder.Build();
        }

        public void Configure(IApplicationBuilder application)
        {
            application.UseOwin(x => x.UseNancy());
        }

    }

}
