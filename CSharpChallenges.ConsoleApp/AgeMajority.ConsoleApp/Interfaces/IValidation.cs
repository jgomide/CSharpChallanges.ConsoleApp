
namespace AgeMajority.ConsoleApp.Interfaces
{
    public interface IValidation : IBaseLog
    {
        bool ValidateInput(string input);
        /*bool IsValidInputFormat(string input);
        bool IsAgeOverMaxAllowed(int age);
        bool IsAgeUnderMinAllowed(int age);*/
    }
}