using ShopUI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace ShopUI.Models.Storage
{
    public class ProductStorage
    {
        private List<Product> _products;
        private string _filePath = "C:\\Users\\YF\\source\\repos\\ShopUI\\ShopUI\\Data\\products.xml";

        public ProductStorage()
        {
            LoadFromFile();
        }

        private void LoadFromFile()
        {
            if (File.Exists(_filePath))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
                using (var reader = new StreamReader(_filePath))
                {
                    _products = (List<Product>)serializer.Deserialize(reader);
                }
            }
            else
            {
                // Данные по умолчанию
                _products = new List<Product>
                {
                    new Product { Id = "P001", Name = "Яблоки", Price = 150, Stock = 100, RequiresWeighing = true, Weight = 0, IsWeighed = false },
                    new Product { Id = "P002", Name = "Хлеб", Price = 50, Stock = 50, RequiresWeighing = false, Weight = 0, IsWeighed = true },
                    new Product { Id = "P003", Name = "Молоко", Price = 80, Stock = 40, RequiresWeighing = false, Weight = 0, IsWeighed = true },
                    new Product { Id = "P004", Name = "Сыр", Price = 500, Stock = 30, RequiresWeighing = true, Weight = 0, IsWeighed = false }
                };
                SaveToFile();
            }
        }

        public void SaveToFile()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
            using (var writer = new StreamWriter(_filePath))
            {
                serializer.Serialize(writer, _products);
            }
        }

        public List<Product> GetAllProducts() => _products;

        public Product GetProduct(string id) => _products.FirstOrDefault(p => p.Id == id);

        public void UpdateStock(string id, int quantity)
        {
            var product = GetProduct(id);
            if (product != null && !product.RequiresWeighing)
            {
                product.Stock -= quantity;
                SaveToFile();
            }
        }
    }
}
