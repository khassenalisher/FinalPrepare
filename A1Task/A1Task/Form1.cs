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

namespace A1Task
{
    public partial class Form1 : Form
    {
       public int x =50;
       public int y= 50;
       Position ob=Position.Right;
  
        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush b = new SolidBrush(Color.Black);
            Graphics g = pictureBox1.CreateGraphics();
            e.Graphics.DrawImage(new Bitmap("IMG_2656.JPG"), x, y, 100, 100);
            Thread.Sleep(1);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(ob == Position.Right)
            x += 10;
            else if (ob == Position.Left)
                       x -= 10;
                else if (ob == Position.Down)
                        y += 10;
                        else if (ob == Position.Up)
                         y -= 10;

            Invalidate();
        }
        
        enum Position
        {
            Left,
            Right,
            Down,
            Up
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                ob = Position.Left;
            if (e.KeyCode == Keys.Down)
                ob = Position.Down;
            if (e.KeyCode == Keys.Up)
                ob = Position.Up;
            if (e.KeyCode == Keys.Right)
                ob = Position.Right;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }


    }
}
