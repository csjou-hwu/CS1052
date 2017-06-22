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

namespace wk83
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

        private void 撥放_Click(object sender, RoutedEventArgs e)
        {
            影片.Stop();
            影片.Play();
        }

        private void 暫停_Click(object sender, RoutedEventArgs e)
        {
            影片.Pause();
        }

        private void 停止_Click(object sender, RoutedEventArgs e)
        {
            影片.Stop();
        }

        private void 繼續_Click(object sender, RoutedEventArgs e)
        {
            影片.Play();
        }

        private void 音量_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            影片.Volume = 音量.Value;
        }
    }
}
