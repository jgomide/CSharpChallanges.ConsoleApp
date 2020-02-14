using System.Collections.Generic;
using System.Linq;

namespace AgeMajority.ConsoleApp.Validations
{
    public abstract class BaseLog
    {
        public abstract int NumberOfSides(int a, int b);

        private static List<LogMessage> ListLogs { get; set; } = new List<LogMessage>();

        public void AddLogMessage(string message)
        {
            ListLogs.Add(new LogMessage(message));
        }

        public void AddLogMessageRange(List<LogMessage> logMessages)
        {
            ListLogs.AddRange(logMessages);
        }

        public List<LogMessage> GetMessages()
        {
            return ListLogs;
        }

        public bool HasMessages()
        {
            return ListLogs.Any();
        }

        public void CleanMessages()
        {
            ListLogs.Clear();
        }
    }
}
