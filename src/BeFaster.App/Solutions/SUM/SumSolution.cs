using BeFaster.Runner.Exceptions;
using System;

namespace BeFaster.App.Solutions.SUM
{
    public static class SumSolution
    {
        public static int Sum(int x, int y)
        {
            if (x < 0 || x > 100)
            {
                throw new ArgumentException("x should have values between 0 and 100 inclusive.");
            }

            if (y < 0 || y > 100)
            {
                throw new ArgumentException("y should have values between 0 and 100 inclusive.");
            }

            return (x + y);
        }
    }
}

