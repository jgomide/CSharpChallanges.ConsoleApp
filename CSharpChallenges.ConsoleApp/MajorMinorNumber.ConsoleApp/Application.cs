
using System;

namespace MajorMinorNumber.ConsoleApp.Validations
{
    class Application : BaseLog, IApplication
    {
        INumbersService _numbersService;

        public Application(INumbersService numbersService)
        {
            _numbersService = numbersService;
        }

        public void Run(string input)
        {
            _numbersService.Calculate(input);

            if (HasMessages())
            {
                foreach (var logMessage in GetMessages())
                {
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine($"INPUT: {input} RESULT: {(logMessage.message)}");
                    Console.WriteLine("----------------------------------------------");
                }

                CleanMessages();
            }            
        }
    }
}
