using Autofac;
using CryV.Net.Client.Players.Local;

namespace CryV.Net.Client.Players
{
    public class PlayersModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<PlayerManager>()
                .AsImplementedInterfaces()
                .SingleInstance();

            builder.RegisterType<LocalPlayer>()
                .AsImplementedInterfaces()
                .SingleInstance();
        }
    }
}
