using System;

namespace SortDates.ConsoleApp
{
    class DateCheckService : BaseLog
    {
        public void SortDates(DateTime[] datesToCompare)
        {
            Array.Sort(datesToCompare);
            string result = "";
            
            foreach (DateTime date in datesToCompare)
            {
                //Console.WriteLine(date.Date);
                //if (datesToCompare.IndexOf(1))
                result += date.ToString("dd/MM/yy") + ", "; 
            }

            ListLogs.Add(new LogMessage(Enums.CodeMessageEnum.RESULT, $":{Resource1.SORT_FROM} {result}."));
        }
    }
}
