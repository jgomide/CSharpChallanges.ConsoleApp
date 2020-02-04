using System.Collections.Generic;

namespace SortDates.ConsoleApp
{
    public class BaseLog
    {
        //ListLogs used in all classes to carry the errors/results
        public List<LogMessage> ListLogs { get; set; } = new List<LogMessage>();

        /*public BaseLog(int ListcodMessage)
        {

        }*/
    }
}
