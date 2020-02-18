using System.Collections.Generic;

namespace MajorMinorNumber.ConsoleApp
{
    public interface IValidation
    {
        List<int> GetListNumbers(string input);
        bool ValidateInput(string input);        
    }
}