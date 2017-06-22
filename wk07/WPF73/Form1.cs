using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WPF73
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Button 按鈕物件 = new Button();
            按鈕物件.BackColor = Color.Red;
            this.Controls.Add(按鈕物件);
            按鈕類別 按鈕物件2 = new 按鈕類別();
           
            this.Controls.Add(按鈕物件2);
        }
    }
    class 按鈕類別 : Button
    {
        public 按鈕類別()
        {
            this.BackColor = Color.Blue;
            this.Location = new Point(100, 100);
        }
    }
}
