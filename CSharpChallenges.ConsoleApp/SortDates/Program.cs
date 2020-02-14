using System;

namespace SortDates.ConsoleApp
{
    class Program
    {
        public enum dateSequence
        {
           first, second, third 
        }
         
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

                //refactored using enum (05/02/2020 - jef)
                //Console.WriteLine($"TYPE THE {Utilities.DateCount(inputCount)} DATE: ...");
                Console.WriteLine($"TYPE THE {Utilities.DateCount(inputCount)} DATE: ...");

                var input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                    //continue;
                }
                         
                //refatored using extension (05/02/2020 - jef)
                //if ((inputCount <= 2) && IsDateTime(input))
                if ((inputCount <= 2) && input.IsDateTime(dateCheckAppService))
                {
                    //refatored using extension (05/02/2020 - jef)
                    //datesToCompare[inputCount] = DateCheckAppService.ConvertDate(input);                
                    datesToCompare[inputCount] = input.ConvertDate();
                    
                    inputCount += 1;                    
                }                

                if ((inputCount == 3) && (dateCheckAppService.ListLogs.Count == 0))
                {
                    dateCheckService.SortDates(datesToCompare);
                    dateCheckAppService.ListLogs.AddRange(dateCheckService.ListLogs);
                    inputCount = 0;
                    //datesToCompare = Enumerable.Range(0, 2).Select(i => DateTime.MinValue).ToArray(); ;
                }

                if (dateCheckAppService.ListLogs.Count != 0)
                {
                    foreach (var logMessage in dateCheckAppService.ListLogs)
                    {
                        char firstDigit = logMessage.codeMessage.ToString()[0];

                        if (firstDigit == '1')
                            Console.WriteLine($"Result: {logMessage.message}");
                        else
                            Console.WriteLine($"Error number: {logMessage.codeMessage} Message: {logMessage.message}");
                    }

                    dateCheckAppService.ListLogs.Clear();
                }                
            }
        }
    }
}
