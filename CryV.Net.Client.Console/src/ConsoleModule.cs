using System;
using Autofac;

namespace CryV.Net.Client.Console
{
    public class ConsoleModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<GameConsole>()
                .AsImplementedInterfaces()
                .SingleInstance();
        }
    }
}
