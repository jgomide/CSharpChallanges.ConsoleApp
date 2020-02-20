using System;

namespace SortDates.ConsoleApp
{
    class Application : BaseLog, IApplication
    {
        IDateCheckService _dateCheckService;

        public Application(IDateCheckService dateCheckService)
        {
            _dateCheckService = dateCheckService;
        }

        public void Run(DateTime[] datesToCompareArray)
        {
            _dateCheckService.SortDates(datesToCompareArray);

            if (HasMessages())
            {
                foreach (var logMessage in GetMessages())
                {
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine($"RESULT: {(logMessage.message)}");
                    Console.WriteLine("----------------------------------------------");
                }

            }            
        }
    }
}
