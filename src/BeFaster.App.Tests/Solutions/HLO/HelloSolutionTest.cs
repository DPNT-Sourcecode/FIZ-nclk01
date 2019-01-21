using BeFaster.App.Solutions.HLO;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFaster.App.Tests.Solutions.HLO
{
    [TestFixture]
    public class HelloSolutionTest
    {
        [TestCase("Craftsman", ExpectedResult = "Hello, World!")]
        public string ComputeSum(string friendName)
        {
            return HelloSolution.Hello(friendName);
        }
    }
}

