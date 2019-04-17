using System;
using Autofac;

namespace CryV.Net.Client.Vehicles
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
