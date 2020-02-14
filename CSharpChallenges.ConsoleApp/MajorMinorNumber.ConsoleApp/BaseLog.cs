using System.Collections.Generic;

namespace MajorMinorNumber.ConsoleApp
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
