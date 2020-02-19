using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SoftwareTechChallenge.Helper;

namespace SoftwareTechChallenge.Controller
{
    /// <summary>
    /// This is an API Controller which is used to take input from clients and send response to client after checking either the input is multiple of 3 or 5
    /// </summary>
    public class TechChallengeController : ApiController
    {
        /// <summary>
        /// This method get input from client and use MultipleCheckerHelper class to process
        /// </summary>
        /// <param name="id">Input from client</param>
        /// <returns>It return PE if input is multiple of 3 and 5, return E if input is multiple of 5, return P if input is multiple of 5, return input as string if number is not a multilpe of 3 and 5   </returns>
        public IHttpActionResult Get(string id)
        {
            // Create an instance of MultipleCheckerHelper
            MultipleCheckerHelper multipleCheckerHelper = new MultipleCheckerHelper();
            string returnMessage = "";
            // if client did not send input while requesting the API method, system send incorrect format message
            if (string.IsNullOrWhiteSpace(id))
                returnMessage = "Input is not in correct format";
            else if (!id.All(char.IsDigit))
            {
                returnMessage = "Input must be a string";
            }
            else
            {
                int number = Convert.ToInt32(id);
                if (multipleCheckerHelper.IsMultipleOfFiveAndThree(number))
                    returnMessage = "PE";
                else if (multipleCheckerHelper.IsMultipleOfNumber(number, 5))
                    returnMessage = "E";
                else if (multipleCheckerHelper.IsMultipleOfNumber(number, 3))
                    returnMessage = "P";
                else
                    returnMessage = number.ToString();

            }
            return Json(returnMessage);
        }
    }
}
