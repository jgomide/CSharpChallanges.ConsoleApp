using AgeMajority.ConsoleApp.Resources;
using System;

namespace AgeMajority.ConsoleApp.Validations
{
    class Validations : BaseLog
    {
        public bool ValidateInput(string input)
        {            
            if (IsValidInputFormat(input))
            {
                var age = int.Parse(input);

                if (IsAgeOverMaxAllowed(age))
                {                    
                    ListLogs.Add(new LogMessage(Messages.AGE_CANT_BE_MORE_THAN_200));
                    return false;                   
                }

                if (IsAgeUnderMinAllowed(age))
                {
                    ListLogs.Add(new LogMessage(Messages.AGE_CANT_BE_LESS_THAN_ZERO));
                    return false;
                }

                return true;
            }
            else
            {
                ListLogs.Add(new LogMessage(Messages.INPUT_FORMAT_INCORRECT));
                return false;
            }            
        }

        private bool IsValidInputFormat(string input)
        {
            return int.TryParse(input, out _); ;
        }
        
        private bool IsAgeOverMaxAllowed(int age)
        {
            return age > 200;
        }

        private bool IsAgeUnderMinAllowed(int age)
        {
            return age < 0;
        }
    }
}
