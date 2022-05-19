using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Car_warkshop
{
    public partial class Go : Page
    {
        public static List<Servis> list_servis = new List<Servis>();
        public Go()
        {
            InitializeComponent();

            UpdateServis();
        }

        private void UpdateServis()
        {
            var currentServis = Car_warkshopEntities.GetContext().Servis.ToList();
            currentServis = currentServis.Where(p => p.Servis1.ToLower().Contains(TBoxSearch.Text.ToLower())).ToList();

            ViewServis.ItemsSource = currentServis;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new serviscar());

        }

        private void BtnBuy_Click(object sender, RoutedEventArgs e)
        {
            var id_servis = ((sender as Button).DataContext as Servis).Id_servis;
            list_servis.Add((sender as Button).DataContext as Servis);
            using(Car_warkshopEntities db = new Car_warkshopEntities())
            {
                Choice_services choice_Services = new Choice_services()
                {
                    Id_client = Аuthorization.id_client,
                    Id_servis = id_servis,
                    Date_order = DateTime.Now
                };
                db.Choice_services.Add(choice_Services);
                db.SaveChanges();
            }
        }

        private void TBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateServis();
        }

        private void ComboType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateServis();
        }

        private void BtnBasket_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Basket());
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Аuthorization());
        }
    }
}
