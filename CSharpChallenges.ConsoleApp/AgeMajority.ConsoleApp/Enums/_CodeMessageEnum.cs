using System.ComponentModel;

namespace AgeMajority.ConsoleApp.Enums
{
   public enum _CodeMessageEnum
    {
        [Description("Age can't be more than 0")]
        AGE_CANT_BE_LESS_THAN_ZERO = 0,

        [Description("Is still minor Age")]
        IS_STILL_MINOR_AGE = 1,

        [Description("Is already majority Age")]
        IS_ALREADY_MAJORITY_AGE = 2,

        [Description("Age can't be more than 200")]
        AGE_CANT_BE_MORE_THAN_200 = 3,

        [Description("Input Format Incorrect, digit only numbers")]
        INPUT_FORMAT_INCORRECT = 4,

        [Description("Enter a age or 'q' to quit")]
        ENTER_AGE_OR_PRESS_Q_QUIT = 5
            
    }
}


