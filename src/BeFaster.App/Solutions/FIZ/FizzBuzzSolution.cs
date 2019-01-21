using System;

namespace BeFaster.App.Solutions.FIZ
{
    public static class FizzBuzzSolution
    {
        public static string FizzBuzz(int number)
        {
            string message = string.Empty;

            if (number % 3 == 0 && number % 5 == 0)
            {
                message = "fizz buzz";
            }
            else if (number % 3 == 0)
            {
                message = "fizz";
            }
            else if (number % 5 == 0)
            {
                message = "buzz";
            }
            else
            {
                message = Convert.ToString(number);
            }
            return message;
        }
    }
}

