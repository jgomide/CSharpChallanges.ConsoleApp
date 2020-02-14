using System.Collections.Generic;
using System.Linq;

namespace MajorMinorNumber.ConsoleApp
{
    class NumbersService : BaseLog
    {
        int higherNumber = -1001;
        int sameNumber = -1001;
        public void Calculate(List<int> listNumbers)
        {
            //check if the list exists or any problem occurred before
            if ((listNumbers != null) && (listNumbers.Any()))
            {
                foreach (int number in listNumbers)
                {
                    //check if both numbers are the same 
                    if (higherNumber == number)
                        sameNumber = number;

                    //check wich number is bigger
                    if (higherNumber < number)
                        higherNumber = number;                    
                }                
                if (sameNumber != -1001)
                    ListLogs.Add(new LogMessage(102, $"Both numbers are the same ({higherNumber})."));
                else
                    ListLogs.Add(new LogMessage(101, $"{higherNumber} is the biggest number."));
                
            }
            else
            {
                ListLogs.Add(new LogMessage(205, "ListNumbers is empty."));
            }
        }
    }
}
