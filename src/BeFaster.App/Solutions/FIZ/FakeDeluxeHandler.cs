using System;

namespace BeFaster.App.Solutions.FIZ
{
    public class FakeDeluxeHandler : AbstractHandler
    {
        public override string Handle(int number)
        {
            if (
                (
                    ((number % 3 == 0) && (Convert.ToString(number).IndexOf('3') >= 0)) ||
                    ((number % 5 == 0) && (Convert.ToString(number).IndexOf('5') >= 0))
                )
                &&
                (number % 2 == 1)
                )
            {
                return "fake deluxe";
            }
            else
            {
                return base.Handle(number);
            }
        }
    }

}
