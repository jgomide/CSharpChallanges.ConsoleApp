using AgeMajority.ConsoleApp.Resources;
using AgeMajority.ConsoleApp.Interfaces;
using AgeMajority.ConsoleApp.Validations;


namespace AgeMajority.ConsoleApp.Services
{
    public class AgeMajorityService : BaseLog, IAgeMajorityService
    {

        IValidation _validations;

        //matozinhoehocara

        public AgeMajorityService(IValidation validations)
        {
            _validations = validations;
        }
        
        public void CheckAge(string input)
        {
            var isValid = _validations.ValidateInput(input);


            if (isValid)
            {
                var age = int.Parse(input);

                if (age < 18)
                    this.ListLogs.Add(new LogMessage(Messages.IS_STILL_MINOR_AGE));
                else
                    this.ListLogs.Add(new LogMessage(Messages.IS_ALREADY_MAJORITY_AGE));
            }
            else
            {
                this.ListLogs.AddRange(_validations.ListLogs);
                _validations.ListLogs.Clear();
            }
        }
    }
}

