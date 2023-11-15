using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_8
{
    public interface IDataTemplate
    {
        IDataTemplate Clone();
    }

    // Конкретний клас для шаблону даних CSV
    public class CsvDataTemplate : IDataTemplate
    {
        public string CsvFormat { get; set; }

        public IDataTemplate Clone()
        {
            return new CsvDataTemplate { CsvFormat = this.CsvFormat };
        }
    }

    // Конкретний клас для шаблону даних XML
    public class XmlDataTemplate : IDataTemplate
    {
        public string XmlFormat { get; set; }

        public IDataTemplate Clone()
        {
            return new XmlDataTemplate { XmlFormat = this.XmlFormat };
        }
    }
}
