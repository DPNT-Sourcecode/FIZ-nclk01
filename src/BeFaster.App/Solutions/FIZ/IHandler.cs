namespace BeFaster.App.Solutions.FIZ
{

    public interface IHandler
    {
        IHandler setNext(IHandler handler);

        string Handle(int number);
    }
}
