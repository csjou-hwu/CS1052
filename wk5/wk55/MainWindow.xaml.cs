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

namespace wk55
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
            //var image = new BitmapImage();
            //image.BeginInit();
            //image.UriSource = new Uri(@"C:\Users\User\Documents\Visual Studio 2010\Projects\wk5\stickman.gif");
            //image.EndInit();
            //ImageBehavior.SetAnimatedSource(img, image);
        }
    }
}
