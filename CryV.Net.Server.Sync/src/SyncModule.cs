using Autofac;

namespace CryV.Net.Server.Sync
{
    public class SyncModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<SyncManager>()
                .AsImplementedInterfaces()
                .SingleInstance();
        }
    }
}
