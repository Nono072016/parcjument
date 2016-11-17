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

namespace Progiciel_gestion.Vues
{
    /// <summary>
    /// Logique d'interaction pour Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void buttonAddHorse_Click(object sender, RoutedEventArgs e)
        {
            Window add = new Vues.addHorse();
            add.Show();
            this.Close();
        }

        private void buttonListHorse_Click(object sender, RoutedEventArgs e)
        {
            Window list = new Vues.listHorse();
            list.Show();
            this.Close();
        }

    }
}
