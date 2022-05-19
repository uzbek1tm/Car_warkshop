using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Car_warkshop
{
    public partial class Аuthorization : Page
    {
        
        public Аuthorization()
        {
            InitializeComponent();
        }

        public static int id_client;

        private void BtnEntrance_cabinet_Click(object sender, RoutedEventArgs e)   
        { 
            using(Car_warkshopEntities db = new Car_warkshopEntities())
            {
                
                var sql1 = (from user in db.Admins.ToList()
                           where user.Login_admin == Login.Text && user.Password_admin == Password.Password
                           select user).FirstOrDefault();
                if (sql1 != null)
                {
                    MessageBox.Show("Авторизация прошла!");
                    Manager.MainFrame.Navigate(new editing());
                }
                else
                {

                    var sql2 = (from user in db.Customer_data.ToList()
                                where user.Login_client == Login.Text && user.Password_client == Password.Password
                                select user.Id_client).FirstOrDefault();

                    id_client = sql2;


                    if (sql2 != 0)
                    {
                        MessageBox.Show("Авторизация прошла!");
                        Manager.MainFrame.Navigate(new Go());
                    }
                    else
                        MessageBox.Show("Авторизация не прошла!");
                }
            }
        }

        private void BtnReg_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Registration(null));
        }
    }
}
