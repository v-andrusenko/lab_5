using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace lab_5_1
{
    public partial class Program : Form
    {
        public PictureBox picture;

        public Program()
        {
            Square square1 = new Square();
            square1.InputSquare();
            square1.Information();
            InitializeComponent();
            DrawSquare(square1);

        }
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Program());

        }
        void DrawSquare(Square square)
        {
            Bitmap bmp = new Bitmap(picture.Width, picture.Height);
            Graphics graph = Graphics.FromImage(bmp);
            Pen pen1 = new Pen(Color.Magenta);

            graph.DrawRectangle(pen1, square.X1+304, -square.Y1+227, square.SideLength, square.SideLength);
            picture.Image = bmp;
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Program));
            this.picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.Color.Transparent;
            this.picture.Location = new System.Drawing.Point(0, 0);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(608, 456);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // Program
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(608, 456);
            this.Controls.Add(this.picture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Program";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DrawSquare";
            this.Load += new System.EventHandler(this.Program_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Program_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);

        }

        private void Program_Load(object sender, EventArgs e)
        {

        }

        public void Program_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyValue == (char)Keys.Left)
            {
                picture.Left = picture.Left - 1;
                //Console.WriteLine($"А({};{Location})");
            }
            else if (e.KeyValue == (char)Keys.Right)
            {
                picture.Left = picture.Left + 1;
            }
            else if (e.KeyValue == (char)Keys.Up)
            {
                picture.Top = picture.Top-1;
            }
            else if (e.KeyValue == (char)Keys.Down)
            {
                picture.Top = picture.Top + 1;
            } 
        } 
    }
}
