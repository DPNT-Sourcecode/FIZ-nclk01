namespace BeFaster.App.Solutions.FIZ
{
    public class FizzFakeDeluxeHandler : AbstractHandler
    {
        public override string Handle(int number)
        {
            if (
                (   // deluxe
                    (number % 11 == 0) ||
                    (number % 111 == 0) ||
                    (number % 1111 == 0)
                )
                &&  // fake
                (number % 2 == 1)
                &&  // fizz
                (number % 3 == 0)
                )
            {
                return "fizz fake deluxe";
            }
            else
            {
                return base.Handle(number);
            }
        }
    }

}
