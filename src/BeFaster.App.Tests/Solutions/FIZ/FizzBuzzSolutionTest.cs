using System;
using BeFaster.App.Solutions.FIZ;
using NUnit.Framework;

namespace BeFaster.App.Tests.Solutions.FIZ
{
    [TestFixture]
    public class FizzBuzzSolutionTest
    {

        [TestCase(7, ExpectedResult = "7")]
        public string NumberTest(int number)
        {
            return FizzBuzzSolution.FizzBuzz(number);
        }


        [TestCase(77, ExpectedResult = "77")]
        public string DeluxeLessThan100Test(int number)
        {
            return FizzBuzzSolution.FizzBuzz(number);
        }

        [TestCase(8888, ExpectedResult = "8888")]
        public string NumberLessThan10000Test(int number)
        {
            return FizzBuzzSolution.FizzBuzz(number);
        }


        [TestCase(31, ExpectedResult = "fizz")]
        public string FizzContainerTest(int number)
        {
            return FizzBuzzSolution.FizzBuzz(number);
        }


        [TestCase(9, ExpectedResult = "fizz")]
        public string BuzzNoDeluxeNumberLessThan10Test(int number)
        {
            return FizzBuzzSolution.FizzBuzz(number);
        }

        [TestCase(6666, ExpectedResult = "fizz")]
        public string FizzDeluxeLessThan10000Test(int number)
        {
            return FizzBuzzSolution.FizzBuzz(number);
        }

        [TestCase(777, ExpectedResult = "fizz")]
        public string NumberLessThan1000Test(int number)
        {
            return FizzBuzzSolution.FizzBuzz(number);
        }

        

        [TestCase(52, ExpectedResult = "buzz")]
        public string BuzzContainerTest(int number)
        {
            return FizzBuzzSolution.FizzBuzz(number);
        }


        [TestCase(40, ExpectedResult = "buzz")]
        public string BuzzTest(int number)
        {
            return FizzBuzzSolution.FizzBuzz(number);
        }



        [TestCase(90, ExpectedResult = "fizz buzz")]
        public string FizzBuzzTest(int number)
        {
            return FizzBuzzSolution.FizzBuzz(number);
        }

        [TestCase(546, ExpectedResult = "fizz buzz")]
        public string FizzBuzzByContainerFizzByDivisibleBuzzTest(int number)
        {
            return FizzBuzzSolution.FizzBuzz(number);
        }


        //deluxe


        [TestCase(36, ExpectedResult = "fizz deluxe")]
        public string FizzTest(int number)
        {
            return FizzBuzzSolution.FizzBuzz(number);
        }

        [TestCase(50, ExpectedResult = "buzz deluxe")]
        public string BuzzDeluxeTest(int number)
        {
            return FizzBuzzSolution.FizzBuzz(number);
        }


        // fizz buzz deluxe

        [TestCase(350, ExpectedResult = "fizz buzz deluxe")]
        public string FizzBuzzDeluxeTest(int number)
        {
            return FizzBuzzSolution.FizzBuzz(number);
        }


        // fake deluxe

        [TestCase(55, ExpectedResult = "fake deluxe")]
        public string FakeDeluxeTest(int number)
        {
            return FizzBuzzSolution.FizzBuzz(number);
        }



        [TestCase(325, ExpectedResult = "buzz fake deluxe")]
        public string FizzBuzzByContainerBuzzByDivisibleFizzTest(int number)
        {
            return FizzBuzzSolution.FizzBuzz(number);
        }



        [TestCase(35, ExpectedResult = "buzz fake deluxe")]
        public string FizzDeluxeLessThan500Test(int number)
        {
            return FizzBuzzSolution.FizzBuzz(number);
        }


        [TestCase(55, ExpectedResult = "buzz fake deluxe")]
        public string BuzzDeluxeLessThan100Test(int number)
        {
            return FizzBuzzSolution.FizzBuzz(number);
        }


        [TestCase(5555, ExpectedResult = "buzz fake deluxe")]
        public string BuzzDeluxeLessThan10000Test(int number)
        {
            return FizzBuzzSolution.FizzBuzz(number);
        }


        [TestCase(55, ExpectedResult = "buzz fake deluxe")]
        public string FakeFizzDeluxeTest(int number)
        {
            return FizzBuzzSolution.FizzBuzz(number);
        }



        [TestCase(3333, ExpectedResult = "fizz fake deluxe")]
        public string FakeFizzDeluxeLessThan10000Test(int number)
        {
            return FizzBuzzSolution.FizzBuzz(number);
        }


        [TestCase(33, ExpectedResult = "fizz fake deluxe")]
        public string FakeDeluxeLessThan1000Test(int number)
        {
            return FizzBuzzSolution.FizzBuzz(number);
        }


        [TestCase(333, ExpectedResult = "fizz fake deluxe")]
        public string FakeFizzDeluxeLessThan1000Test(int number)
        {
            return FizzBuzzSolution.FizzBuzz(number);
        }




        [TestCase(315, ExpectedResult = "fizz buzz fake deluxe")]
        public string FizzBuzzContainerTest(int number)
        {
            return FizzBuzzSolution.FizzBuzz(number);
        }


               
        [TestCase(555, ExpectedResult = "fizz buzz fake deluxe")]
        public string FizzBuzzFakeDeluxeTest(int number)
        {
            return FizzBuzzSolution.FizzBuzz(number);
        }


        

    }

}








