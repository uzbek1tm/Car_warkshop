using System;
using System.Windows;
using System.Windows.Controls;

namespace Car_warkshop
{
    public partial class Registration : Page
    {
        private Customer_data _currentCustomer_data = new Customer_data();
        public Registration(Customer_data selectedCustomer_data)
        {
            InitializeComponent();

            if (selectedCustomer_data != null)
                _currentCustomer_data = selectedCustomer_data;

            DataContext = _currentCustomer_data;
        }

        private void BtnRegistration_Click(object sender, RoutedEventArgs e)
        {
            if (_currentCustomer_data.Id_client >= 0)
                Car_warkshopEntities.GetContext().Customer_data.Add(_currentCustomer_data);
            try
            {
                Car_warkshopEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена!");
                Manager.MainFrame.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void BtnAuthorization_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Аuthorization());
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Аuthorization());
        }
    }
}
