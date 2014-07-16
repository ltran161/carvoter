using System.Windows;
using Microsoft.Phone.Controls;

namespace CarVoter
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            Loaded += MainPage_Loaded;
        }

        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}