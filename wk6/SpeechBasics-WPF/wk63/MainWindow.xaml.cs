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

namespace wk62a
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

        private void Window_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            this.Title = e.Delta.ToString();
            if (e.Delta > 0)
            {
                相機.Position = new System.Windows.Media.Media3D.Point3D(相機.Position.X,
                                                                         相機.Position.Y,
                                                                         相機.Position.Z + 2);
            }
            else
            {
                相機.Position = new System.Windows.Media.Media3D.Point3D(相機.Position.X,
                                                                         相機.Position.Y,
                                                                         相機.Position.Z - 2);
            }
        }

       
    }
}
