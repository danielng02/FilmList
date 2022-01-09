using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        //ObservableCollection<Film> films = new ObservableCollection<Film>();

        public MainWindow()
        {
            InitializeComponent();
            List.DataContext = Film.films;
            Film.films.Add(new Film());
        }

        void AddFilm(object sender, RoutedEventArgs e)
        {
            EditWindow editWindow = new EditWindow();
            editWindow.Show();
        }

        void DeleteFilm(object sender, RoutedEventArgs e)
        {
            
        }

        private void List_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Film film = (Film)((ListView)sender).SelectedItem;
            EditWindow edit = new EditWindow(film);
            edit.ShowDialog();
        }

        private void List_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Film f = (Film)((ListView)sender).SelectedItem;
            DataContext = f;
        }
    }

}

