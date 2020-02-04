using System;


namespace SortDates.ConsoleApp
{
    class DateCheckAppService : BaseLog
    {
        public static DateTime convertDate(string dateInput)
        {
            DateTime dateValue;
            DateTime.TryParse(dateInput, out dateValue);
            return dateValue;



            /*if (!DateTime.TryParse(dateInput, out dateValue))
                Console.WriteLine(dateValue);
            else
                Console.WriteLine("ERROR Convert Date");*/
        }
        public bool isDateTime (string dateInput)
        {
            DateTime dateValue;
            if (!DateTime.TryParse(dateInput, out dateValue))
                ListLogs.Add(new LogMessage(201, "Format incorrect, please insert a valid date."));
            return DateTime.TryParse(dateInput, out dateValue);



            /*if (!DateTime.TryParse(dateInput, out dateValue))
                Console.WriteLine(dateValue);
            else
                Console.WriteLine("ERROR Convert Date");*/
        }
    }
}
