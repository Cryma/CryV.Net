using System;
using Autofac;

namespace CryV.Net.Client.Cleanup
{
    public class CleanupModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Cleanup>()
                .AsImplementedInterfaces()
                .SingleInstance();
        }
    }
}

