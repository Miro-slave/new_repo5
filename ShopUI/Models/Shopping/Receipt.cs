using System;
using System.Collections.Generic;
using System.Linq;
using ShopUI.Models.Entities;

namespace ShopUI.Models.Shopping
{
    public class Receipt
    {
        public string ReceiptNumber { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string CustomerName { get; set; }
        public List<ReceiptItem> Items { get; set; }
        public decimal Subtotal { get; set; }
        public Dictionary<string, decimal> Payments { get; set; }
        public decimal TotalPaid { get; set; }
        public int BonusesEarned { get; set; }

        public Receipt()
        {
            ReceiptNumber = Guid.NewGuid().ToString().Substring(0, 8).ToUpper();
            PurchaseDate = DateTime.Now;
            Items = new List<ReceiptItem>();
            Payments = new Dictionary<string, decimal>();
        }

        public string GetReceiptText()
        {
            var sb = new System.Text.StringBuilder();
            sb.AppendLine("=".PadRight(50, '='));
            sb.AppendLine($"ЧЕК №{ReceiptNumber}");
            sb.AppendLine($"Дата: {PurchaseDate:dd.MM.yyyy HH:mm:ss}");
            sb.AppendLine($"Покупатель: {CustomerName}");
            sb.AppendLine("-".PadRight(50, '-'));
            sb.AppendLine($"{"Товар",-25} {"Цена",10} {"Кол-во",8} {"Сумма",10}");
            sb.AppendLine("-".PadRight(50, '-'));

            foreach (var item in Items)
            {
                sb.AppendLine($"{item.Name,-25} {item.Price,10:F2} {item.Quantity,8} {item.Total,10:F2}");
            }

            sb.AppendLine("-".PadRight(50, '-'));
            sb.AppendLine($"{"ИТОГО:",-43} {Subtotal,10:F2}");
            sb.AppendLine($"{"Оплачено:",-43} {TotalPaid,10:F2}");

            foreach (var payment in Payments)
            {
                sb.AppendLine($"  {payment.Key}: {payment.Value,10:F2}");
            }

            sb.AppendLine($"{"КЭШБЭК:",-43} {BonusesEarned,10}");
            sb.AppendLine("=".PadRight(50, '='));
            sb.AppendLine("Спасибо за покупку!");

            return sb.ToString();
        }
    }
}
