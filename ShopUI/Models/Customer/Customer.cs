using System;

namespace ShopUI.Models.Customer
{
    public class Customer
    {
        public string Name { get; set; }
        public BonusCard BonusCard { get; set; }
        public Cash Cash { get; set; }
        public DebitCard DebitCard { get; set; }
        public Shopping.ShoppingCart Cart { get; set; }

        public Customer(string name, decimal initialCash, decimal initialCardBalance, int initialBonuses)
        {
            Name = name;
            Cash = new Cash(initialCash);
            DebitCard = new DebitCard(initialCardBalance);
            BonusCard = new BonusCard(initialBonuses);
            Cart = new Shopping.ShoppingCart();
        }
    }
}
