using System;
using Autofac;

namespace CryV.Net.Client.LocalPlayer
{
    public class LocalPlayerModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<LocalPlayer>()
                .AsImplementedInterfaces()
                .SingleInstance();
        }
    }
}
