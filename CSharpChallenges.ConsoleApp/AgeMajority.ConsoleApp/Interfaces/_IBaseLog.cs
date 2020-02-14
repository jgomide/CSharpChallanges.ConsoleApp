using AgeMajority.ConsoleApp.Validations;
using System.Collections.Generic;

namespace AgeMajority.ConsoleApp.Interfaces
{
    public interface _IBaseLog
    {
        List<LogMessage> ListLogs { get; set; }
    }
}