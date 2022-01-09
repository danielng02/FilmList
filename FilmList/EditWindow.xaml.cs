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

namespace FilmList
{
    /// <summary>
    /// Interakční logika pro EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        public bool existingItem;
        public EditWindow()
        {
            InitializeComponent();
            DataContext = new Film();
            existingItem = false;
        }
        public EditWindow(Object f)
        {
            InitializeComponent();
            DataContext = f;
            existingItem = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Film.films.Add((Film)DataContext);
            this.Close();
        }
    }
}
