using _123321.images.window123;
using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Threading;
namespace _123321
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();

            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += new EventHandler(UpdateTimer_tick);
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();

        }
        private void UpdateTimer_tick(Object sender, EventArgs e)
        {
            DisplayDatеTextBlock.Text = DateTime.Now.ToString();
        }

      
    

        private void gik_Click(object sender, RoutedEventArgs e)
        {
            Window2 window = new Window2();
            window.Show();
        }

        private void isk_Click(object sender, RoutedEventArgs e)
        {
            qwerty.Navigate(new Page1());
            
            
        }

        private void tik_Click(object sender, RoutedEventArgs e)
        {
            Window1 window = new Window1();
            window.Show();
        }

        private void byl_Click(object sender, RoutedEventArgs e)
        {
            qwerty.Navigate(new Page2());
        }
    }
}
