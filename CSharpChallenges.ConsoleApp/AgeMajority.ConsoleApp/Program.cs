using AgeMajority.ConsoleApp.Enums;
using AgeMajority.ConsoleApp.Services;
using System;
using AgeMajority.ConsoleApp.Extensions;
using AgeMajority.ConsoleApp.Resources;
using System.Linq;

namespace AgeMajority.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {       
            AgeMajorityService ageMajorityService = new AgeMajorityService();

            while (true)
            {
                //Console.WriteLine(_EnumExtension.GetDescription(_CodeMessageEnum.ENTER_AGE_OR_PRESS_Q_QUIT));
                Console.WriteLine(Messages.ENTER_AGE_OR_PRESS_Q_QUIT);
                var input = Console.ReadLine();
                
                if (input == "q")
                {
                    break;
                    //continue;
                }

                try
                {
                    ageMajorityService.CheckAge(input);

                    if (ageMajorityService.ListLogs.Any())
                    {
                        foreach (var logMessage in ageMajorityService.ListLogs)
                        {
                            Console.WriteLine($"INPUT: {input} RESULT: {(logMessage.message)}");

                            //Console.WriteLine($"Error number: {EnumExtension.GetDescription(logMessage.message)}");
                        }

                        ageMajorityService.ListLogs.Clear();
                    }                    
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
