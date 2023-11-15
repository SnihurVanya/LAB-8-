using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_8
{
    internal class ConfigurationManager
    {
        private static ConfigurationManager instance;

        // Колекція для зберігання конфігураційних налаштувань
        private Dictionary<string, string> settings;

        // Приватний конструктор, щоб заборонити створення екземплярів ззовні
        private ConfigurationManager()
        {
            settings = new Dictionary<string, string>();
        }

        // Метод для отримання єдиного екземпляра ConfigurationManager
        public static ConfigurationManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ConfigurationManager();
                }
                return instance;
            }
        }

        // Метод для отримання значення конфігураційного параметра за ключем
        public string GetSetting(string key)
        {
            if (settings.ContainsKey(key))
            {
                return settings[key];
            }
            return null;
        }

        // Метод для встановлення або оновлення значення конфігураційного параметра
        public void SetSetting(string key, string value)
        {
            if (settings.ContainsKey(key))
            {
                settings[key] = value;
            }
            else
            {
                settings.Add(key, value);
            }
        }

        // Метод для виводу всіх конфігураційних налаштувань
        public void DisplaySettings()
        {
            Console.WriteLine("Configuration Settings:");
            foreach (var kvp in settings)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
