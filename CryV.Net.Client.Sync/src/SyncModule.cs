using Autofac;

namespace CryV.Net.Client.Sync
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
