using System.Windows;
using System.Windows.Controls;

namespace Car_warkshop
{
    public partial class editing : Page
    {
        public editing()
        {
            InitializeComponent();
        }

        private void BtnMechanic_Click_1(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Mechanic());
        }

        private void BtnRedservis_Click_1(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new serviscar());
        }

        private void BtnHistory_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new History());
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Аuthorization());
        }
 
    }
}
