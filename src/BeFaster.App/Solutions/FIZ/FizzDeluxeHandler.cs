using System;

namespace BeFaster.App.Solutions.FIZ
{
    public class FizzDeluxeHandler : AbstractHandler
    {
        public override string Handle(int number)
        {
            if (
                (   // delux
                    (number % 11 == 0) ||
                    (number % 111 == 0) ||
                    (number % 1111 == 0)
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
