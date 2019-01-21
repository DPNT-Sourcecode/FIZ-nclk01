namespace BeFaster.App.Solutions.FIZ
{
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

}
