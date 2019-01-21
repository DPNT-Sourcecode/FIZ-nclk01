using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFaster.App.Solutions.FIZ
{
    public class FizzBuzzHandler : AbstractHandler
    {
        public override string Handle(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
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
