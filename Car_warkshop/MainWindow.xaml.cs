using System;
using System.Windows;

namespace Car_warkshop
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new Аuthorization());
            Manager.MainFrame = MainFrame;
        }


        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {
            
        }

        private void BtnAddress_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Address());
        }
    }
}
