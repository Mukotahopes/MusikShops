using BLL;
using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ShopMusik
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BLogin_Click(object sender, RoutedEventArgs e)
        {
             EfContext db = new EfContext();

            if (User_Check.IsChecked.Value == true)
            {
                foreach (var n in db.Users)
                {

                    if (n.Username == tLogin.Text && n.Password == tPassword.Text)
                    {
                        Menu_User m = new Menu_User();
                        m.Show();
                        this.Close();
                    }
                    else { MessageBox.Show("Your password or username wrong"); }

                }
            }
            else
            if (Authors_Check.IsChecked.Value == true)
            {
                foreach (var n in db.Authors)
                {
                    if (n.Username == tLogin.Text && n.Password == tPassword.Text)
                    {
                        Menu_Authors m = new Menu_Authors();
                        m.Show();
                        this.Close();
                    }
                    else { MessageBox.Show("Your password or username wrong"); }
                }

            }
            else { MessageBox.Show("Your password or username wrong"); }
           

                   
                
               
        }

        private void BRegister_Click(object sender, RoutedEventArgs e)
        {
            EfContext db = new EfContext();
            if (User_Check.IsChecked.Value == true)
            {
                User user = new User()
                {

                    Username = tLogin.Text,
                    Password = tPassword.Text,
                    Name = tName.Text
                };
                db.Users.Add(user);
            }
            else
            {

                Authors author = new Authors()
                {

                    Username = tLogin.Text,
                    Password = tPassword.Text,
                    Name = tName.Text

                };

                db.Authors.Add(author);
            }

           
            db.SaveChanges();
            MessageBox.Show("You are register");
        }
    }
}

