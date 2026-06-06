using System;

namespace ShopUI.Models.Entities
{
    public interface IPurchasable
    {
        string Id { get; set; }
        string Name { get; set; }
        decimal Price { get; set; }
        bool RequiresWeighing { get; set; }
        decimal Weight { get; set; }
        bool IsWeighed { get; set; }
        string GetDisplayInfo();
    }
}
