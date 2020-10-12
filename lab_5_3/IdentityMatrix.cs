using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5_3
{
    class IdentityMatrix : Matrix
    {
        public override void InputMatrix()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nПомните: строки равны колонкам в единичной матрице!");
            Console.ForegroundColor = ConsoleColor.Gray;
            do
            {
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
                if ((this.line != this.column)) Console.WriteLine("\nКол-во строк должно быть равно кол-ву колонок\n");
            }
            while (this.line != this.column);
            
            Console.WriteLine("Элементы единичной матрицы: ");
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write($"элемент[{i},{j}] = ");
                    if (i==j)
                    {
                        matrix0[i, j] = 1;
                        Console.WriteLine(matrix0[i, j]);
                    }
                    else
                    {
                        matrix0[i, j] = 0;
                        Console.WriteLine(matrix0[i, j]);
                    }
                    if (j == this.column - 1) Console.WriteLine();
                }
            }
        }
    }
}
