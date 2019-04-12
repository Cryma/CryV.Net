using System;
using Autofac;
using CryV.Net.Client.Debugging.Menu;

namespace CryV.Net.Client.Debugging
{
    public class DebuggingModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DebugMenu>()
                .AsImplementedInterfaces()
                .SingleInstance();
        }
    }
}
