using FirstFloor.ModernUI.Windows.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace FirstFloor.ModernUI.App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ModernWindow
    {
        //private DispatcherTimer timer;
        //public double EndTop { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            //timer = new DispatcherTimer();
            //timer.Interval = TimeSpan.FromMilliseconds(300);
            //timer.Tick += timer_Tick;
            //this.Left = SystemParameters.WorkArea.Width - this.Width;
            //this.EndTop = SystemParameters.WorkArea.Height - this.Height;
            //this.Top = SystemParameters.WorkArea.Height;

            //this.Loaded += MainWindow_Loaded;
        }

        //private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        //{
        //    timer.Start();
        //}

        //void timer_Tick(object sender, EventArgs e)
        //{
        //    while (this.Top > EndTop)
        //    {
        //        this.Top -= 5;
        //    }
        //}
    }
}
