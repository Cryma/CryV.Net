using System;
using Autofac;

namespace CryV.Net.Server.FingerPointing
{
    public class FingerPointingModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<FingerPointingManager>()
                .AsImplementedInterfaces()
                .SingleInstance();
        }
    }
}
