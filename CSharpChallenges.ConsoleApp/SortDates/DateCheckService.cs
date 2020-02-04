using System;

namespace SortDates.ConsoleApp
{
    class DateCheckService : BaseLog
    {
        public void sortDates(DateTime[] datesToCompare)
        {
            Array.Sort(datesToCompare);
            string result = ""; 
            foreach (DateTime date in datesToCompare)
            {
                //Console.WriteLine(date.Date);
                //if (datesToCompare.IndexOf(1))
                    result += date.ToString("dd/MM/yy") + ", "; 
            }

            ListLogs.Add(new LogMessage(101, $"THE SORT FROM THE LOWER / LARGEST DATE IS: {result}."));
        }
    }
}
