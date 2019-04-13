using System;
using Autofac;
using CryV.Net.Client.FingerPointing.src;

namespace CryV.Net.Client.FingerPointing
{
    public class FingerPointingModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<LocalFingerPointing>()
                .AsImplementedInterfaces()
                .SingleInstance();

            builder.RegisterType<FingerPointingManager>()
                .AsImplementedInterfaces()
                .SingleInstance();
        }
    }
}
