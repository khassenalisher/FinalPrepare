using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A2TaskSnake
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }




        private void button1_Click(object sender, EventArgs e)
        {

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            for (int k = 0; k < 10; k++)
            {
                Graphics g = pictureBox1.CreateGraphics();
                g.Clear(Color.White); 
                Pen p = new Pen(Brushes.Red, 7.0F);

                float x1 = 0; //координатф положений одной точки
                float y1 = 0;
                float y2 = 0;

                float yEx = 200;
                float eF = 40;

                for (float x = 0; x < 20; x += 0.1F)
                {

                    y2 = (float)Math.Sin(x);

                    g.DrawLine(p, x1 * eF, y1 * eF + yEx, x * eF, y2 * eF + yEx);

                    x1 = x;
                    y1 = y2;
                    Thread.Sleep(20);

                }
                pictureBox1.Image = null;
                pictureBox1.Invalidate();
                g.Dispose();
                p.Dispose();
                Thread.Sleep(30);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
