using System;

namespace BeFaster.App.Solutions.FIZ
{
    public class FizzBuzzFakeDeluxeHandler : AbstractHandler
    {
        public override string Handle(int number)
        {
            if (
                (   // delux
                    (number % 11 == 0) ||
                    (number % 111 == 0) ||
                    (number % 1111 == 0)
                )
                &&  // fake
                (number % 2 == 1)
                &&
                (   // fizz buzz
                    (number % 3 == 0 && number % 5 == 0)
                )
               )
            {
                return "fizz buzz fake deluxe";
            }
            else
            {
                return base.Handle(number);
            }
        }
    }

}
