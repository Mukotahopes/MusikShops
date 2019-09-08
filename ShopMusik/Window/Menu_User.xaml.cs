using BLL.Entities;
using ShopMusik.Model;
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
using System.Windows.Shapes;

namespace ShopMusik
{
    /// <summary>
    /// Interaction logic for Menu_User.xaml
    /// </summary>
    public partial class Menu_User : Window
    {
        public Menu_User()
        {
            InitializeComponent();
        }

        private void bLoad_Click(object sender, RoutedEventArgs e)
        {
            EfContext context = new EfContext();
            var music = context.Musics.AsQueryable();
            Genre g = new Genre() { };
            Authors a = new Authors();
            var list = music.Select(t => new MusicModel()
            {
                Name = t.Name,
                Price=t.Price,
                Genre= 
                //Authors=a.Name

            }).ToList();
            ListMusic.ItemsSource = list;
        }
    }
}
