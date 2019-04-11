using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Autofac;

namespace CryV.Net.Server.Core
{
    public class ContainerManager
    {
        
        public IContainer Container { get; set; }

        public void Start()
        {
            var builder = new ContainerBuilder();

            builder.RegisterAssemblyModules(GetAssemblies().ToArray());

            Container = builder.Build();
        }

        public IList<Assembly> GetAssemblies()
        {
            var ignoredAssemblies = new List<string>
            {
                GetPath("CryV.Net.Server.Core.dll"),
                GetPath("CryV.Net.Server.Common.dll")
            };

            var components = Directory.GetFiles(GetPath(), "CryV.Net.Server.*.dll").Except(ignoredAssemblies);

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

            foreach (var assembly in componentAssemblies)
            {
                Console.WriteLine("Loaded: " + assembly.FullName);
            }

            return componentAssemblies;
        }

        private string GetPath(string path = "")
        {
            return Path.Combine(Path.GetDirectoryName(Assembly.GetAssembly(typeof(Program)).Location), path);
        }

    }
}