using ShopUI.Models.Customer;
using ShopUI.Models.Payment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopUI.Models.Payment
{
    public class CardPayment : PaymentMethod
    {
        public override string MethodName => "Дебетовая карта";

        public override bool CanPay(decimal amount, Customer.Customer customer)
        {
            return customer.DebitCard.Balance >= amount;
        }

        public override void Pay(decimal amount, Customer.Customer customer)
        {
            customer.DebitCard.Balance -= amount;
            // Кэшбэк 1%
            decimal cashback = amount * 0.01m;
            customer.BonusCard.AddBonuses(cashback);
        }
    }
}
