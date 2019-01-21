using System;

namespace BeFaster.App.Solutions.FIZ
{
    public class FizzBuzzContainerHandler : AbstractHandler
    {
        public override string Handle(int number)
        {
            if (Convert.ToString(number).IndexOf('5') > 0)
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
