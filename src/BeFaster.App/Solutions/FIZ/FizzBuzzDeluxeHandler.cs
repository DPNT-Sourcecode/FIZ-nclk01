using System;

namespace BeFaster.App.Solutions.FIZ
{
    public class FizzBuzzDeluxeHandler : AbstractHandler
    {
        public override string Handle(int number)
        {
            if (
                (   // fizz buzz
                    (Convert.ToString(number).IndexOf('3') >= 0 && Convert.ToString(number).IndexOf('5') >= 0) ||
                    (Convert.ToString(number).IndexOf('3') >= 0 && (number % 5) == 0) ||
                    (Convert.ToString(number).IndexOf('5') >= 0 && (number % 3) == 0)
                ) && 
                (   // delux
                    (number % 11 == 0) ||
                    (number % 111 == 0) ||
                    (number % 1111 == 0)
                )
               )
            {
                return "fizz buzz deluxe";
            }
            else
            {
                return base.Handle(number);
            }
        }
    }

}
