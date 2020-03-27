using Autofac;

namespace CryV.Net.Client.Api
{
    public class ApiModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ScriptManager>()
                .AsImplementedInterfaces()
                .SingleInstance();
        }
    }
}
