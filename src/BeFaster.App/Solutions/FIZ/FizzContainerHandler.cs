using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFaster.App.Solutions.FIZ
{
    public class FizzContainerHandler : AbstractHandler
    {
        public override string Handle(int number)
        {
            if (Convert.ToString(number).IndexOf('3') >= 0)
            {
                return "fizz";
            }
            else
            {
                return base.Handle(number);
            }
        }
    }
}

