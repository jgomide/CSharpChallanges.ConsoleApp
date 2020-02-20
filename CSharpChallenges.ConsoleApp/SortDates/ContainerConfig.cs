using Autofac;

namespace SortDates.ConsoleApp
{
    class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterType<DateCheckService>().As<IDateCheckService>();
            

            return builder.Build();

        }
    }
}
