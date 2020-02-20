using SortDates.ConsoleApp.Resources;

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
        public static bool IsDateTime(this string dateInput)
        {
            var isValid = DateTime.TryParse(dateInput, out _);

            if (!isValid)
            {
                //AddLogMessage(new LogMessage(Messages.INVALID_DATE));
            }

            return isValid;
        }
    }
}
