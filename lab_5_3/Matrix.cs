using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5_3
{
    class Matrix
    {
        public Matrix() { }
        public int line {get;set;}
        public int column { get; set; }
        public double[,] matrix0 = new double[15,15];
        public virtual void InputMatrix()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Обычная матрица");
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

            for (int i=0;i<line;i++)
            {
                for (int j=0; j<column;j++)
                {
                    Console.Write($"элемент[{i},{j}] = ");
                    matrix0[i, j] = int.Parse(Console.ReadLine());
                    if (j == this.column - 1) Console.WriteLine();
                    
                }
            }
        }

        public void Output()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write(String.Format("{0,5} ", matrix0[i, j]));
                    if (j == this.column - 1) Console.WriteLine();
                }
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public virtual void Determinant(double[,] A, int N, int L)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            if (N == L)
            {
                double c, r = 1;
                for (int i = 0; i < N; i++)
                {
                    for (int k = i + 1; k < N; k++)
                    {
                        c = matrix0[k, i] / matrix0[i, i];
                        for (int j = i; j < N; j++)
                            matrix0[k, j] = (int)matrix0[k, j] - (int)(c * A[i, j]);
                    }
                }
                for (int i = 0; i < N; i++)
                    r *= A[i, i];
                Console.WriteLine($"Детерминант {r}");
                
            }
            else
            {
                Console.WriteLine("Посчитать детерминант можно только для квадратной матрицы");
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }

    }
}
