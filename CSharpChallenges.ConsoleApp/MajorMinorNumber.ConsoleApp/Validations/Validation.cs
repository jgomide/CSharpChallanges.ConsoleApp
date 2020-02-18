using MajorMinorNumber.ConsoleApp.Resources;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace MajorMinorNumber.ConsoleApp
{
    public class Validation : BaseLog, IValidation
    {
        public bool ValidateInput(string input)
        {
            var listResult = GetListNumbers(input);

            if (listResult.Any())
            {
                if (IsLessThanTwoNumbers(listResult))
                {
                    AddLogMessage(Messages.IT_HAS_LESS_THAN_2_NUMBERS);
                    return false;
                }

                if (IsMoreThanTwoNumbers(listResult))
                {
                    AddLogMessage(Messages.IT_HAS_MORE_THAN_2_NUMBERS);
                    return false;
                }

                if (IsNumberBiggerThan1000(listResult))
                {
                    return false;
                }

                if (IsNumberSmallerThanMinus1000(listResult))
                {
                    return false;
                }
            }
            else
            {
                AddLogMessage(Messages.LISTNUMBERS_IS_EMPTY);
                return false;
            }

            return true;
        }

        public List<int> GetListNumbers(string input)
        {
            List<int> listNumbers = new List<int>();

            //get all numbers in the string 
            string[] digits = Regex.Split(input, @"\D+");

            //create a list with the numbers
            foreach (string value in digits)
            {
                int number;
                if (int.TryParse(value, out number))
                {
                    listNumbers.Add(number);
                }
            }

            return listNumbers;
        }

        public bool IsNumberSmallerThanMinus1000(List<int> listResult)
        {
            int errorCount = 0;

            foreach (int number in listResult)
            {
                if (number < -1000)
                {
                    AddLogMessage($"{number} {Messages.IS_SMALLER_THAN_MINUS_1000}");

                    errorCount += 1;
                }
            }

            return errorCount > 0;
        }

        public bool IsNumberBiggerThan1000(List<int> listResult)
        {
            int errorCount = 0;

            

            foreach (int number in listResult)
            {
                if (number > 1000)
                {
                    AddLogMessage($"{number} {Messages.IS_BIGGER_THAN_1000}");

                    errorCount += 1;
                    System.Console.WriteLine($"Test1 {errorCount} {number}");
                }
            }

            

            return (errorCount > 0);
        }


        public bool IsLessThanTwoNumbers(List<int> listResult)
        {
            return listResult.Count < 2;
        }

        public bool IsMoreThanTwoNumbers(List<int> listResult)
        {
            return listResult.Count > 2;
        }
    }
}

