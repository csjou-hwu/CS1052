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

namespace wk111
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    using System.ComponentModel;
    using System.Windows;

    //using ExampleBrowser;
    using NAudioWpfDemo;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    //[Example(null, "Showing a spectrogram from NAudio using Transform3Ds.")]
    public partial class MainWindow : Window
    {
        // NAudio still not supporting 64bit
        // http://naudio.codeplex.com/Thread/View.aspx?ThreadId=46000

        private readonly ControlPanelViewModel viewModel;

        public MainWindow()
        {
            InitializeComponent();
            Closing += MainWindow_Closing;
            viewModel = new ControlPanelViewModel(null, analyzer);
            DataContext = viewModel;
        }

        private void MainWindow_Closing(object sender, CancelEventArgs e)
        {
            viewModel.Dispose();
        }
    }
}