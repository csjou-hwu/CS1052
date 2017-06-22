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

namespace Wk2_5b
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    //<Grid>
    //    <Image Source="C:\Users\User\Pictures\珍奶.jpg" MouseUp="Image_MouseUp">
    //        <Image.RenderTransform>
    //            <RotateTransform CenterX="150" CenterY="150"  x:Name="旋轉" Angle="10"/>
    //        </Image.RenderTransform>
    //    </Image>
    //</Grid>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Image 圖片物件 = new Image();
            BitmapImage b = new BitmapImage();
            b.BeginInit();
            b.UriSource = new Uri(@"C:\Users\User\Pictures\珍奶.jpg");
            b.EndInit();

            // ... Get Image reference from sender.
            //var image = sender as Image;
            // ... Assign Source.
            圖片物件.Source = b;
            格點.Children.Add(圖片物件);
            旋轉 = new RotateTransform();
            旋轉.Angle = 10;
            旋轉.CenterX = 150;
            旋轉.CenterY = 150;
            圖片物件.RenderTransform = 旋轉;
            圖片物件.MouseUp += new MouseButtonEventHandler(圖片物件_MouseUp);
            

        }
        RotateTransform 旋轉;
        void 圖片物件_MouseUp(object sender, MouseButtonEventArgs e)
        {
            旋轉.Angle += 10;
        }
    }
}
