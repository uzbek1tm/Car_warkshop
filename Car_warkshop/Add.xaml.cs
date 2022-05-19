using System;
using System.Windows;
using System.Windows.Controls;

namespace Car_warkshop
{
    public partial class Add : Page
    {
        private Servis _currentServis = new Servis();
        public Add(Servis selectedServis)
        {
            InitializeComponent();

            if (selectedServis != null)
                _currentServis = selectedServis;

            DataContext = _currentServis;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (_currentServis.Id_servis == 0)
                Car_warkshopEntities.GetContext().Servis.Add(_currentServis);
            try { 
            Car_warkshopEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена!");
                Manager.MainFrame.GoBack();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new serviscar());
        }
    }
}
