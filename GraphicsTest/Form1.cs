using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsTest
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Graphics gfx;
        private double t = 0;

        public Form1()
        {
            InitializeComponent(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(display.Width, display.Height);
            gfx = Graphics.FromImage(bmp);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Interval = 10;
            timer.Enabled = true;

            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            t++;
            gfx.Clear(Color.FromArgb(255, 255, 255));
            gfx.FillRectangle(new SolidBrush(Color.FromArgb(255, 0, 0)), new Rectangle((int)(50 + t), 50, 200, 150));
            display.Image = bmp;
        }
    }
}
