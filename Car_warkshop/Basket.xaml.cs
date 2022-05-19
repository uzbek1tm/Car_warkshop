using System.Windows;
using System.Windows.Controls;

namespace Car_warkshop
{
    public partial class Basket : Page
    {
        public Basket()
        {
            InitializeComponent();
            Dg.ItemsSource = Go.list_servis;

        }
        private void BtnOrdert_Click(object sender, RoutedEventArgs e)
        {
             
            var rezultat = MessageBox.Show("Оформить заказ?", "Оформлено", MessageBoxButton.YesNo);
            switch (rezultat)
            {
                case MessageBoxResult.Yes:
                    Go.list_servis = new System.Collections.Generic.List<Servis>();
                    MessageBox.Show("Cпасибо за заказ!\nС вами свяжутся.");
                    Manager.MainFrame.Navigate(new Go());
                    break;
                case MessageBoxResult.No:
                    break;
                default:
                    break;
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Go());
        }
    }
}