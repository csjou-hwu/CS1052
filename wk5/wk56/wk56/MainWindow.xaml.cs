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

namespace wk56
{
    using WpfAnimatedGif;
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            {
                var image = new BitmapImage();
                image.BeginInit();
                image.UriSource = new Uri(@"C:\Users\User\Downloads\stickman.gif");
                image.EndInit();
                ImageBehavior.SetAnimatedSource(img1, image);
            }
            {
                var image = new BitmapImage();
                image.BeginInit();
                image.UriSource = new Uri(@"C:\Users\User\Downloads\stickman.gif");
                image.EndInit();
                ImageBehavior.SetAnimatedSource(img2, image);
            }
            {
                var image = new BitmapImage();
                image.BeginInit();
                image.UriSource = new Uri(@"C:\Users\User\Downloads\stickman.gif");
                image.EndInit();
                ImageBehavior.SetAnimatedSource(img3, image);
            }
            {
                var image = new BitmapImage();
                image.BeginInit();
                image.UriSource = new Uri(@"C:\Users\User\Downloads\stickman.gif");
                image.EndInit();
                ImageBehavior.SetAnimatedSource(img4, image);
            }
        }
    }
}