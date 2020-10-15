using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5_3
{
    class CalcDeterminant : Matrix
    {
        public CalcDeterminant(Matrix matrix) 
        {
            this.matrix = matrix;
        }
        Matrix matrix;
        public override void Determinant()
        {
            double[,] A = new double[matrix.line, matrix.column];
            Console.ForegroundColor = ConsoleColor.Green;
            if (matrix.line == matrix.column)
            {
                double c, r = 1;
                for (int i = 0; i < matrix.line; i++)
                {
                    for (int k = i + 1; k < matrix.line; k++)
                    {
                        c = matrix0[k, i] / matrix0[i, i];
                        for (int j = i; j < matrix.line; j++)
                            matrix0[k, j] = (int)matrix0[k, j] - (int)(c * A[i, j]);
                    }
                }
                for (int i = 0; i < matrix.line; i++)
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
