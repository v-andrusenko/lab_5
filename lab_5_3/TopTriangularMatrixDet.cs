using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5_3
{
    class TopTriangularMatrixDet : TopTriangularMatrix
    {
        public override void Determinant(double[,] A, int N, int L)
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
