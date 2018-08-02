using PaymentContext.Share.Commands;

namespace PaymentContext.Share.Handlers
{
    public interface IHandler<T> where T : ICommand
    {
        ICommandResult Handle(T command);

    }


}