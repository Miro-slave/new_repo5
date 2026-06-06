using ShopUI.Models.Customer;
using ShopUI.Models.Payment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopUI.Models.Payment
{
    public class BonusPayment : PaymentMethod
    {
        public override string MethodName => "Бонусы";

        public override bool CanPay(decimal amount, Customer.Customer customer)
        {
            return customer.BonusCard.BonusPoints >= amount;
        }

        public override void Pay(decimal amount, Customer.Customer customer)
        {
            customer.BonusCard.SpendBonuses(amount);
        }
    }
}
