using System;
using System.Collections.Generic;

namespace BeFaster.App.Solutions.FIZ
{
    public static class FizzBuzzSolution
    {
        public static string FizzBuzz(int number)
        {
            var fizzHandler = new FizzHandler();
            var buzzHandler = new BuzzHandler();
            var fizzBuzzHandler = new FizzBuzzHandler();
            var numberHandler = new NumberHandler();

            fizzBuzzHandler.setNext(fizzHandler).setNext(buzzHandler).setNext(numberHandler);

            string result = fizzBuzzHandler.Handle(number);

            return result;
        }
    }

    public interface IHandler
    {
        IHandler setNext(IHandler handler);

        string Handle(int number);
    }

    public abstract class AbstractHandler : IHandler
    {
        private IHandler nextHandler;

        public IHandler setNext(IHandler handler)
        {
            this.nextHandler = handler;
            return handler;
        }

        public virtual string Handle(int number)
        {
            if (this.nextHandler != null)
            {
                return this.nextHandler.Handle(number);
            }
            else
            {
                return null;
            }
        }
    }

    public class FizzHandler : AbstractHandler
    {
        public override string Handle(int number)
        {
            if (number % 3 == 0)
            {
                return "fizz";
            }
            else
            {
                return base.Handle(number);
            }
        }
    }

    public class BuzzHandler : AbstractHandler
    {
        public override string Handle(int number)
        {
            if (number % 5 == 0)
            {
                return "buzz";
            }
            else
            {
                return base.Handle(number);
            }
        }
    }



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


    public class NumberHandler : AbstractHandler
    {
        public override string Handle(int number)
        {
            return Convert.ToString(number);
        }
    }


}






