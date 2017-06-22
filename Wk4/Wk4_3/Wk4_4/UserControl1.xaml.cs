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

namespace Wk4_4
{
    /// <summary>
    /// UserControl1.xaml 的互動邏輯
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        System.Windows.Threading.DispatcherTimer 計時 = new System.Windows.Threading.DispatcherTimer();
        public UserControl1()
        {
            InitializeComponent();
            計時.Interval = new TimeSpan(0, 0, 0, 0, 300);
            計時.Tick += new EventHandler(計時_Tick);
            計時.Start();
        }
        int 計數 = 1;
        void 計時_Tick(object sender, EventArgs e)
        {
            計數++;
            if (計數 > 3) 計數 = 1;
            image1.Source = new BitmapImage(new Uri(@"C:\Users\User\Documents\Visual Studio 2010\Projects\Wk4\m"
                + 計數.ToString() + ".png"));
        }
    }
}
