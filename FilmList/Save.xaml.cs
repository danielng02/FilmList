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
using System.Xml.Serialization;
using System.IO;
using System.Collections.ObjectModel;

namespace FilmList
{
    /// <summary>
    /// Interakční logika pro Save.xaml
    /// </summary>
    public partial class Save : Window
    {
        public Save()
        {
            InitializeComponent();
        }

        private void Yes_Click(object sender, RoutedEventArgs e)
        {
            XmlSerializer xs = new XmlSerializer(typeof(ObservableCollection<Film>));
            using (StreamWriter wr = new StreamWriter(Properties.Resources.films))
            {
                xs.Serialize(wr, Film.films);
            }
        }

        private void No_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
