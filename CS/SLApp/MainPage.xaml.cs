using System;
using System.Windows.Controls;

namespace SLApp
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
            DataContext = new MainPageViewModel();
        }

        private void hyperLinkBack_Click(object sender, System.Windows.RoutedEventArgs e)
        {

        }
    }
}
