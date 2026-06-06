using ShopUI.Models.Customer;
using ShopUI.Models.Entities;
using ShopUI.Models.Payment;
using ShopUI.Models.Shopping;
using ShopUI.Models.Storage;
using ShopUI.Views;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShopUI.Presenters
{
    public class ShopPresenter
    {
        private IShopView _view;
        private Customer _customer;
        private ProductStorage _productStorage;
        private ServiceStorage _serviceStorage;
        private List<Receipt> _purchaseHistory;

        public ShopPresenter(IShopView view)
        {
            _view = view;
            _productStorage = new ProductStorage();
            _serviceStorage = new ServiceStorage();
            _purchaseHistory = new List<Receipt>();

            // Инициализация покупателя
            _customer = new Customer("Иван Петров", 5000, 10000, 500);

            SubscribeEvents();
        }

        private void SubscribeEvents()
        {
            _view.OnAddToCart += AddToCart;
            _view.OnRemoveFromCart += RemoveFromCart;
            _view.OnWeighItem += WeighItem;
            _view.OnCheckout += Checkout;
            _view.OnPayment += ProcessPayment;
        }

        public void Start()
        {
            _view.DisplayProducts(_productStorage.GetAllProducts());
            _view.DisplayServices(_serviceStorage.GetAllServices());
            UpdateCustomerDisplay();
            _view.DisplayCart(_customer.Cart.Items);
        }

        private void UpdateCustomerDisplay()
        {
            _view.UpdateCustomerInfo(_customer.Name, _customer.Cash.Amount,
                _customer.DebitCard.Balance, _customer.BonusCard.BonusPoints);
        }

        private void AddToCart()
        {
            var item = _view.GetSelectedItem();
            if (item == null)
            {
                _view.ShowMessage("Выберите товар или услугу");
                return;
            }

            if (item.RequiresWeighing && !item.IsWeighed)
            {
                _view.ShowMessage($"Товар '{item.Name}' требует взвешивания!", true);
                return;
            }

            _customer.Cart.AddItem(item);
            _view.DisplayCart(_customer.Cart.Items);
            _view.UpdateCartTotal(_customer.Cart.TotalAmount);
            _view.ShowMessage($"Товар '{item.Name}' добавлен в корзину");
        }

        private void RemoveFromCart()
        {
            var item = _view.GetSelectedItem();
            if (item != null)
            {
                _customer.Cart.RemoveItem(item.Id);
                _view.DisplayCart(_customer.Cart.Items);
                _view.UpdateCartTotal(_customer.Cart.TotalAmount);
                _view.ShowMessage($"Товар '{item.Name}' удален из корзины");
            }
        }

        private void WeighItem()
        {
            var item = _view.GetSelectedItem();
            if (item == null || !item.RequiresWeighing)
            {
                _view.ShowMessage("Выберите весовой товар");
                return;
            }

            _view.ShowWeighDialog(item, (weight) =>
            {
                if (weight > 0)
                {
                    item.Weight = weight;
                    item.IsWeighed = true;
                    _view.ShowMessage($"Товар '{item.Name}' взвешен: {weight} кг");
                }
            });
        }

        private void Checkout()
        {
            if (_customer.Cart.Items.Count == 0)
            {
                _view.ShowMessage("Корзина пуста", true);
                return;
            }

            if (!_customer.Cart.AreAllWeighed())
            {
                _view.ShowMessage("Не все весовые товары взвешены!", true);
                return;
            }

            decimal total = _customer.Cart.TotalAmount;
            _view.ShowPaymentDialog(total, (amount, method) =>
            {
                _view.RaisePaymentEvent(amount, method); // ✅ Теперь правильно
            });
        }

        private void ProcessPayment(decimal amount, string methodName)
        {
            decimal remainingAmount = _customer.Cart.TotalAmount;
            var payments = new Dictionary<string, decimal>();
            PaymentMethod paymentMethod = null;

            // Создаем платежный метод (Фабричный метод)
            switch (methodName)
            {
                case "Наличные":
                    paymentMethod = new CashPayment();
                    break;
                case "Карта":
                    paymentMethod = new CardPayment();
                    break;
                case "Бонусы":
                    paymentMethod = new BonusPayment();
                    break;
            }

            if (paymentMethod.CanPay(remainingAmount, _customer))
            {
                paymentMethod.Pay(remainingAmount, _customer);
                payments.Add(methodName, remainingAmount);
                remainingAmount = 0;
            }
            else
            {
                _view.ShowMessage($"Недостаточно средств для оплаты {methodName}!", true);

                // Стратегия: выкладываем товары пока не сможем оплатить
                while (_customer.Cart.Items.Count > 0 && !paymentMethod.CanPay(_customer.Cart.TotalAmount, _customer))
                {
                    var itemToRemove = _customer.Cart.Items.Last();
                    _customer.Cart.RemoveItem(itemToRemove.Id);
                    _view.ShowMessage($"Товар '{itemToRemove.Name}' удален из корзины (недостаточно средств)");
                }

                if (_customer.Cart.Items.Count > 0 && paymentMethod.CanPay(_customer.Cart.TotalAmount, _customer))
                {
                    decimal newTotal = _customer.Cart.TotalAmount;
                    paymentMethod.Pay(newTotal, _customer);
                    payments.Add(methodName, newTotal);
                    _view.ShowMessage($"Оплачено {methodName}: {newTotal:C}");
                }
                else
                {
                    _view.ShowMessage("Не удалось совершить покупку. Недостаточно средств даже после удаления товаров.", true);
                    return;
                }
            }

            // Создаем чек
            var receipt = CreateReceipt(payments);
            SaveReceiptToFile(receipt);
            _purchaseHistory.Add(receipt);

            // Обновление остатков
            UpdateStockAfterPurchase();

            // Очистка корзины
            _customer.Cart.Clear();

            // Обновление отображения
            UpdateCustomerDisplay();
            _view.DisplayCart(_customer.Cart.Items);
            _view.UpdateCartTotal(0);
            _view.ShowMessage($"Покупка успешно совершена! Чек сохранен. Получено бонусов: {receipt.BonusesEarned}");
        }

        private Receipt CreateReceipt(Dictionary<string, decimal> payments)
        {
            var receipt = new Receipt
            {
                CustomerName = _customer.Name,
                Subtotal = _customer.Cart.TotalAmount,
                TotalPaid = payments.Values.Sum(),
                Payments = payments
            };

            foreach (var item in _customer.Cart.Items)
            {
                receipt.Items.Add(new ReceiptItem
                {
                    Name = item.Name,
                    Price = item.Price,
                    Quantity = item.RequiresWeighing ? item.Weight : 1,
                    Total = item.Price * (item.RequiresWeighing ? item.Weight : 1)
                });
            }

            // Расчет кэшбэка (если оплата картой)
            if (payments.ContainsKey("Дебетовая карта"))
            {
                receipt.BonusesEarned = (int)(payments["Дебетовая карта"] / 10);
            }

            return receipt;
        }

        private void SaveReceiptToFile(Receipt receipt)
        {
            string receiptsDir = "Receipts";
            if (!System.IO.Directory.Exists(receiptsDir))
                System.IO.Directory.CreateDirectory(receiptsDir);

            string fileName = $"{receiptsDir}/receipt_{receipt.ReceiptNumber}_{DateTime.Now:yyyyMMdd_HHmmss}.txt";
            System.IO.File.WriteAllText(fileName, receipt.GetReceiptText(), System.Text.Encoding.UTF8);
        }

        private void UpdateStockAfterPurchase()
        {
            foreach (var item in _customer.Cart.Items)
            {
                if (item is Product product && !product.RequiresWeighing)
                {
                    _productStorage.UpdateStock(product.Id, 1);
                }
            }
            _view.DisplayProducts(_productStorage.GetAllProducts());
        }
    }
}
