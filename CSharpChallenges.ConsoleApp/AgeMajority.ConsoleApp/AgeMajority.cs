using System;
using System.Collections.Generic;
using System.Text;

namespace AgeMajority.ConsoleApp
{
    public static class AgeMajority
    {
        public static string CheckAge(int age)
        {
            if (isValidatAge(age))
            {
                if (age < 18 )
                    return $"The Age {age} is still minor Age.";
                else
                    return $"The Age {age} is already majority Age.";
            } else
                return "Age needs to be less tem 200 years.";                        
        }

        private static bool isValidatAge(int age)
        {
            if (age > 200) 
                return false;
            else 
                return true;
        }        
    }
}

