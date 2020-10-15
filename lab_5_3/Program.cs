using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix1 = new Matrix();
            matrix1.InputMatrix();
            matrix1.Output();
            matrix1.Determinant(matrix1.matrix0,matrix1.line,matrix1.column);

            IdentityMatrix matrix2 = new IdentityMatrix();
            matrix2.InputMatrix();
            matrix2.Output();

            IdentityMatrixDet det1 = new IdentityMatrixDet();
            det1.Determinant(matrix2.matrix0, matrix2.line, matrix2.column);

            TopTriangularMatrix matrix3 = new TopTriangularMatrix();
            matrix3.InputMatrix();
            matrix3.Output();
            Console.WriteLine();

            TopTriangularMatrixDet det2 = new TopTriangularMatrixDet();
            det2.Determinant(matrix3.matrix0, matrix3.line, matrix3.column);
        }
    }
}
