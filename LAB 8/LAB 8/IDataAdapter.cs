using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace LAB_8
{
    public interface IDataAdapter
    {
        void ImportData(string data);
        string ExportData();
    }

    // Адаптер для CSV формату
    public class CsvDataAdapter : IDataAdapter
    {
        private CsvDataTemplate template;

        public CsvDataAdapter(CsvDataTemplate template)
        {
            this.template = template;
        }

        public void ImportData(string data)
        {
            Console.WriteLine("Importing CSV data");
            // Логіка для імпорту CSV даних
        }

        public string ExportData()
        {
            Console.WriteLine("Exporting data to CSV");
            // Логіка для експорту даних у CSV формат
            return "CSV Data";
        }
    }

    // Адаптер для XML формату
    public class XmlDataAdapter : IDataAdapter
    {
        private XmlDataTemplate template;

        public XmlDataAdapter(XmlDataTemplate template)
        {
            this.template = template;
        }

        public void ImportData(string data)
        {
            Console.WriteLine("Importing XML data");
            // Логіка для імпорту XML даних
        }

        public string ExportData()
        {
            Console.WriteLine("Exporting data to XML");
            // Логіка для експорту даних у XML формат
            return "XML Data";
        }
    }
}