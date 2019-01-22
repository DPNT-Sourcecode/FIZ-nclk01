using System;

namespace BeFaster.App.Solutions.FIZ
{
    public class FizzDeluxeHandler : AbstractHandler
    {
        public override string Handle(int number)
        {
            if (    // deluxe
                (
                    ((number % 3 == 0) && (Convert.ToString(number).IndexOf('3') >= 0)) ||
                    ((number % 5 == 0) && (Convert.ToString(number).IndexOf('5') >= 0))
                )
                &&
                (   // fizz
                    (number % 3 == 0)
                )
               )
            {
                return "fizz deluxe";
            }
            else
            {
                return base.Handle(number);
            }
        }
    }

}
