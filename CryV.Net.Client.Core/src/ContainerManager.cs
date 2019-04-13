using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Autofac;
using CryV.Net.Elements;

namespace CryV.Net.Client.Core
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

            foreach (var assembly in componentAssemblies)
            {
                Utility.Log("Loaded: " + assembly.FullName);
            }

            return componentAssemblies;
        }

        private string GetPath(string path = "")
        {
            return Path.Combine(Path.GetDirectoryName(Assembly.GetAssembly(typeof(CryV)).Location), path);
        }

    }
}
