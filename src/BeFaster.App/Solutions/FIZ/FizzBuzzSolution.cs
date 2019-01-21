namespace BeFaster.App.Solutions.FIZ
{
    public static class FizzBuzzSolution
    {
        public static string FizzBuzz(int number)
        {
            var fizzBuzzFakeDeluxeHandler = new FizzBuzzFakeDeluxeHandler();
            var fizzFakeDeluxeHandler = new FizzFakeDeluxeHandler();
            var buzzFakeDeluxeHandler = new BuzzFakeDeluxeHandler();
            var fizzBuzzDeluxeHandler = new FizzBuzzDeluxeHandler();
            var fizzDeluxeHandler = new FizzDeluxeHandler();
            var buzzDeluxeHandler = new BuzzDeluxeHandler();
            var fakeDeluxeHandler = new FakeDeluxeHandler();
            var deluxeHandler = new DeluxeHandler();
            var fizzBuzzHandler = new FizzBuzzHandler();
            var fizzBuzzContainerHandler = new FizzBuzzContainerHandler();
            var fizzHandler = new FizzHandler();
            var fizzNumberContainerHandler = new FizzNumberContainerHandler();
            var buzzHandler = new BuzzHandler();
            var buzzContainerHandler = new BuzzContainerHandler();
            var numberHandler = new NumberHandler();

            fizzBuzzFakeDeluxeHandler
                .setNext(fizzFakeDeluxeHandler)
                .setNext(buzzFakeDeluxeHandler)
                .setNext(fizzBuzzDeluxeHandler)
                .setNext(fizzDeluxeHandler)
                .setNext(buzzDeluxeHandler)
                .setNext(fakeDeluxeHandler)
                .setNext(deluxeHandler)
                .setNext(fizzBuzzHandler)
                .setNext(fizzBuzzContainerHandler)
                .setNext(fizzHandler)
                .setNext(fizzNumberContainerHandler)
                .setNext(buzzHandler)
                .setNext(buzzContainerHandler)
                .setNext(numberHandler);

            string result = fizzBuzzFakeDeluxeHandler.Handle(number);

            return result;
        }
    }

}
