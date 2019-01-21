namespace BeFaster.App.Solutions.FIZ
{
    public class DeluxHandler : AbstractHandler
    {
        public override string Handle(int number)
        {
            if (number % 11 == 0)
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
