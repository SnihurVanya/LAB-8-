using LAB_8;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_8
{
    internal class Program
    {
        static void Task1()
        {
            ConfigurationManager configManager = ConfigurationManager.Instance;

            // Додаємо та виводимо конфігураційні налаштування
            configManager.SetSetting("LogLevel", "Debug");
            configManager.SetSetting("DatabaseConnection", "ConnectionString123");
            configManager.DisplaySettings();

            // Можна отримати єдиний екземпляр з іншого місця коду
            ConfigurationManager anotherConfigManager = ConfigurationManager.Instance;
            anotherConfigManager.DisplaySettings();

            // Перевірка на те, чи обидва екземпляри ConfigurationManager - це один і той самий об'єкт
            Console.WriteLine($"Are both instances the same? {configManager == anotherConfigManager}");
        }
    }
    }
class Program
{
    static void Task2()
    {
        Console.WriteLine("Enter the type of chart (Line/Bar/Pie):");
        string chartType = Console.ReadLine();

        GraphFactory factory = GetChartFactory(chartType);

        if (factory != null)
        {
            Chart chart = factory.CreateChart();
            factory.InputData(); // Можливість введення даних можна розширити або модифікувати за необхідності
            chart.Draw();
        }
        else
        {
            Console.WriteLine("Invalid chart type");
        }
    }

    // Метод для отримання відповідної фабрики графіків залежно від введеного типу
    static GraphFactory GetChartFactory(string chartType)
    {
        switch (chartType.ToLower())
        {
            case "line":
                return new LineChartFactory();
            case "bar":
                return new BarChartFactory();
            case "pie":
                return new PieChartFactory();
            default:
                return null;
        }

    }
    static void Task3()
    {
        Console.WriteLine("Enter the type of tech product to create (Samsung/iPhone):");
        string productType = Console.ReadLine();

        TechProductFactory factory = GetFactory(productType);

        if (factory != null)
        {
            Screen screen = factory.CreateScreen();
            Processor processor = factory.CreateProcessor();
            Camera camera = factory.CreateCamera();

            Console.WriteLine("Creating tech product:");
            screen.Display();
            processor.Process();
            camera.Capture();
        }
        else
        {
            Console.WriteLine("Invalid tech product type");
        }
    }

    // Метод для отримання відповідної фабрики компонентів залежно від введеного типу
    static TechProductFactory GetFactory(string productType)
    {
        switch (productType.ToLower())
        {
            case "samsung":
                return new SamsungFactory();
            // Додайте інші фабрики для інших типів продуктів за необхідності
            // case "iphone":
            //     return new IPhoneFactory();
            default:
                return null;
        }

    }
    static void Task4()
    {
        // Створення шаблонів даних
        var csvTemplate = new CsvDataTemplate { CsvFormat = "CSV Format" };
        var xmlTemplate = new XmlDataTemplate { XmlFormat = "XML Format" };

        // Створення адаптерів
        var csvAdapter = new CsvDataAdapter(csvTemplate);
        var xmlAdapter = new XmlDataAdapter(xmlTemplate);

        // Користувач вводить формат вихідних та цільових даних
        Console.WriteLine("Enter source data format (CSV/XML):");
        string sourceFormat = Console.ReadLine().ToLower();

        Console.WriteLine("Enter target data format (CSV/XML):");
        string targetFormat = Console.ReadLine().ToLower();

        // Вибір відповідних адаптерів
        IDataTemplate sourceTemplate, targetTemplate;
        IDataAdapter sourceAdapter, targetAdapter;

        if (sourceFormat == "csv")
        {
            sourceTemplate = csvTemplate;
            sourceAdapter = csvAdapter;
        }
        else if (sourceFormat == "xml")
        {
            sourceTemplate = xmlTemplate;
            sourceAdapter = xmlAdapter;
        }
        else
        {
            Console.WriteLine("Invalid source data format");
            return;
        }

        if (targetFormat == "csv")
        {
            targetTemplate = csvTemplate;
            targetAdapter = csvAdapter;
        }
        else if (targetFormat == "xml")
        {
            targetTemplate = xmlTemplate;
            targetAdapter = xmlAdapter;
        }
        else
        {
            Console.WriteLine("Invalid target data format");
            return;
        }

        // Клонування шаблонів для даних
        IDataTemplate clonedSourceTemplate = sourceTemplate.Clone();
        IDataTemplate clonedTargetTemplate = targetTemplate.Clone();

        // Симуляція імпорту та експорту даних
        sourceAdapter.ImportData("Source Data");
        targetAdapter.ExportData();
    }
}

    
    


