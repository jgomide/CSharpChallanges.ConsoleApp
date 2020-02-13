using System;

namespace SortDates.ConsoleApp
{
    public static class DateConvertExtension
    {
        /// <summary>
        /// ConvertDate
        /// </summary>
        /// <param name="dateInput">String</param>
        /// <returns></returns>
        public static DateTime ConvertDate(this string dateInput)
        {
            DateTime dateValue;
            DateTime.TryParse(dateInput, out dateValue);
            return dateValue;
        }

        /// <summary>
        /// IsDateTime
        /// </summary>
        /// <param name="dateInput">String</param>
        /// <param name="dateCheckAppService">DateCheckAppService</param>
        /// <returns></returns>
        public static bool IsDateTime(this string dateInput, DateCheckAppService dateCheckAppService)
        {
            var isValid = DateTime.TryParse(dateInput, out _);

            if (!isValid)
            {
                dateCheckAppService.ListLogs.Add(new LogMessage(Enums.CodeMessageEnum.INVALID_DATE, "Format incorrect, please insert a valid date."));
            }

            return isValid;
        }
    }
}
