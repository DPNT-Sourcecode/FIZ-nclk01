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

}
