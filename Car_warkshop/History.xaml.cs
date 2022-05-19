using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Car_warkshop
{
    public partial class History : Page
    {
        public History()
        {
            InitializeComponent();
            DgHistori.ItemsSource = Car_warkshopEntities.GetContext().Choice_services.ToList();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new editing());
        }
    }
}
