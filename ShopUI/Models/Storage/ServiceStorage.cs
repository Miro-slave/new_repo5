using ShopUI.Models.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace ShopUI.Models.Storage
{
    public class ServiceStorage
    {
        private List<Service> _services;
        private string _filePath = "services.xml";
        
        public ServiceStorage()
        {
            LoadFromFile();
        }
        
        private void LoadFromFile()
        {
            if (File.Exists(_filePath))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Service>));
                using (var reader = new StreamReader(_filePath))
                {
                    _services = (List<Service>)serializer.Deserialize(reader);
                }
            }
            else
            {
                _services = new List<Service>
                {
                    new Service { Id = "S001", Name = "Стрижка", Price = 1000, DurationMinutes = 30 },
                    new Service { Id = "S002", Name = "Маникюр", Price = 1500, DurationMinutes = 60 },
                    new Service { Id = "S003", Name = "Массаж", Price = 2000, DurationMinutes = 45 }
                };
                SaveToFile();
            }
        }
        
        public void SaveToFile()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Service>));
            using (var writer = new StreamWriter(_filePath))
            {
                serializer.Serialize(writer, _services);
            }
        }
        
        public List<Service> GetAllServices() => _services;
        
        public Service GetService(string id) => _services.FirstOrDefault(s => s.Id == id);
    }
}
