using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MajorMinorNumber.ConsoleApp
{
    public class NumberAppService : BaseLog
        
    {
        private readonly NumbersService _numbersService;        

        public NumberAppService()
        {
            _numbersService = new NumbersService();
        }

        public void ValidateNumbers(string input)
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

            //validate if has at least 2 numbers 
            if (listNumbers.Count < 2)
            {
                ListLogs.Add(new LogMessage(201, "It has less than 2 numbers."));
            }
            else
            {
                //validate if we get more than 2 numbers
                if (listNumbers.Count > 2)
                {
                    ListLogs.Add(new LogMessage(202, "It has more than 2 numbers."));

                }
                else
                {
                    //validate if the numbers are max 1000 and min -1000
                    foreach (int number in listNumbers)
                    {
                        if (number > 1000)
                        {
                            ListLogs.Add(new LogMessage(203, $"{number} is bigger than 1000. Number Max 1000."));
                        }
                        else
                        {
                            if (number < -1000)
                                ListLogs.Add(new LogMessage(204, $"{number} is smaller than -1000. Number Min -1000."));
                        }
                    }
                }
            }

            if (ListLogs.Count == 0)
            {                
                _numbersService.Calculate(listNumbers);
                ListLogs.AddRange(_numbersService.ListLogs);
            }


            /*foreach (int number in listNumbers)
            {
                Console.WriteLine(number);
            }*/
        }

    }
}
