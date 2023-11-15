using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_8
{
    
    
        public abstract class Chart
        {
            public abstract void Draw();
        }

        // Конкретний клас лінійного графіка
        public class LineChart : Chart
        {
            public override void Draw()
            {
                Console.WriteLine("Drawing Line Chart");
                // Логіка малювання лінійного графіка
            }
        }

        // Конкретний клас стовпчикового графіка
        public class BarChart : Chart
        {
            public override void Draw()
            {
                Console.WriteLine("Drawing Bar Chart");
                // Логіка малювання стовпчикового графіка
            }
        }

        // Конкретний клас кругової діаграми
        public class PieChart : Chart
        {
            public override void Draw()
            {
                Console.WriteLine("Drawing Pie Chart");
                // Логіка малювання кругової діаграми
            }
        }

    
}
