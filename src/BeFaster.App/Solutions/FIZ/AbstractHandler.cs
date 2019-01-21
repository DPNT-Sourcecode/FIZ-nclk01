namespace BeFaster.App.Solutions.FIZ
{
    public abstract class AbstractHandler : IHandler
    {
        private IHandler nextHandler;

        public IHandler setNext(IHandler handler)
        {
            this.nextHandler = handler;
            return handler;
        }

        public virtual string Handle(int number)
        {
            if (this.nextHandler != null)
            {
                return this.nextHandler.Handle(number);
            }
            else
            {
                return null;
            }
        }
    }
}
