namespace BeFaster.App.Solutions.FIZ
{
    public static class FizzBuzzSolution
    {
        public static string FizzBuzz(int number)
        {
            var fizzBuzzDeluxeHandler = new FizzBuzzDeluxeHandler();
            var fizzDeluxeHandler = new FizzDeluxeHandler();
            var buzzDeluxeHandler = new BuzzDeluxeHandler();
            var deluxeHandler = new DeluxeHandler();
            var fizzBuzzHandler = new FizzBuzzHandler();
            var fizzBuzzContainerHandler = new FizzBuzzContainerHandler();
            var fizzHandler = new FizzHandler();
            var fizzNumberContainerHandler = new FizzNumberContainerHandler();
            var buzzHandler = new BuzzHandler();
            var buzzContainerHandler = new BuzzContainerHandler();
            var numberHandler = new NumberHandler();

            fizzBuzzDeluxeHandler
                .setNext(fizzDeluxeHandler)
                .setNext(buzzDeluxeHandler)
                .setNext(deluxeHandler)
                .setNext(fizzBuzzHandler)
                .setNext(fizzBuzzContainerHandler)
                .setNext(fizzHandler)
                .setNext(fizzNumberContainerHandler)
                .setNext(buzzHandler)
                .setNext(buzzContainerHandler)
                .setNext(numberHandler);

            string result = fizzBuzzDeluxeHandler.Handle(number);

            return result;
        }
    }

}

