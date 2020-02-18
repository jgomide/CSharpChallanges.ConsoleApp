using AgeMajority.ConsoleApp.Interfaces;
using AgeMajority.ConsoleApp.Services;
using AgeMajority.ConsoleApp.Validations;
using Autofac;

namespace AgeMajority.ConsoleApp
{
    class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();


            builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterType<AgeMajorityService>().As<IAgeMajorityService>();
            builder.RegisterType<Validation>().As<IValidation>();

            return builder.Build();

        }
    }
}
