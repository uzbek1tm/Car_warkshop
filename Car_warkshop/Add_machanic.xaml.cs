using System;
using System.Windows;
using System.Windows.Controls;

namespace Car_warkshop
{
    public partial class Add_machanic : Page
    {
        private Car_mechanic _currentCar_mechanic = new Car_mechanic();
        public Add_machanic(Car_mechanic selectedCar_mechanic)
        {
            InitializeComponent();

            if (selectedCar_mechanic != null)
                _currentCar_mechanic = selectedCar_mechanic;

            DataContext = _currentCar_mechanic;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (_currentCar_mechanic.Id_mechanic == 0)
                Car_warkshopEntities.GetContext().Car_mechanic.Add(_currentCar_mechanic);
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

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new editing());
        }
    }
}
