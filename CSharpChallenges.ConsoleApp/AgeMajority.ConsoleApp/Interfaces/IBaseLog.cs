using AgeMajority.ConsoleApp.Validations;
using System.Collections.Generic;

namespace AgeMajority.ConsoleApp.Interfaces
{
    public interface IBaseLog
    {
        List<LogMessage> ListLogs { get; set; }
    }
}