using SortDates.ConsoleApp.Enums;
using System;


namespace SortDates.ConsoleApp
{
    //class DateCheckAppService : BaseLog
    //{
    //    public static DateTime convertDate(string dateInput)
    //    {
    //        DateTime dateValue;
    //        DateTime.TryParse(dateInput, out dateValue);
    //        return dateValue;
    //    }
    //    public bool isDateTime (string dateInput)
    //    {
    //        DateTime dateValue;
    //        if (!DateTime.TryParse(dateInput, out dateValue))
    //            ListLogs.Add(new LogMessage(201, "Format incorrect, please insert a valid date."));
    //        return DateTime.TryParse(dateInput, out dateValue);
    //    }
    //}

    public class DateCheckAppService : BaseLog
    {
        public static DateTime ConvertDate(string dateInput)
        {
            DateTime dateValue;
            DateTime.TryParse(dateInput, out dateValue);
            return dateValue;
        }
        public bool IsDateTime(string dateInput)
        {
            var isValid = DateTime.TryParse(dateInput, out _);

            if (!isValid)
            {
                ListLogs.Add(new LogMessage(CodeMessageEnum.INVALID_DATE, "Format incorrect, please insert a valid date."));
            }           

            return isValid;
        }
    }
}
