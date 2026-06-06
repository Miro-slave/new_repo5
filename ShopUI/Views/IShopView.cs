using ShopUI.Models.Entities;
using System;
using System.Collections.Generic;

namespace ShopUI.Views
{
    public interface IShopView
    {
        event Action OnAddToCart;
        event Action OnRemoveFromCart;
        event Action OnWeighItem;
        event Action OnCheckout;
        event Action<decimal, string> OnPayment;
        event Action OnClearFilters;

        void DisplayProducts(List<Product> products);
        void DisplayServices(List<Service> services);
        void DisplayCart(IEnumerable<IPurchasable> cartItems);
        void UpdateCustomerInfo(string name, decimal cash, decimal cardBalance, int bonuses);
        void ShowMessage(string message, bool isError = false);
        void UpdateCartTotal(decimal total);
        IPurchasable GetSelectedItem();
        void ShowWeighDialog(IPurchasable item, Action<decimal> callback);
        void ShowPaymentDialog(decimal total, Action<decimal, string> paymentCallback);
        string GetCustomerName();
        void RaisePaymentEvent(decimal amount, string method);
    }
}
