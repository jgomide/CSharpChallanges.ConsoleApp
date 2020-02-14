using System;
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
