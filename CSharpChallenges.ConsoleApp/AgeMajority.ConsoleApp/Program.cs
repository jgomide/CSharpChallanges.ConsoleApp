using System;

namespace AgeMajority.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a age or 'q' to quit");
                var input = Console.ReadLine();
                
                if (input == "q")
                {
                    break;
                    //continue;
                }

                try
                {
                    int age = Int32.Parse(input);
                    
                    if (age < 0)
                    {
                        throw new System.ArgumentException("Age cannot be less tem 0", "original");
                    }

                    string result = AgeMajority.CheckAge(age);
                    Console.WriteLine(result);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    //throw;    
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Age needs to be numeric.");
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
