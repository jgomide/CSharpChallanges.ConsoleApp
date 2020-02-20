using System;
using Autofac;


namespace SortDates.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = ContainerConfig.Configure();
            var scope = container.BeginLifetimeScope();
            var app = scope.Resolve<IApplication>();

            int inputCount = 0;            
            DateTime[] datesToCompareArray = new DateTime[3];

            while (true)
            {
                if (inputCount == 0)
                {
                    Console.WriteLine(" ----------- ENTER 3 DATES  ----------");
                    Console.WriteLine(" date format 'dd/mm/yy' or 'q' to quit");
                    Console.WriteLine(" -------------------------------------");
                }
                           
                Console.WriteLine($"TYPE THE {NumConverter.LiteralNumConverter(inputCount)} DATE: ...");

                var input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                    //continue;
                }                

                if (input.IsDateTime())
                {
                    if (inputCount <= 2)
                    {
                        datesToCompareArray[inputCount] = input.ConvertDate();
                        inputCount += 1;
                    }
                }
                else
                {
                    Console.WriteLine("Format incorrect, please insert a valid date.");
                }               

                if (inputCount == 3)
                {
                    app.Run(datesToCompareArray);                    
                    inputCount = 0;                    
                }
            }
        }
    }
}
