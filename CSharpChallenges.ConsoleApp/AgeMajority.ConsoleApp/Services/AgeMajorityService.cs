using AgeMajority.ConsoleApp.Resources;
using AgeMajority.ConsoleApp.Validations;


namespace AgeMajority.ConsoleApp.Services
{
    public class AgeMajorityService : BaseLog 
    {

        private readonly Validations.Validations _basicValidations;

        public AgeMajorityService()
        {
            _basicValidations = new Validations.Validations();
        }

        public void CheckAge(string input)
        {   
            var isValid = _basicValidations.ValidateInput(input);
            
            
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
                this.ListLogs.AddRange(_basicValidations.ListLogs);
                _basicValidations.ListLogs.Clear();
            }

            
        }
    }
}

