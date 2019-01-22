using System;

namespace BeFaster.App.Solutions.FIZ
{
    public class FizzFakeDeluxeHandler : AbstractHandler
    {
        public override string Handle(int number)
        {
            if (
                (   // deluxe
                    ((number % 3 == 0) && (Convert.ToString(number).IndexOf('3') >= 0)) ||
                    ((number % 5 == 0) && (Convert.ToString(number).IndexOf('5') >= 0))
                )
                &&  // fake
                (number % 2 == 1)
                &&  // fizz
                (number % 3 == 0)
                )
            {
                return "fizz fake deluxe";
            }
            else
            {
                return base.Handle(number);
            }
        }
    }

}
