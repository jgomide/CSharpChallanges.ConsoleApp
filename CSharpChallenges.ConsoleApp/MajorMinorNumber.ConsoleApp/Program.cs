using System;

namespace MajorMinorNumber.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            while (true)
            {
                Console.WriteLine("Enter 2 numbers separeted with ',' (comma) or 'q' to quit");
                var input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                    //continue;
                }        
                
                NumberAppService numberAppService = new NumberAppService();
                numberAppService.ValidateNumbers(input);
                
                foreach (var logMessage in numberAppService.ListLogs)
                {
                    char firstDigit = logMessage.codMessage.ToString()[0];

                    if (firstDigit == '1')
                        Console.WriteLine($"Result: {logMessage.message}");
                    else
                        Console.WriteLine($"Error number: {logMessage.codMessage} Message: {logMessage.message}");
                }
            }
        }
    }
}
