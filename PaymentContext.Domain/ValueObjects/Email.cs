using Flunt.Validations;
using PaymentContext.Share.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Email : ValueObject
    {
        public Email (string adress)
        {
            Adress = adress;

            AddNotifications(new Contract()
                .Requires()
                .IsEmail(Adress, "Email.Adress", "E-mail inválido")
            );

        }

        public string Adress { get; private set; }
        
    }
    
}