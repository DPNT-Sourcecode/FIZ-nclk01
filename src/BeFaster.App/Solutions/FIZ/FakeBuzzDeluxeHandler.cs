namespace BeFaster.App.Solutions.FIZ
{
    public class FakeBuzzDeluxeHandler : AbstractHandler
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
                (number % 5 == 0)
                )
            {
                return "fake buzz deluxe";
            }
            else
            {
                return base.Handle(number);
            }
        }
    }

}
