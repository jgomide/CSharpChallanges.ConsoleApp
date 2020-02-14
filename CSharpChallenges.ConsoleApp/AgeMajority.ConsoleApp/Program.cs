using AgeMajority.ConsoleApp.Interfaces;
using AgeMajority.ConsoleApp.Resources;
using System;
using Autofac;

namespace AgeMajority.ConsoleApp
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

                Console.WriteLine(Messages.ENTER_AGE_OR_PRESS_Q_QUIT);
                var input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                }

                try
                {
                    app.Run(input);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    //throw;    
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    //throw;    
                }
                finally
                {
                    //..
                }
            }
        }
    }
}
