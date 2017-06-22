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

namespace Wk4_2
{
    using System.Windows.Media.Animation;
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            UserControl1 O = new UserControl1();
            G1.Children.Add(O);
            DoubleAnimation da = new DoubleAnimation
                (360, 0, new Duration(TimeSpan.FromSeconds(3)));
            RotateTransform rt = new RotateTransform();
            O.RenderTransform = rt;
            O.RenderTransformOrigin = new Point(0.5, 0.5);
            da.RepeatBehavior = RepeatBehavior.Forever;
            rt.BeginAnimation(RotateTransform.AngleProperty, da);
        }
    }
}
