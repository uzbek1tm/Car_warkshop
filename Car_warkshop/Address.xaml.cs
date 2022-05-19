using System.Windows.Controls;

namespace Car_warkshop
{
    public partial class Address : Page
    {
        public Address()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }
    }
}
