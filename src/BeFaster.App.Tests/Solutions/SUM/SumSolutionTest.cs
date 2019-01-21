﻿using BeFaster.App.Solutions.SUM;
using NUnit.Framework;
using System;

namespace BeFaster.App.Tests.Solutions.SUM
{
    [TestFixture]
    public class SumSolutionTest
    {
        [TestCase(1, 1, ExpectedResult = 2)]
        public int ComputeSum(int x, int y)
        {
            return SumSolution.Sum(x, y);
        }

        //[TestCase(101, 1, [ExpectedException(typeof(ArgumentException))])]
        [Test]
        [ExpectedException(typeof(System.ArgumentException))]
        public int ComputeSumInvalidInputx(int x, int y)
        {
            return SumSolution.Sum(101, 1);
        }
    }
}

