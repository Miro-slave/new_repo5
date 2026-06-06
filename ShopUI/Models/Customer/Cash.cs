using System;

namespace ShopUI.Models.Customer
{
    public class Cash
    {
        public decimal Amount { get; set; }

        public Cash(decimal amount)
        {
            Amount = amount;
        }
    }
}
