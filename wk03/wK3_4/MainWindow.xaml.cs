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
using System.Windows.Media.Animation;

namespace wK3_4
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            {
                DoubleAnimation da = new DoubleAnimation();
                da.From = 30;
                da.To = 100;
                da.Duration = new Duration(TimeSpan.FromSeconds(1));
                da.RepeatBehavior = RepeatBehavior.Forever;
                button1.BeginAnimation(Button.HeightProperty, da);
            }
            {
                DoubleAnimation da = new DoubleAnimation();
                da.From = 30;
                da.To = 100;
                da.Duration = new Duration(TimeSpan.FromSeconds(1));
                button1.BeginAnimation(Button.WidthProperty, da);
            }
        }
    }
}
