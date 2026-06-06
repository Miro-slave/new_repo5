using System;

namespace ShopUI.Models.Entities
{
    public class Service : IPurchasable
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int DurationMinutes { get; set; }
        public bool RequiresWeighing { get; set; } = false;
        public decimal Weight { get; set; } = 0;
        public bool IsWeighed { get; set; } = true;

        public string GetDisplayInfo()
        {
            return $"{Name} - {Price:C} ({DurationMinutes} мин)";
        }
    }
}
