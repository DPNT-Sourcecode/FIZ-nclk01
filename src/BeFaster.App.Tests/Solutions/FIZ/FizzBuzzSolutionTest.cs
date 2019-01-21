using System;
using BeFaster.App.Solutions.FIZ;
using NUnit.Framework;

namespace BeFaster.App.Tests.Solutions.FIZ
{
    [TestFixture]
    public class FizzBuzzSolutionTest
    {
        [TestCase(36, ExpectedResult = "fizz")]
        public string FizzTest(int number)
        {
            return FizzBuzzSolution.FizzBuzz(number);
        }

        [TestCase(35, ExpectedResult = "buzz")]
        public string BuzzTest(int number)
        {
            return FizzBuzzSolution.FizzBuzz(number);
        }


        [TestCase(90, ExpectedResult = "fizz buzz")]
        public string FizzBuzzTest(int number)
        {
            return FizzBuzzSolution.FizzBuzz(number);
        }


        [TestCase(7, ExpectedResult = "7")]
        public string NumberTest(int number)
        {
            return FizzBuzzSolution.FizzBuzz(number);
        }



        // [TestCase(7, ExpectedResult = "7")]
        [Test]
        public void ChainOfResponsibilityTest()
        {
            TestProgram.Test();
        }


    }

}
