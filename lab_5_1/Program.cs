using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace lab_5_1
{
    public partial class Program : Form
    {
        private PictureBox picture;

        public Program()
        {
            
            Square square1 = new Square();
            square1.InputSquare();
            square1.Information();
            InitializeComponent();
            square1.DrawSquare(square1.X1, square1.Y1, square1.SideLength);
        }
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Program());

        }

        private void InitializeComponent()
        {
            this.picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture.Location = new System.Drawing.Point(0, 0);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(362, 261);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // Program
            // 
            this.ClientSize = new System.Drawing.Size(362, 261);
            this.Controls.Add(this.picture);
            this.Name = "Program";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DrawSquare";
            this.Load += new System.EventHandler(this.Program_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);

        }

        private void Program_Load(object sender, EventArgs e)
        {

        }

        
    }
}
