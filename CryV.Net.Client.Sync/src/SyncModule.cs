using Autofac;

namespace CryV.Net.Client.Sync.src
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
