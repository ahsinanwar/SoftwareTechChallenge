using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftwareTechChallenge.Helper
{
    public class MultipleCheckerHelper
    {
        /// <summary>
        /// This method checks the input, if input is multiple of 3 and 5 then it return true
        /// </summary>
        /// <param name="input">input from API method which is an integer number</param>
        /// <returns>return true if input is multiple of 3 and 5</returns>
        public bool IsMultipleOfFiveAndThree(int input)
        {
            if (input % 3 == 0 && input % 5 == 0)
                return true;
            else
                return false;
        }
        /// <summary>
        /// This method checks the input, if input is multiple of provided number
        /// </summary>
        /// <param name="input">input from API method which is an integer number</param>
        /// <param name="multiple">multiple is an integer number which will be used as a multiplier</param>
        /// <returns>return true if input is multiple of provided multiple parameter</returns>
        public bool IsMultipleOfNumber(int input,int multiple)
        {
            if (input % multiple == 0)
                return true;
            else
                return false;
        }
    }
}