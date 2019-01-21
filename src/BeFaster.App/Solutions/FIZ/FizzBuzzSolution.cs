namespace BeFaster.App.Solutions.FIZ
{
    public static class FizzBuzzSolution
    {
        public static string FizzBuzz(int number)
        {
            var fizzHandler = new FizzHandler();
            var fizzNumberContainerHandler = new FizzNumberContainerHandler();
            var buzzHandler = new BuzzHandler();
            var fizzBuzzHandler = new FizzBuzzHandler();
            var buzzContainerHandler = new BuzzContainerHandler();
            var numberHandler = new NumberHandler();

            fizzBuzzHandler
                .setNext(fizzHandler)
                .setNext(fizzNumberContainerHandler)
                .setNext(buzzHandler)
                .setNext(buzzContainerHandler)
                .setNext(numberHandler);

            string result = fizzBuzzHandler.Handle(number);

            return result;
        }
    }

}

