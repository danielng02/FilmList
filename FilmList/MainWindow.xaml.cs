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

namespace FilmList
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Film> films = new List<Film>();

        public MainWindow()
        {
            InitializeComponent();
            List.DataContext = films;
        }

        void AddFilm(object sender, RoutedEventArgs e)
        {
            App createWindow = new App();
            createWindow.Show();
        }

        void DeleteFilm(object sender, RoutedEventArgs e)
        {
            
        }

    }

}

