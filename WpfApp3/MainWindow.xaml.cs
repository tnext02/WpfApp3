using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void progress_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            startButton .IsEnabled = false;
            Thread thread = new Thread(new ThreadStart(UpdateProgressBar));
            thread.Start();

        }
        private void UpdateProgressBar()
        {
            for (int i = 0; i <= 100; i++)
            {
                Dispatcher.Invoke(() =>
                { progress.Value = i; });

            }
            Thread.Sleep(50);
        }
    }
}
