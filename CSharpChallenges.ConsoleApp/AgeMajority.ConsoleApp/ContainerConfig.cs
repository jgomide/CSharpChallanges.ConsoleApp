using AgeMajority.ConsoleApp.Interfaces;
using AgeMajority.ConsoleApp.Services;
using AgeMajority.ConsoleApp.Validations;
using Autofac;
using System.Linq;
using System.Reflection;

namespace AgeMajority.ConsoleApp
{
    class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();


            builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterType<AgeMajorityService>().As<IAgeMajorityService>();
            builder.RegisterType<BaseLog>().As<IBaseLog>();


            builder.RegisterType<Validation>().As<IValidation>();
            
            /*builder.RegisterAssemblyTypes(Assembly.Load(("AgeMajority.ConsoleApp")))
                .Where(t => t.Namespace.Contains("Validations"))
                .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));*/

            return builder.Build();

        }
    }
}
