using System;
using System.Resources;


namespace GenericTest.ConsoleApp
{
    class Example
    {
        public enum DayofWeek
        {
            Sunday = 1, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday,
        }



        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello World!");

            Console.WriteLine(DateTime.Now.ToString("dd/MM/yy"));

            Console.WriteLine("Day of week {0} {1}", (int)DayofWeek.Sunday, DayofWeek.Sunday);

            Console.WriteLine("Day of week {0} {1}", (int)DayofWeek.Sunday, DayofWeek.Sunday);
            Console.WriteLine("Day of week {0} {1}", (int)DayofWeek.Monday, DayofWeek.Monday);
            Console.WriteLine("Day of week {0} {1}", (int)DayofWeek.Tuesday, DayofWeek.Tuesday);
            Console.WriteLine("Day of week {0} {1}", (int)DayofWeek.Wednesday, DayofWeek.Wednesday);
            Console.WriteLine("Day of week {0} {1}", (int)DayofWeek.Thursday, DayofWeek.Thursday);
            Console.WriteLine("Day of week {0} {1}", (int)DayofWeek.Friday, DayofWeek.Friday);
            Console.WriteLine("Day of week {0} {1}", (int)DayofWeek.Saturday, DayofWeek.Saturday);
            Console.ReadLine();*/

            //New Global.System.Resources.ResourceManager(Reflection.Assembly.GetCallingAssembly.GetName.Name & ".CommonNameOf.Resources", Reflection.Assembly.GetCallingAssembly())

            ResourceManager rm = new ResourceManager("greetingresources", typeof(Example).Assembly);


            Console.WriteLine(rm.BaseName)  ;

            Console.Write(rm.GetString("jeferson"));

            var input = Console.ReadLine();

            Console.Write(rm.GetString("test"));


            //string name = Console.ReadLine();
            //Console.WriteLine(rm.GetString("greeting"), name);
            // The example displays output like the following:
            //       Enter your name: Wilberforce
            //       Hello, Wilberforce!



        }
}
}
