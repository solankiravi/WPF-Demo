using MVVMDemo.ViewModel;
using System;
using System.Windows;
using System.Windows.Controls;

namespace MVVMDemo.View
{
    /// <summary>
    /// Interaction logic for EmployeeView.xaml
    /// </summary>
    public partial class EmployeeView : UserControl
    {
        public EmployeeView()
        {
            InitializeComponent();
            DataContext = new EmployeeViewModel();
        }

        private void ContextMenu_Click(object sender, System.Windows.RoutedEventArgs e)
        {

            MenuItem item = e.OriginalSource as MenuItem;
            string skinDictPath = item.Tag as string;
            Uri skinDictUri = new Uri(skinDictPath, UriKind.Relative);
            // App app = Application.Current as App;
            App app = Application.Current as App;

            app.ApplySkin(skinDictUri);

        }
    }
}
