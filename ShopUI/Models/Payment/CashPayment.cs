using ShopUI.Models.Customer;
using ShopUI.Models.Payment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopUI.Models.Payment
{
    public class CashPayment : PaymentMethod
    {
        public override string MethodName => "Наличные";

        public override bool CanPay(decimal amount, Customer.Customer customer)
        {
            return customer.Cash.Amount >= amount;
        }

        public override void Pay(decimal amount, Customer.Customer customer)
        {
            customer.Cash.Amount -= amount;
        }
    }
}
