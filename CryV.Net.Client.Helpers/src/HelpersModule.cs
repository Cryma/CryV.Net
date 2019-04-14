using System;
using Autofac;

namespace CryV.Net.Client.Helpers
{
    public class HelpersModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<PauseMenuHelper>()
                .AsImplementedInterfaces()
                .SingleInstance();
        }
    }
}
