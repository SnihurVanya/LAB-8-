using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_8
{
    public abstract class TechProductFactory
    {
        public abstract Screen CreateScreen();
        public abstract Processor CreateProcessor();
        public abstract Camera CreateCamera();
    }

    // Конкретні класи компонентів
    public class AMOLED : Screen
    {
        public override void Display()
        {
            Console.WriteLine("AMOLED Screen is displaying");
        }
    }

    public class Snapdragon : Processor
    {
        public override void Process()
        {
            Console.WriteLine("Snapdragon Processor is processing");
        }
    }

    public class DualCamera : Camera
    {
        public override void Capture()
        {
            Console.WriteLine("Dual Camera is capturing");
        }
    }

    // Конкретні фабрики для створення компонентів
    public class SamsungFactory : TechProductFactory
    {
        public override Screen CreateScreen()
        {
            return new AMOLED();
        }

        public override Processor CreateProcessor()
        {
            return new Snapdragon();
        }

        public override Camera CreateCamera()
        {
            return new DualCamera();
        }
    }
}

