using MajorMinorNumber.ConsoleApp.Resources;
using MajorMinorNumber.ConsoleApp.Validations;
using System;
using Autofac;

namespace MajorMinorNumber.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = ContainerConfig.Configure();
            var scope = container.BeginLifetimeScope();
            var app = scope.Resolve<IApplication>();

            while (true)
            {
                Console.WriteLine(Messages.INITIAL_CONSOLE_MESSAGE);
                var input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                    //continue;
                }

                app.Run(input);
                
            }
        }
    }
}
