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


        // Delux tests

        [TestCase(9, ExpectedResult = "fizz")]
        public string BuzzNoDeluxeNumberLessThan10Test(int number)
        {
            return FizzBuzzSolution.FizzBuzz(number);
        }
        

        [TestCase(77, ExpectedResult = "deluxe")]
        public string DeluxeLessThan100Test(int number)
        {
            return FizzBuzzSolution.FizzBuzz(number);
        }

        [TestCase(8888, ExpectedResult = "deluxe")]
        public string DeluxeLessThan10000Test(int number)
        {
            return FizzBuzzSolution.FizzBuzz(number);
        }

               
        [TestCase(555, ExpectedResult = "fizz buzz deluxe")]
        public string FizzBuzzDeluxeTest(int number)
        {
            return FizzBuzzSolution.FizzBuzz(number);
        }

        // "fizz deluxe" tests

        [TestCase(33, ExpectedResult = "fizz deluxe")]
        public string FizzDeluxeLessThan100Test(int number)
        {
            return FizzBuzzSolution.FizzBuzz(number);
        }


        [TestCase(222, ExpectedResult = "fizz deluxe")]
        public string FizzDeluxeLessThan1000Test(int number)
        {
            return FizzBuzzSolution.FizzBuzz(number);
        }


        [TestCase(777, ExpectedResult = "fizz deluxe")]
        public string FizzDeluxeLessThan1000GreaterThan500Test(int number)
        {
            return FizzBuzzSolution.FizzBuzz(number);
        }


        [TestCase(55, ExpectedResult = "buzz deluxe")]
        public string BuzzDeluxeLessThan100Test(int number)
        {
            return FizzBuzzSolution.FizzBuzz(number);
        }


        [TestCase(5555, ExpectedResult = "buzz deluxe")]
        public string BuzzDeluxeLessThan10000Test(int number)
        {
            return FizzBuzzSolution.FizzBuzz(number);
        }

        [TestCase(9999, ExpectedResult = "fizz deluxe")]
        public string FizzDeluxeLessThan10000Test(int number)
        {
            return FizzBuzzSolution.FizzBuzz(number);
        }



    }

}



