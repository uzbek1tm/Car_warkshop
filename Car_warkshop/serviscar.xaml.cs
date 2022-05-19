using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Car_warkshop
{
    public partial class serviscar : Page
    {
        public serviscar()
        {
            InitializeComponent();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Add((sender as Button).DataContext as Servis));
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Add(null));
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var servisForRemoving = DGridServis.SelectedItems.Cast<Servis>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующую {servisForRemoving.Count()} элементов?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    Car_warkshopEntities.GetContext().Servis.RemoveRange(servisForRemoving);
                    Car_warkshopEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");

                    DGridServis.ItemsSource = Car_warkshopEntities.GetContext().Servis.ToList();
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
                DGridServis.ItemsSource = Car_warkshopEntities.GetContext().Servis.ToList();
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new editing());
        }
    }
}
