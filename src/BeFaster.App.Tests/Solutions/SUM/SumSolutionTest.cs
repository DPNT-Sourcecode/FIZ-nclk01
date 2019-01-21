using System;
using NUnit.Framework;
using BeFaster.App.Solutions.SUM;

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

        [Test]
        public void ComputeSumInvalidHigherValueInputx()
        {
            // Arrange
            int x = 101;
            int y = 1;

            // Assert
            
            Assert.Throws<ArgumentException>(() =>
            {
                // Act
                SumSolution.Sum(x, y);
            });
        }

        [Test]
        public void ComputeSumInvalidLowerValueInputx()
        {
            // Arrange
            int x = -1;
            int y = 1;

            // Assert

            Assert.Throws<ArgumentException>(() =>
            {
                // Act
                SumSolution.Sum(x, y);
            });
        }


        [Test]
        public void ComputeSumInvalidHigherValueInputy()
        {
            // Arrange
            int x = 1;
            int y = 101;

            // Assert

            Assert.Throws<ArgumentException>(() =>
            {
                // Act
                SumSolution.Sum(x, y);
            });
        }


        [Test]
        public void ComputeSumInvalidLowerValueInputy()
        {
            // Arrange
            int x = 1;
            int y = -1;

            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                // Act
                SumSolution.Sum(x, y);
            });
        }

    }
}

