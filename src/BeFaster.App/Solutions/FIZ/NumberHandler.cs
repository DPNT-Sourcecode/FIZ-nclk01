using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFaster.App.Solutions.FIZ
{
    public class NumberHandler : AbstractHandler
    {
        public override string Handle(int number)
        {
            return Convert.ToString(number);
        }
    }

}
