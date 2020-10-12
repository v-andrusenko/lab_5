using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5_3
{
    class TopTriangularMatrix : Matrix
    {
        public override void InputMatrix()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nВерхняя треугольная матрица");
            Console.ForegroundColor = ConsoleColor.Gray;
            do
            {
                Console.Write("Количество строк: ");
                this.line = int.Parse(Console.ReadLine());
                if ((this.line <= 0)) Console.WriteLine("Количество должно быть больше 0");
            }
            while (this.line <= 0);

            do
            {
                Console.Write("Количество колонок: ");
                this.column = int.Parse(Console.ReadLine());
                if ((this.column <= 0)) Console.WriteLine("Количество должно быть больше 0");
            }
            while (this.column <= 0);

            Console.WriteLine("После ввода каждого элемента нажимайте enter");

            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write($"элемент[{i},{j}] = ");
                    if (i <= j)
                        matrix0[i, j] = int.Parse(Console.ReadLine());
                    else
                    {
                        matrix0[i, j] = 0;
                        Console.Write($"{matrix0[i, j]}\n");
                    }
                    if (j == this.column - 1) Console.WriteLine();

                }
            }
            
        }
    }
}
