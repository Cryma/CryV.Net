using System;
using Autofac;

namespace CryV.Net.Server.Vehicles
{
    public class VehiclesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<VehicleManager>()
                .AsImplementedInterfaces()
                .SingleInstance();
        }
    }
}
