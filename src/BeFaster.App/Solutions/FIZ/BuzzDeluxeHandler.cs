using System;

namespace BeFaster.App.Solutions.FIZ
{
    public class BuzzDeluxeHandler : AbstractHandler
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
                (   // buzz
                    (number % 5 == 0)
                )
               )
            {
                return "buzz deluxe";
            }
            else
            {
                return base.Handle(number);
            }
        }
    }

}

