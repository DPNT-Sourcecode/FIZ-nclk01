namespace BeFaster.App.Solutions.FIZ
{
    public class DeluxHandler : AbstractHandler
    {
        public override string Handle(int number)
        {
            if ((number % 11 == 0) ||
                (number % 111 == 0) ||
                (number % 1111 == 0)
                )
            {
                return "deluxe";
            }
            else
            {
                return base.Handle(number);
            }
        }
    }

}

