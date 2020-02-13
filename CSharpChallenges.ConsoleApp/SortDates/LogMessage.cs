using SortDates.ConsoleApp.Enums;

namespace SortDates.ConsoleApp
{
    public class LogMessage
    {
        public int codeMessage;
        public string message;


        public LogMessage(CodeMessageEnum codeMessage, string Message)
        {
            this.codeMessage = (int)codeMessage;
            this.message = Message;
        }
    }
}

