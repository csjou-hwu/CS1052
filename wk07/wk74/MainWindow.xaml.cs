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

namespace wk74
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        ScaleTransform SC = new ScaleTransform();
        public MainWindow()
        {
            InitializeComponent();
            機械人類別 機械人物件 = new 機械人類別();
            機械人物件.RenderTransform = SC;
            G1.Children.Add(機械人物件);
            this.MouseWheel += new MouseWheelEventHandler(MainWindow_MouseWheel);
        }

        void MainWindow_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            if (e.Delta > 0)
            {
                SC.ScaleX *= 1.1;
                SC.ScaleY *= 1.1;
            }
            else
            {
                SC.ScaleX *= 0.9;
                SC.ScaleY *= 0.9;
            }
        }
    }
}
