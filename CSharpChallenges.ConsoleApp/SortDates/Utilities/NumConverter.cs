
namespace SortDates.ConsoleApp
{
    static class NumConverter
    {
        public enum DateSeq
        {
            first=1, second=2, third=3
        }
        public static string LiteralNumConverter(int inputCount)
        {
            if (inputCount == 0) return "FIRST";
            else if (inputCount == 1) return "SECOND";
            else if (inputCount == 2) return "THIRD";
            else if (inputCount == 3) return "QUATRO";
            else if (inputCount == 4) return "CINCO";
            else return "ERROR";
        }
        
    }
}
