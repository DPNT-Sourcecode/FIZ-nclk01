using System;

namespace BeFaster.App.Solutions.FIZ
{
    public class BuzzFakeDeluxeHandler : AbstractHandler
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
                &&  // buzz
                (number % 5 == 0)
                )
            {
                return "buzz fake deluxe";
            }
            else
            {
                return base.Handle(number);
            }
        }
    }

}
