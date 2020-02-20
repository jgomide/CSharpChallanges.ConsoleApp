using SortDates.ConsoleApp.Resources;
using System;

namespace SortDates.ConsoleApp
{
    class DateCheckService : BaseLog, IDateCheckService
    {
        public void SortDates(DateTime[] datesToCompare)
        {
            Array.Sort(datesToCompare);
            string result = "";

            foreach (DateTime date in datesToCompare)
            {             
                result += date.ToString("dd/MM/yy") + ", ";
            }

            AddLogMessage($"{Messages.SORT_DATE_SEQUENCE} {result}.");
        }
    }
}
