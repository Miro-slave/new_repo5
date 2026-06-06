using System;
using System.Collections.Generic;
using System.Linq;
using ShopUI.Models.Entities;

namespace ShopUI.Models.Shopping
{
    public class ShoppingCart
    {
        private List<IPurchasable> _items = new List<IPurchasable>();

        public IReadOnlyList<IPurchasable> Items => _items;
        public decimal TotalAmount => _items.Sum(i => i.Price * (i.RequiresWeighing ? i.Weight : 1));

        public void AddItem(IPurchasable item)
        {
            var existingItem = _items.FirstOrDefault(i => i.Id == item.Id);
            if (existingItem != null && !item.RequiresWeighing)
            {
                // Для весовых товаров создаем новый экземпляр
                _items.Add(item);
            }
            else
            {
                _items.Add(item);
            }
        }

        public void RemoveItem(string itemId)
        {
            var item = _items.FirstOrDefault(i => i.Id == itemId);
            if (item != null)
            {
                _items.Remove(item);
            }
        }

        public void Clear()
        {
            _items.Clear();
        }

        public bool AreAllWeighed()
        {
            return _items.All(i => !i.RequiresWeighing || i.IsWeighed);
        }
    }
}
