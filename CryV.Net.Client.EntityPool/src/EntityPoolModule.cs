using System;
using Autofac;

namespace CryV.Net.Client.EntityPool
{
    public class EntityPoolModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<EntityPool>()
                .AsImplementedInterfaces()
                .SingleInstance();
        }
    }

}
