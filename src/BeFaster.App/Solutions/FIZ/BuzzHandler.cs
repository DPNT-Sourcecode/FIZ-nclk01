namespace BeFaster.App.Solutions.FIZ
{
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

}
