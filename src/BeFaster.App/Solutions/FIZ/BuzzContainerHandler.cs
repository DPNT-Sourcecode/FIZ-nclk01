using System;

namespace BeFaster.App.Solutions.FIZ
{
    public class BuzzContainerHandler : AbstractHandler
    {
        public override string Handle(int number)
        {
            if (Convert.ToString(number).IndexOf('5') >= 0)
            {
                return "buzz";
            }
            else
            {
                return base.Handle(number);
            }
        }
    }
}
