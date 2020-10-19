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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFWebBrowserControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SearchURL()
        {
            if (string.IsNullOrEmpty(urlTextBox.Text))
                this.BrowserContent.Navigate(new Uri("https://www.google.com/"));
            else
                this.BrowserContent.Navigate(new Uri(urlTextBox.Text));
        }
        private void BrowserContent_Navigating(object sender, NavigatingCancelEventArgs e)
        {
            GoBtn.IsEnabled = false;

        }

        private void BrowserContent_Loaded(object sender, RoutedEventArgs e)
        {
            SearchURL();
        }

        private void Go_Click(object sender, RoutedEventArgs e)
        {
            SearchURL();
        }

        private void urlTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                SearchURL();
        }
    }
}
