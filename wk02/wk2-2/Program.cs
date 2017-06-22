using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wk2_2
{
    using System.Windows.Forms;
    class Program
    {
        static void Main(string[] args)
        {
            Application.Run(new 表單類別());
        }
    }
    class 表單類別 : Form
    {
        public 表單類別()
        {
            this.Text = "表單1";
        }
    }

}
