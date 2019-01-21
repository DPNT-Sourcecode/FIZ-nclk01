using System;

namespace BeFaster.App.Solutions.FIZ
{
    public class FizzBuzzContainerHandler : AbstractHandler
    {
        public override string Handle(int number)
        {
            if ((Convert.ToString(number).IndexOf('3') >= 0 && Convert.ToString(number).IndexOf('5') >= 0) ||
                (Convert.ToString(number).IndexOf('3') >= 0 && (number % 5) == 0) ||
                (Convert.ToString(number).IndexOf('5') >= 0 && (number % 3) == 0)
                )
            {
                return "fizz buzz";
            }
            else
            {
                return base.Handle(number);
            }
        }
    }
}

