using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace wk1_6
{
    class 類別1
    {
        static void Main(string[] args)
        {
            Application.Run(new 類別2());
        }
    }
    class 類別2 : System.Windows.Forms.Form
    {
        public 類別2()
        {
            Button 按鈕 = new Button();
            this.Controls.Add(按鈕);
            按鈕.Click += new EventHandler(按鈕_Click);
        }

        void 按鈕_Click(object sender, EventArgs e)
        {
            this.Text = "周重石 Hello Wk1-6";
        }
    }
}
