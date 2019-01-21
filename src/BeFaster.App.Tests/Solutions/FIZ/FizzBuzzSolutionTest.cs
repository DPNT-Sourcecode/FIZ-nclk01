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

        [TestCase(50, ExpectedResult = "buzz")]
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



        [TestCase(513, ExpectedResult = "fizz buzz")]
        public string FizzBuzzContainerTest(int number)
        {
            return FizzBuzzSolution.FizzBuzz(number);
        }


        [TestCase(546, ExpectedResult = "fizz buzz")]
        public string FizzBuzzByContainerFizzByDivisibleBuzzTest(int number)
        {
            return FizzBuzzSolution.FizzBuzz(number);
        }

        [TestCase(325, ExpectedResult = "fizz buzz")]
        public string FizzBuzzByContainerBuzzByDivisibleFizzTest(int number)
        {
            return FizzBuzzSolution.FizzBuzz(number);
        }


        [TestCase(31, ExpectedResult = "fizz")]
        public string FizzContainerTest(int number)
        {
            return FizzBuzzSolution.FizzBuzz(number);
        }


        [TestCase(52, ExpectedResult = "buzz")]
        public string BuzzContainerTest(int number)
        {
            return FizzBuzzSolution.FizzBuzz(number);
        }


    }

}
