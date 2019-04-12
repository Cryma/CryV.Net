using System;
using Autofac;

namespace CryV.Net.Client.Players
{
    public class PlayersModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<PlayerManager>()
                .AsImplementedInterfaces()
                .SingleInstance();
        }
    }
}
