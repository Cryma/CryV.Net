using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using CryV.Net.Elements;
using Micky5991.EventAggregator.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using Serilog.Events;
#if DEBUG
using System.Runtime.InteropServices;
#endif

namespace CryV.Net.Client.Core
{
    public class ContainerManager
    {

        public IContainer Container { get; set; }

        public void Start()
        {
#if DEBUG
            AllocConsole();
#endif

            var builder = new ContainerBuilder();

            var serviceCollection = new ServiceCollection();
            serviceCollection.AddEventAggregator();

            var serilogLogger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
                .Enrich.FromLogContext()
                .WriteTo.File(Path.Combine(Utility.GetInstallDirectory(), "cryv-net.log"))
#if DEBUG
                .WriteTo.Console()
#endif
                .CreateLogger();

            serviceCollection.AddLogging(serilogBuilder => serilogBuilder.AddSerilog(serilogLogger));

            builder.Populate(serviceCollection);

            builder.RegisterAssemblyModules(GetAssemblies().ToArray());

            Container = builder.Build();
        }

        public IList<Assembly> GetAssemblies()
        {
            var ignoredAssemblies = new List<string>
            {
                GetPath("CryV.Net.Client.Core.dll"),
                GetPath("CryV.Net.Client.Common.dll"),
                GetPath("CryV.Net.Shared.Common.dll")
            };

            var components = Directory.GetFiles(GetPath(), "CryV.Net.Client.*.dll").Concat(Directory.GetFiles(GetPath(), "CryV.Net.Shared.*.dll")).Except(ignoredAssemblies);

            var loadedAssemblies = AppDomain.CurrentDomain.GetAssemblies();

            var componentAssemblies = new List<Assembly>();
            foreach (var file in components)
            {
                var assemblyMeta = AssemblyName.GetAssemblyName(file);

                var foundAssembly = loadedAssemblies.FirstOrDefault(x => x.GetName().FullName == assemblyMeta.FullName);
                if (foundAssembly != null)
                {
                    componentAssemblies.Add(foundAssembly);

                    continue;
                }

                componentAssemblies.Add(Assembly.LoadFrom(file));
            }

            return componentAssemblies;
        }

        private string GetPath(string path = "")
        {
            return Path.Combine(Path.GetDirectoryName(Assembly.GetAssembly(typeof(CryV)).Location), path);
        }

#if DEBUG
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool AllocConsole();
#endif

    }
}
