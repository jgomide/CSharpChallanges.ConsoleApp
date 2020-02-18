using MajorMinorNumber.ConsoleApp.Resources;
using System.Collections.Generic;
using System.Linq;

namespace MajorMinorNumber.ConsoleApp
{
    class NumbersService : BaseLog, INumbersService
    {
        private readonly IValidation _validations;

        public NumbersService(IValidation validations)
        {
            _validations = validations;
        }

        public void Calculate(string input)
        {
            int higherNumber = -1001;
            int sameNumber = -1001;

            var isValid = _validations.ValidateInput(input);

            var listResult = _validations.GetListNumbers(input);

            if (isValid)
            {
                foreach (int number in listResult)
                {
                    //check if both numbers are the same 
                    if (higherNumber == number)
                        sameNumber = number;

                    //check wich number is bigger
                    if (higherNumber < number)
                        higherNumber = number;
                }

                if (sameNumber != -1001)
                    AddLogMessage($"{Messages.BOTH_NUMBERS_ARE_SAME} ({higherNumber})");
                else
                    AddLogMessage($"{higherNumber} {Messages.IS_THE_BIGGEST_NUMBER}");
            }
        }
    }
}
