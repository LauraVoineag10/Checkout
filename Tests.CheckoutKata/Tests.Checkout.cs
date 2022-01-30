using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Application
{
    [TestClass]
    public class CheckoutTests
    {
        [TestMethod]
        public void TestCalculatePrice()
        {
            //Arrange
            Checkout checkout = new Checkout();
            int expected = 50;

            //Act
            int result = checkout.CalculatePrice(50);

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}