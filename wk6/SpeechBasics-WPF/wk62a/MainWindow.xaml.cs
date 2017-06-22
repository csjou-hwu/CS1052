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
    using System.Windows.Media.Media3D;
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        //<Viewport3D.Camera>
        //        <PerspectiveCamera x:Name="相機" Position = "4,4,20" LookDirection = "0,0,-1"
        //       FieldOfView = "65" UpDirection = "0,1,0" />
        //</Viewport3D.Camera>
        PerspectiveCamera 相機;
        public MainWindow()
        {
            InitializeComponent();
            相機 = new PerspectiveCamera();
            相機.Position = new Point3D(4, 4, 20);
            相機.LookDirection = new Vector3D(0, 0, -1);
            相機.FieldOfView = 65;
            相機.UpDirection = new Vector3D(0, 1, 0);
            相片.Camera = 相機;
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
