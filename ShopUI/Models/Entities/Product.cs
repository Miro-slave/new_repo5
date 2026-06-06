using System;

namespace ShopUI.Models.Entities
{
    public class Product : IPurchasable
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public bool RequiresWeighing { get; set; }
        public decimal Weight { get; set; }
        public bool IsWeighed { get; set; }

        public string GetDisplayInfo()
        {
            return $"{Name} - {Price:C} {(RequiresWeighing ? $"(вес: {Weight} кг)" : "")}";
        }
    }
}
