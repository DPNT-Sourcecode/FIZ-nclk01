using System;

namespace BeFaster.App.Solutions.FIZ
{
    public class FizzBuzzDeluxeHandler : AbstractHandler
    {
        public override string Handle(int number)
        {
            if (
                (   // delux
                     (Convert.ToString(number).IndexOf('3') >= 0) ||
                     (Convert.ToString(number).IndexOf('5') >= 0)
                )
                &&
                (   // fizz buzz
                    (number % 3 == 0 && number % 5 == 0)
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
