using System;
using Autofac;

namespace CryV.Net.Server.Api
{
    public class ApiModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<GamemodeLoader>()
                .AsImplementedInterfaces()
                .SingleInstance();
        }
    }
}
