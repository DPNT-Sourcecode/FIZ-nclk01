using System;

namespace BeFaster.App.Solutions.FIZ
{
    public class DeluxeHandler : AbstractHandler
    {
        public override string Handle(int number)
        {
            if(
                ((number % 3 == 0) && (Convert.ToString(number).IndexOf('3') >= 0)) ||
                ((number % 5 == 0) && (Convert.ToString(number).IndexOf('5') >= 0))
              )
            {
                return "deluxe";
            }
            else
            {
                return base.Handle(number);
            }
        }
    }

}
