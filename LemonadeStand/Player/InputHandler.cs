using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class InputHandler
    {

        public bool InputValidation(List<string> acceptedOptions, string playerInput)
        {
            if (acceptedOptions.Contains(playerInput))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool InputValidationNumber(string input)
        {
            int returnTry;
            if (!int.TryParse(input, out returnTry)){
                return false;
            }
            return true;
        }
      
    }
}
