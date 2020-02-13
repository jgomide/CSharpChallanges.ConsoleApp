using System.Collections.Generic;

namespace AgeMajority.ConsoleApp.Validations
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
