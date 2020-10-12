using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5_2
{
    class TruncatedCone : FullCone
    {
        public double SmallRadius { get; set; }
        public double TruncatedHeight { get; set; }
        public override void InputCone()
        {
            Console.Write("Радиус большей основы конуса: ");
            do
            {
                this.BaseRadius = double.Parse(Console.ReadLine());
                if (this.BaseRadius < 0) Console.WriteLine("Радиус больше 0");
            }
            while (this.BaseRadius < 0);
            Console.Write("Радиус меньшей основы конуса: ");
            do
            {
                this.SmallRadius = double.Parse(Console.ReadLine());
                if (this.SmallRadius < 0) Console.WriteLine("Радиус больше 0");
            }
            while (this.BaseRadius < 0);
            Console.Write("Высота конуса: ");
            do
            {
                this.ConeHeight = double.Parse(Console.ReadLine());
                if (this.ConeHeight < 0) Console.WriteLine("Высота больше 0");
            }
            while (this.ConeHeight < 0);
            Console.Write("Высота усечённого конуса: ");
            do
            {
                this.TruncatedHeight = double.Parse(Console.ReadLine());
                if (this.TruncatedHeight < 0) Console.WriteLine("Высота больше 0");
            }
            while (this.TruncatedHeight < 0);
        }
        public double SmallSquare()
        {
            double SmallCirceSquare = Math.PI * this.SmallRadius * this.SmallRadius;
            return SmallCirceSquare;
        }
        public override double ConeCapacity()
        {
            double Capacity = 1;
            Capacity = 0.3333 * ((this.ConeHeight * BaseSquare()) - (this.TruncatedHeight * SmallSquare()));
            return Capacity;
        }
        public override double GeneratrixLength()
        {
            double gLength = Math.Pow(this.TruncatedHeight, 2) + Math.Pow(this.BaseRadius, 2);
            gLength = Math.Sqrt(gLength);
            return gLength;
        }
        public override void ConeInfo()
        {
            Console.Write("\nРадиус круга в основе: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{this.BaseRadius}");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Высота конуса: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{this.ConeHeight}");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Высота усечённого конуса: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{this.TruncatedHeight}");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Площадь большей основы конуса: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0: 0.000}", BaseSquare());

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Площадь меньшей основы конуса: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0: 0.000}", SmallSquare());

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Объём усечённого конуса: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0: 0.000}", ConeCapacity());

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Длина образующей L: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{GeneratrixLength()}");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
