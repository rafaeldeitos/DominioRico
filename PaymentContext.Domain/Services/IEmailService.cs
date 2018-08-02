namespace PaymentContext.Domain.Services{
    public interface IEmailServices
    {
        void Send(string to, string email, string subject, string body);
    }

}