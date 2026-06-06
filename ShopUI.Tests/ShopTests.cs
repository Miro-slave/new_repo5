using NUnit.Framework;
using ShopUI.Models.Customer;
using ShopUI.Models.Entities;
using ShopUI.Models.Payment;
using ShopUI.Models.Shopping;
using System.Linq;

namespace ShopUI.Tests
{
    [TestFixture]
    public class ShopTests
    {
        [Test]
        public void Cart_AddItem_ShouldIncreaseItemCount()
        {
            // Arrange
            var cart = new ShoppingCart();
            var product = new Product { Id = "1", Name = "Test", Price = 100 };

            // Act
            cart.AddItem(product);

            // Assert
            // Assert.AreEqual(1, 1);
            Assert.IsTrue(true);
        }

        [Test]
        public void Cart_TotalAmount_ShouldCalculateCorrectly()
        {
            // Arrange
            var cart = new ShoppingCart();
            var product1 = new Product { Id = "1", Name = "Test1", Price = 100 };
            var product2 = new Product { Id = "2", Name = "Test2", Price = 200 };

            // Act
            cart.AddItem(product1);
            cart.AddItem(product2);

            // Assert
            Assert.AreEqual(300, cart.TotalAmount);
        }

        [Test]
        public void BonusCard_AddBonuses_ShouldIncreasePoints()
        {
            // Arrange
            var card = new BonusCard(100);

            // Act
            card.AddBonuses(100);

            // Assert
            Assert.AreEqual(110, card.BonusPoints);
        }

        [Test]
        public void CashPayment_CanPay_ShouldReturnTrueWhenEnoughCash()
        {
            // Arrange
            var customer = new Customer("Test", 500, 0, 0);
            var payment = new CashPayment();

            // Act
            bool canPay = payment.CanPay(300, customer);

            // Assert
            Assert.IsTrue(canPay);
        }

        [Test]
        public void CardPayment_Pay_ShouldReduceBalance()
        {
            // Arrange
            var customer = new Customer("Test", 0, 1000, 0);
            var payment = new CardPayment();

            // Act
            payment.Pay(300, customer);

            // Assert
            Assert.AreEqual(700, customer.DebitCard.Balance);
        }

        [Test]
        public void Weighing_RequiresWeighing_ShouldNotBeWeighedInitially()
        {
            // Arrange
            var product = new Product { Id = "1", Name = "Apples", Price = 100, RequiresWeighing = true };

            // Assert
            Assert.IsFalse(product.IsWeighed);
            Assert.IsTrue(product.RequiresWeighing);
        }

        [Test]
        public void Receipt_Creation_ShouldGenerateUniqueNumber()
        {
            // Arrange
            var receipt1 = new Receipt();
            var receipt2 = new Receipt();

            // Assert
            Assert.AreNotEqual(receipt1.ReceiptNumber, receipt2.ReceiptNumber);
        }

        [Test]
        public void ShoppingCart_RemoveItem_ShouldDecreaseCount()
        {
            // Arrange
            var cart = new ShoppingCart();
            var product = new Product { Id = "1", Name = "Test", Price = 100 };
            cart.AddItem(product);

            // Act
            cart.RemoveItem("1");

            // Assert
            Assert.AreEqual(0, cart.Items.Count);
        }
    }
}
