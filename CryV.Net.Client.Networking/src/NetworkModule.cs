using Autofac;

namespace CryV.Net.Client.Networking
{
    public class NetworkModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<NetworkManager>()
                .AsImplementedInterfaces()
                .SingleInstance();
        }
    }
}
