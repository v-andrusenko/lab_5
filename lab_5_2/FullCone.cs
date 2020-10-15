using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5_2
{
    class FullCone
    {
        public double ConeHeight { get; set; }
        public double BaseRadius { get; set; }
        public FullCone() { }

        public virtual void InputCone()
        {
            Console.Write("Радиус круга в основе конуса: ");
            do
            {
                this.BaseRadius = double.Parse(Console.ReadLine());
                if (this.BaseRadius < 0) Console.WriteLine("Радиус больше 0");
            }
            while (this.BaseRadius < 0);
            Console.Write("Высота конуса: ");
            do
            {
                this.ConeHeight = double.Parse(Console.ReadLine());
                if (this.ConeHeight < 0) Console.WriteLine("Высота больше 0");
            }
            while (this.ConeHeight < 0);
        }

        public double BaseSquare()
        {
            double CircleSquare = Math.PI * this.BaseRadius * this.BaseRadius;
            return CircleSquare;
        }
        public virtual double ConeCapacity ()
        {
            double Capacity = 1;
            Capacity = 0.3333 * this.ConeHeight * BaseSquare();
            return Capacity;
        }
        public virtual double GeneratrixLength()
        {
            double gLength = Math.Pow(this.ConeHeight, 2) + Math.Pow(this.BaseRadius, 2);
            gLength = Math.Sqrt(gLength);
            return gLength;
        }
        public virtual void ConeInfo()
        {
            Console.Write("\nРадиус круга в основе: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{this.BaseRadius}");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Высота конуса: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{this.ConeHeight}");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Площадь основы конуса: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0: 0.000}", BaseSquare());

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Объём конуса: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0: 0.000}", ConeCapacity());

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Длина образующей L: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0: 0.000}",GeneratrixLength());
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
