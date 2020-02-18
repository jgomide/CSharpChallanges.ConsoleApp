using MajorMinorNumber.ConsoleApp.Validations;
using Autofac;

namespace MajorMinorNumber.ConsoleApp
{
    class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterType<NumbersService>().As<INumbersService>();
            builder.RegisterType<Validation>().As<IValidation>();

            return builder.Build();
        }
    }
}
