﻿using System;
using System.Collections.Generic;

namespace BeFaster.App.Solutions.FIZ
{
    public static class FizzBuzzSolution
    {
        public static string FizzBuzz(int number)
        {
            string message = string.Empty;

            if (number % 3 == 0 && number % 5 == 0)
            {
                message = "fizz buzz";
            }
            else if (number % 3 == 0)
            {
                message = "fizz";
            }
            else if (number % 5 == 0)
            {
                message = "buzz";
            }
            else
            {
                message = Convert.ToString(number);
            }
            return message;
        }

    }

    interface Handler
    {
        Handler setNext(Handler handler);

        object Handle(object request);
    }

    abstract class AbstractHandler : Handler
    {
        private Handler nextHandler;

        public Handler setNext(Handler handler)
        {
            this.nextHandler = handler;
            return handler;
        }

        public virtual object Handle(object request)
        {
            if (this.nextHandler != null)
            {
                return this.nextHandler.Handle(request);
            }
            else
            {
                return null;
            }
        }
    }

    class MonkeyHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if ((request as string) == "Banana")
            {
                return "Monkey: I'll eat the " + request.ToString() + ".\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }

    class SquirrelHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "Nut")
            {
                return "Squirrel: I'll eat the " + request.ToString() + ".\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }

    class DogHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "MeatBall")
            {
                return "Dog: I'll eat the " + request.ToString() + ".\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }

    class Client
    {
        public static void ClientCode(AbstractHandler handler)
        {
            foreach (var food in new List<string> { "Nut", "Banana", "Cup of coffee" })
            {
                Console.WriteLine("Client: Who wants a " + food + "?");

                var result = handler.Handle(food);

                if (result != null)
                {
                    Console.Write("   " + result);
                }
                else
                {
                    Console.WriteLine("   " + food + " was left untouched.");
                }
            }
        }
    }

    public class TestProgram
    {
        static void Test()
        {
            var monkey = new MonkeyHandler();
            var squirrel = new SquirrelHandler();
            var dog = new DogHandler();

            monkey.setNext(squirrel).setNext(dog);

            Console.WriteLine("Chain: Monkey > Squirerel > Dog\n");
            Client.ClientCode(monkey);
            Console.WriteLine();

            Console.WriteLine("Subchain: Squirrel > Dog\n");
            Client.ClientCode(squirrel);
        }
    }



}


