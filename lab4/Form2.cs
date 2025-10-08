using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task22
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //private void Form2_MouseClick(object sender, MouseEventArgs e)
        //{
        //    Graphics graphics = CreateGraphics();
        //    graphics.FillEllipse(Brushes.Red, e.X - 25, e.Y - 25, 50, 50);

        //}

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics g = CreateGraphics();
            
            if (e.Button == MouseButtons.Left)
                g.FillEllipse(Brushes.Green, e.X - 20, e.Y - 20, 40, 40);
            else if (e.Button == MouseButtons.Right)
            {
                SolidBrush b = new SolidBrush(BackColor);
                g.FillEllipse(b, e.X - 20, e.Y - 20, 40, 40);
            }
                
        }
    }
}
