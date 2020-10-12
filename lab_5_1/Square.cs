using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace lab_5_1
{
    class Square
    {
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int X2 { get; set; }
        public int Y2 { get; set; }
        public int X3 { get; set; }
        public int Y3 { get; set; }
        public int X4 { get; set; }
        public int Y4 { get; set; }
        public int SideLength { get; set; } 

        public void InputSquare ()
        {
            Console.Write("Введите координату Х верхней левой вершины: ");
            X1 = int.Parse(Console.ReadLine());
            this.X1 = X1;
            Console.Write("Введите координату Y верхней левой вершины: ");
            Y1 = int.Parse(Console.ReadLine());
            this.Y1 = Y1;
            Console.Write("Введите длину стороны: ");
            do
            {
                SideLength = int.Parse(Console.ReadLine());
                if (SideLength <= 0)
                {
                    Console.Write("Введите положительную длину стороны:");
                }
            }
            while (SideLength <= 0);
            this.SideLength = SideLength;
            this.X2 = this.X1 + SideLength;
            this.Y2 = this.Y1;
            this.X3 = this.X2;
            this.Y3 = this.Y2 - SideLength;
            this.X4 = this.X3 - SideLength;
            this.Y4 = this.Y3;
        }
        public void Information()
        {
            Console.Write("\nВерхняя левая вершина А(");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{this.X1},{this.Y1})");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Верхняя правая вершина B(");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{this.X2},{this.Y2})");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Нижняя правая вершина C(");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{this.X3},{this.Y3})");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Нижняя левая вершина D(");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{this.X4},{this.Y4})");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Длина стороны квадрата: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{SideLength}");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        private PictureBox picture;
        public void DrawSquare(int x1, int y1, int sidelength)
        {
            Bitmap bmp = new Bitmap(picture.Width, picture.Height);
            Graphics graph = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Magenta);
            //Font font = new Font(Calibri, );
            //graph.DrawString("A(х1,у1)",)
            graph.DrawRectangle(pen, x1, y1, sidelength, sidelength);
            picture.Image = bmp;
        }
        public void Moves(int x1, int y1, int sidelength)
        {
            Console.WriteLine("Чтобы двигать нарисованный квадрат влево-вправо, нажимайте стрелочки.\n" +
                "Чтобы поворачивать квадрат, введите 'rotate' и нажимайте стрелочки");
            int k = x1;
            int j = y1;
            if (Console.ReadKey().Key == ConsoleKey.LeftArrow)
            {
                k += 1;
                j += 1;

                Program.DrawSquare(k, j, sidelength);
            }
        }

    }
}
