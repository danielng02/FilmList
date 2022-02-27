using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Threading;

namespace FilmList
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Film f;
        public MainWindow()
        {
            InitializeComponent();
            List.DataContext = Film.films;
            watchedMark.Visibility = Visibility.Hidden;
            star.Visibility = Visibility.Hidden;
        }

        void AddFilm(object sender, RoutedEventArgs e)
        {
            EditWindow editWindow = new EditWindow();
            editWindow.Show();
        }

        void DeleteFilm(object sender, RoutedEventArgs e)
        {
            if (List.SelectedItems.Count > 0)
            {
                Film.films.Remove((Film)List.SelectedItem);
            }
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
            if (f != null)
            {
                star.Visibility = Visibility.Visible;
                if (f.Watched)
                {
                    watchedMark.Visibility = Visibility.Visible;
                }
                else
                {
                    watchedMark.Visibility = Visibility.Hidden;
                }
            }
            else
            {
                watchedMark.Visibility = Visibility.Hidden;
                star.Visibility = Visibility.Hidden;
                ratingLabel.Visibility = Visibility.Hidden;
            }
        }
        private void Search_Click(object sender, RoutedEventArgs e)
        {
            if (List.SelectedItems.Count > 0)
            {
                Process.Start(String.Format("http://www.google.com/search?q={0}", ((Film)List.SelectedItem).Name));
            }
        }

        private void SearchY_Click(object sender, RoutedEventArgs e)
        {
            if (List.SelectedItems.Count > 0)
            {
                Process.Start(String.Format("http://www.youtube.com/search?q={0}", ((Film)List.SelectedItem).Name));
            }
        }

    }

}

