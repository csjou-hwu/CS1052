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

namespace Wk3_3
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        //<Ellipse Width = "100" Height = "60" Name = "sample" Margin = "10">
        //    <Ellipse.Fill>
        //        <SolidColorBrush Color="AliceBlue" />
        //        <!--<RadialGradientBrush>
        //            <GradientStop Offset = "0" Color = "AliceBlue"/>
        //            <GradientStop Offset = "1" Color = "Gray"/>
        //            <GradientStop Offset = "2" Color = "Red"/>
        //        </RadialGradientBrush>-->
        //    </Ellipse.Fill>
        //</Ellipse>
            SolidColorBrush [] 筆刷 = { Brushes.Red, Brushes.Orange, Brushes.Yellow
                                    , Brushes.Green, Brushes.Blue, Brushes.Indigo, Brushes.Purple};
            int 計數 = 0;
                        for (int i=0; i<10; i++)
                            for (int j = 0; j < 10; j++)
                            {
                                Ellipse 橢圓物件 = new Ellipse();
                                橢圓物件.Width = 25;
                                橢圓物件.Height =25;
                                橢圓物件.Margin = new Thickness(-400+i*50, -400+ j*50, 0, 0);
                                if (計數 >= 7) 計數 = 0;
                                SolidColorBrush 實心筆刷物件 = 筆刷[計數++];
                                橢圓物件.Fill = 實心筆刷物件;
                                面板.Children.Add(橢圓物件);
                            }

        }
    }
}
