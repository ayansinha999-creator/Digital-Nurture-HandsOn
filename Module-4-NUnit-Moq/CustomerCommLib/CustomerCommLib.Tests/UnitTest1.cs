using Moq;
using NUnit.Framework;
using CustomerCommLib;

namespace CustomerCommLib.Tests
{
    public class Tests
    {
        [Test]
        public void TestSendMail()
        {
            var mockMailSender = new Mock<IMailSender>();

            mockMailSender.Setup(x => x.SendMail(It.IsAny<string>(), It.IsAny<string>()))
                          .Returns(true);

            CustomerComm customer = new CustomerComm(mockMailSender.Object);

            bool result = customer.SendMailToCustomer("test@gmail.com"); ;

            Assert.That(result, Is.True);
        }
    }
}