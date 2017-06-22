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

namespace wk123
{
    using System;
    using System.Diagnostics;
    using System.Threading;
    using System.Windows;
    using System.Windows.Media;
    using System.Windows.Media.Media3D;
    using HelixToolkit.Wpf;
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public GeometryModel3D[] FlagModel = new GeometryModel3D[5];
        public Flag[] Flag = new Flag[5];

        private readonly Stopwatch watch;
        private readonly Thread integratorThread;
        HelixViewport3D view1 = new HelixViewport3D();
        public MainWindow()
        {
            InitializeComponent();
            view1.Background = Brushes.Black;
            G1.Children.Add(view1);
            DefaultLights 光源 = new DefaultLights();
            view1.Children.Add(光源);
            for (int i = 0; i < 5; i++)
            {
                CreateFlag(i);
                //  <ModelVisual3D Content="{Binding FlagModel}"/>
                ModelVisual3D M3D = new ModelVisual3D();
                TranslateTransform3D TR = new TranslateTransform3D(i * 3, 0, 0);
                M3D.Transform = TR;
                M3D.Content = FlagModel[i];
                view1.Children.Add(M3D);
            }
            DataContext = this;
            Loaded += MainWindow_Loaded;

            watch = new Stopwatch();
            watch.Start();
            integratorThread = new Thread(IntegrationWorker);
            integratorThread.Start();

            CompositionTarget.Rendering += this.OnCompositionTargetRendering;
            this.Closing += MainWindow_Closing;
        }

        void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            integratorThread.Abort();
        }

        private void IntegrationWorker()
        {
            while (true)
            {
                double dt = 1.0 * watch.ElapsedTicks / Stopwatch.Frequency;
                watch.Restart();
                for (int i = 0; i < 5; i++)
                    Flag[i].Update(dt);
            }
        }

        void OnCompositionTargetRendering(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
                Flag[i].Transfer();
        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            view1.ZoomExtents();
        }

        private void CreateFlag(int i)
        {
            Flag[i] = new Flag("A" + i.ToString() + ".png");
            Flag[i].Init();

            FlagModel[i] = new GeometryModel3D
            {
                Geometry = Flag[i].Mesh,
                Material = Flag[i].Material,
                BackMaterial = Flag[i].Material
            };
        }
    }
}
