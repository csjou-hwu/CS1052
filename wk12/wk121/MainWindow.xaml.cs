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

namespace wk121
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        System.Windows.Threading.DispatcherTimer 計時器 = new System.Windows.Threading.DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            計時器.Interval = new TimeSpan(0, 0, 1);
            計時器.Tick += new EventHandler(計時器_Tick);
            計時器.Start();
            this.Closing += new System.ComponentModel.CancelEventHandler(MainWindow_Closing);
        }

        void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            計時器.Stop();
        }
        int 計次 = 0;
        void 計時器_Tick(object sender, EventArgs e)
        {
            textBox1.Text = "我就是愛跳，第" + (++計次).ToString() + "次";
        }
    }
}
