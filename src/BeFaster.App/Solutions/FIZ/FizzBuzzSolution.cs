using System;
using System.Collections.Generic;

namespace BeFaster.App.Solutions.FIZ
{
    public static class FizzBuzzSolution
    {
        //public static string FizzBuzz(int number)
        //{
        //    string message = string.Empty;

        //    if (number % 3 == 0 && number % 5 == 0)
        //    {
        //        message = "fizz buzz";
        //    }
        //    else if (number % 3 == 0)
        //    {
        //        message = "fizz";
        //    }
        //    else if (number % 5 == 0)
        //    {
        //        message = "buzz";
        //    }
        //    else
        //    {
        //        message = Convert.ToString(number);
        //    }
        //    return message;
        //}


        public static string FizzBuzz(int number)
        {
            var fizzHandler = new FizzHandler();
            var buzzHandler = new BuzzHandler();
            var fizzBuzzHandler = new FizzBuzzHandler();
            var numberHandler = new NumberHandler();

            fizzHandler.setNext(buzzHandler).setNext(fizzBuzzHandler).setNext(numberHandler);


            string result = fizzHandler.Handle(number);

            return result;
        }
    }

    public interface Handler
    {
        Handler setNext(Handler handler);

        string Handle(int number);
    }

    public abstract class AbstractHandler : Handler
    {
        private Handler nextHandler;

        public Handler setNext(Handler handler)
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
            return Convert.ToString(number);
        }
    }


    public class NumberHandler : AbstractHandler
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

    
}



