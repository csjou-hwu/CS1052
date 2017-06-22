using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Wk3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            // 1.
             this.Width = 506;
            this.Height = 533;
            Graphics G = this.CreateGraphics();
            for (int i=0; i<10; i++)
                for (int j = 0; j < 10; j++)
                {
                    G.DrawEllipse(Pens.Red, i*50, j*50, 50, 50);
                }
        }
    }
}
