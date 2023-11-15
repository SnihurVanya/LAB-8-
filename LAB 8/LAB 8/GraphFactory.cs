using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_8
{
    
    
        public abstract class GraphFactory
        {
            // Factory Method, який повинен бути реалізований в конкретних фабриках
            public abstract Chart CreateChart();

            // Метод для введення даних графіка
            public virtual void InputData()
            {
                Console.WriteLine("Enter data for the chart:");
                // Логіка введення даних графіка
            }
        }

        // Конкретна фабрика для лінійного графіка
        public class LineChartFactory : GraphFactory
        {
            public override Chart CreateChart()
            {
                return new LineChart();
            }
        }

        // Конкретна фабрика для стовпчикового графіка
        public class BarChartFactory : GraphFactory
        {
            public override Chart CreateChart()
            {
                return new BarChart();
            }
        }

        // Конкретна фабрика для кругової діаграми
        public class PieChartFactory : GraphFactory
        {
            public override Chart CreateChart()
            {
                return new PieChart();
            }
        }
    
}
