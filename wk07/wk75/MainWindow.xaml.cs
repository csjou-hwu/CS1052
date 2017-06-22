using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wk75
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            飛機類別 飛機物件 = new 飛機類別();
            G1.Children.Add(飛機物件);
            this.MouseWheel += new MouseWheelEventHandler(MainWindow_MouseWheel);
        }

        void MainWindow_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            if (e.Delta > 0)
            {
                ISC.ScaleX *= 1.1;
                ISC.ScaleY *= 1.1;
            }
            else
            {
                ISC.ScaleX *= 0.9;
                ISC.ScaleY *= 0.9;
            }
        }
    }
}
