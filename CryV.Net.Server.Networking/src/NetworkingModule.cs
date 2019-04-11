using Autofac;

namespace CryV.Net.Server.Networking
{
    public class NetworkingModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<NetworkManager>()
                .AsImplementedInterfaces()
                .SingleInstance();
        }
    }
}
