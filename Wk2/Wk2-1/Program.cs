using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wk2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Windows.Forms.Form 表單物件 = 
                new System.Windows.Forms.Form();
            表單物件.Text = "Form1";
            表單物件.ShowDialog();
        }
    }
}
