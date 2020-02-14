using System;
using System.Linq;
using AgeMajority.ConsoleApp.Interfaces;
using AgeMajority.ConsoleApp.Validations;


namespace AgeMajority.ConsoleApp
{
    class Application : BaseLog, IApplication 
    {
        IAgeMajorityService _ageMajorityService;

        public Application(IAgeMajorityService ageMajorityService)
        {
            _ageMajorityService = ageMajorityService;
        }

        public void Run(string input)
        {
            _ageMajorityService.CheckAge(input);

            if (_ageMajorityService.ListLogs.Any())
            {
                foreach (var logMessage in _ageMajorityService.ListLogs)
                {
                    Console.WriteLine($"INPUT: {input} RESULT: {(logMessage.message)}");

                    //Console.WriteLine($"Error number: {EnumExtension.GetDescription(logMessage.message)}");
                }

                _ageMajorityService.ListLogs.Clear();
            }
        }
    }
}
