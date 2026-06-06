using System;
using System.Collections.Generic;
using System.Linq;
using ShopUI.Models.Entities;

namespace ShopUI.Models.Shopping
{
    public class ReceiptItem
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public decimal Total { get; set; }
    }
}
