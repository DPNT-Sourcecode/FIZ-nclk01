using System;

namespace BeFaster.App.Solutions.FIZ
{
    public class FizzBuzzDeluxHandler : AbstractHandler
    {
        public override string Handle(int number)
        {
            if (
                (
                    (Convert.ToString(number).IndexOf('3') >= 0 && Convert.ToString(number).IndexOf('5') >= 0) ||
                    (Convert.ToString(number).IndexOf('3') >= 0 && (number % 5) == 0) ||
                    (Convert.ToString(number).IndexOf('5') >= 0 && (number % 3) == 0)
                ) && 
                (
                    (number % 11 == 0) ||
                    (number % 111 == 0) ||
                    (number % 1111 == 0)
                )
               )
            {
                return "deluxe";
            }
            else
            {
                return base.Handle(number);
            }
        }
    }

}

