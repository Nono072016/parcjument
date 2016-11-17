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
using Progiciel_gestion.Classes;

namespace Progiciel_gestion.Vues
{
    /// <summary>
    /// Logique d'interaction pour addHorse.xaml
    /// </summary>
    public partial class addHorse : Window
    {
        public addHorse()
        {
            InitializeComponent();
        }


        private void btnAjouter_Click(object sender, RoutedEventArgs e)
        {
            
            if (txtBoxNom.Text != "" && txtBoxPoids.Text!="" && txtBoxRace.Text!="" && datePicker.ToString() !="")
            {
                DateTime laDate= Convert.ToDateTime(datePicker.ToString());
                int poids = Convert.ToInt32(txtBoxPoids.Text);

                Jument jument = new Jument(txtBoxNom.Text, txtBoxRace.Text, poids, laDate);
                try
                {
                    jument.ajouterJument();
                    MessageBox.Show("Nouvelle jument ajoutée à la base de données avec succès");
                    txtBoxNom.Clear();
                    txtBoxPoids.Clear();
                    txtBoxRace.Clear();
                    Window menu = new Vues.Dashboard();
                    menu.Show();
                    this.Close();

                }
                catch{
                    MessageBox.Show("Une erreur s'est produite lors de l'ajout à la base veuillez réessayez ou contacter l'administrateur du logiciel");
                }
            }
        }
    }
}
