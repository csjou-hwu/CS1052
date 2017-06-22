using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wk91
{
    using System.Windows;
    using System.Windows.Controls;
    
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            WPF 視窗物件 = new WPF();
            視窗物件.ShowDialog();

        }
    }
    class WPF : Window
    {
        public WPF()
        {
            Button B = new Button();
            B.Width = 100;
            B.Height = 30;
            Grid G = new Grid();
            this.Content = G;
            G.Children.Add(B);
        }
    }
}
