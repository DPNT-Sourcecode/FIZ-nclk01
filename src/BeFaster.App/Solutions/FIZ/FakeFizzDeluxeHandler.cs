namespace BeFaster.App.Solutions.FIZ
{
    public class FakeFizzDeluxeHandler : AbstractHandler
    {
        public override string Handle(int number)
        {
            if (
                (
                    (number % 11 == 0) ||
                    (number % 111 == 0) ||
                    (number % 1111 == 0)
                )
                &&
                (number % 2 == 1)
                )
                &&
                    (number % 3 == 0)
            {
                return "fake deluxe";
            }
            else
            {
                return base.Handle(number);
            }
        }
    }

}
