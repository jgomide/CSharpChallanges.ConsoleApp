using System;
using System.Collections.Generic;
using System.Text;

namespace SortDates.ConsoleApp
{
    static class Utilities
    {
        public static string dateCount(int inputCount)
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
