using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Car_warkshop
{
    public partial class Mechanic : Page
    {
        public Mechanic()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Add_machanic(null));
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Add_machanic((sender as Button).DataContext as Car_mechanic));
        }
       
        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var servisForRemoving = DGridMechanic.SelectedItems.Cast<Car_mechanic>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующую {servisForRemoving.Count()} элементов?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    Car_warkshopEntities.GetContext().Car_mechanic.RemoveRange(servisForRemoving);
                    Car_warkshopEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");

                    DGridMechanic.ItemsSource = Car_warkshopEntities.GetContext().Car_mechanic.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                DGridMechanic.ItemsSource = Car_warkshopEntities.GetContext().Car_mechanic.ToList();
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new editing());
        }
    }
}
