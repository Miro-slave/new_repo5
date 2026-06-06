using System;

namespace ShopUI.Models.Payment
{
    public abstract class PaymentMethod
    {
        public abstract string MethodName { get; }
        public abstract bool CanPay(decimal amount, Customer.Customer customer);
        public abstract void Pay(decimal amount, Customer.Customer customer);
    }
}
