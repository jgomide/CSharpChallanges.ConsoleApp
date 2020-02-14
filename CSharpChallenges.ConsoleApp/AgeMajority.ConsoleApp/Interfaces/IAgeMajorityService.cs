namespace AgeMajority.ConsoleApp.Interfaces
{
    public interface IAgeMajorityService : IBaseLog
    {
        void CheckAge(string input);
    }
}