using MicaWPF.Controls;
using Microsoft.Win32;
using System;
using System.Windows.Media;

namespace WinzipWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MicaWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            Met1.Foreground = Brushes.Gray;
            Met2.Foreground = Brushes.Gray;
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Met1.Visibility = System.Windows.Visibility.Visible;
            Met2.Visibility = System.Windows.Visibility.Hidden;
        }

        private void Button_Click_1(object sender, System.Windows.RoutedEventArgs e)
        {
            Met2.Visibility = System.Windows.Visibility.Visible;
            Met1.Visibility = System.Windows.Visibility.Hidden;
        }

        private void OpenfromDoc_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            OpenFileDialog open_from_doc = new OpenFileDialog();
            open_from_doc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            open_from_doc.Filter = "Zip Files (*.zip) | *.zip";
            open_from_doc.ShowDialog();
        }

        private void OpenfromDown_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            OpenFileDialog open_from_down = new OpenFileDialog();
            open_from_down.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Favorites);
            open_from_down.Filter = "Zip Files (*.zip) | *.zip";
            open_from_down.ShowDialog();
        }

        private void Button_Click_2(object sender, System.Windows.RoutedEventArgs e)
        {
            Secret.Content = "Bing!";
        }

        private void Secret2_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Secret2.Content = "Bong!";
        }
    }
}
