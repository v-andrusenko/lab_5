using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Полный конус ");
            Console.ForegroundColor = ConsoleColor.Gray;
            FullCone cone1 = new FullCone();
            cone1.InputCone();
            cone1.ConeInfo();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nУсечённый конус: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            TruncatedCone cone2 = new TruncatedCone();
            cone2.InputCone();
            cone2.ConeInfo();

            Console.WriteLine();
        }
    }
}
