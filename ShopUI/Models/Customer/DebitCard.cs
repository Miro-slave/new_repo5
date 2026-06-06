using System;

namespace ShopUI.Models.Customer
{
    public class DebitCard
    {
        public decimal Balance { get; set; }

        public DebitCard(decimal balance)
        {
            Balance = balance;
        }
    }
}
