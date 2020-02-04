using System;
using System.Linq;

namespace SortDates.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DateCheckAppService dateCheckAppService = new DateCheckAppService();
            DateCheckService dateCheckService = new DateCheckService();
            int inputCount = 0;            
            DateTime[] datesToCompare = new DateTime[3];


            while (true)
            {
                if (inputCount == 0)
                {
                    Console.WriteLine(" ----------- ENTER 3 DATES  ----------");
                    Console.WriteLine(" date format 'dd/mm/yy' or 'q' to quit");
                    Console.WriteLine(" -------------------------------------");
                }

                Console.WriteLine($"TYPE THE {Utilities.dateCount(inputCount)} DATE: ...");
                var input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                    //continue;
                }                                
                
                if ((inputCount <= 2) && dateCheckAppService.isDateTime(input))
                {
                    datesToCompare[inputCount] = DateCheckAppService.convertDate(input);                
                    inputCount += 1;                    
                }                

                if ((inputCount == 3) && (dateCheckAppService.ListLogs.Count == 0))
                {
                    dateCheckService.sortDates(datesToCompare);
                    dateCheckAppService.ListLogs.AddRange(dateCheckService.ListLogs);
                    inputCount = 0;
                    //datesToCompare = Enumerable.Range(0, 2).Select(i => DateTime.MinValue).ToArray(); ;
                }

                if (dateCheckAppService.ListLogs.Count != 0)
                {
                    foreach (var logMessage in dateCheckAppService.ListLogs)
                    {
                        char firstDigit = logMessage.codMessage.ToString()[0];

                        if (firstDigit == '1')
                            Console.WriteLine($"Result: {logMessage.message}");
                        else
                            Console.WriteLine($"Error number: {logMessage.codMessage} Message: {logMessage.message}");
                    }

                    dateCheckAppService.ListLogs.Clear();
                }                
            }
        }
    }
}
