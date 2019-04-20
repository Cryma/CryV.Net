using System;
using Autofac;

namespace CryV.Net.Client.Http
{
    public class ApiModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ScriptManager>()
                .AsImplementedInterfaces()
                .SingleInstance();
        }
    }
}
