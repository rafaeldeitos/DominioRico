using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Commands;

namespace PaymentContext.Tests
{
    [TestClass]
    public class CreateBoletoSubscriptionCommandTests
    {
        //Red, Green, Refactor
        [TestMethod]
        public void DeveRetornarErroQuandoNomeEhInvalido()
        {
            var command = new CreateBoletoSubscriptionCommand();
            command.FirstName = "";
            command.LastName = "";            

            command.Validate();
            Assert.IsFalse(command.Valid);
         
        }
    }
    
}