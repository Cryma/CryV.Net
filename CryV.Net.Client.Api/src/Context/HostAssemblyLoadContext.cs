using System.Reflection;
using System.Runtime.Loader;

namespace CryV.Net.Client.Api.Context
{
    public class HostAssemblyLoadContext : AssemblyLoadContext
    {

        public HostAssemblyLoadContext() : base(true)
        {
        }

        protected override Assembly Load(AssemblyName assemblyName)
        {
            return null;
        }

    }
}