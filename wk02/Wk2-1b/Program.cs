using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wk2_1b
{
    using System.Windows.Forms;
    class Program
    {
        static void Main(string[] args)
        {
            Form 表單物件 = new Form();
            表單物件.Text = "表單1";
            表單物件.ShowDialog();
        }
    }
}
