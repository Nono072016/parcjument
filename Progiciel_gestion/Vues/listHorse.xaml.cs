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
using System.Data;
using System.Data.SqlClient;
using Progiciel_gestion.Classes;
using Progiciel_gestion.Vues;

namespace Progiciel_gestion.Vues
{
    /// <summary>
    /// Logique d'interaction pour listHorse.xaml
    /// </summary>
    public partial class listHorse : Window
    {
        
        
        public listHorse()
        {
            Jument jument = new Jument();
            InitializeComponent();
            listJument.ItemsSource = jument.listeJuments();

            
        }

        public void nonVisible()
        {
            lbJument.Visibility = Visibility.Hidden;
            lbNom.Visibility = Visibility.Hidden;
            btnModifier.Visibility = Visibility.Hidden;
            lbRace.Visibility = Visibility.Hidden;
            lbPoids.Visibility = Visibility.Hidden;
            lbDate.Visibility = Visibility.Hidden;
            dateNaissance.Visibility = Visibility.Hidden;
            txtNom.Visibility = Visibility.Hidden;
            txtRace.Visibility = Visibility.Hidden;
            txtPoids.Visibility = Visibility.Hidden;
        }
     

        private void listJument_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            DataGridRow row;
            if (listJument.SelectedItem == null) return;
            row = (DataGridRow)listJument.ItemContainerGenerator.ContainerFromIndex(listJument.SelectedIndex);
            Jument laJument = (Jument)listJument.SelectedItem;
            lbJument.Content = laJument.IdJument;

            lbJument.Visibility = Visibility.Visible;
            lbNom.Visibility = Visibility.Visible;
            btnModifier.Visibility = Visibility.Visible;
            lbRace.Visibility = Visibility.Visible;
            lbPoids.Visibility = Visibility.Visible;
            lbDate.Visibility = Visibility.Visible;
            dateNaissance.Visibility = Visibility.Visible;
            txtNom.Visibility = Visibility.Visible;
            txtRace.Visibility = Visibility.Visible;
            txtPoids.Visibility = Visibility.Visible;
        }

        private void btnModifier_Click(object sender, RoutedEventArgs e)
        {
            string date = dateNaissance.ToString();
            if( txtNom.Text!="" && txtRace.Text!="" && txtPoids.Text!="" && date != "")
            {
                int laJument = int.Parse(lbJument.Content.ToString());
                int lePoids= int.Parse(txtPoids.Text);
                DateTime laDate = Convert.ToDateTime(dateNaissance.ToString());
                Jument jmt;

                jmt = new Jument(laJument, txtNom.Text, txtRace.Text, lePoids, laDate);

                try
                {
                    jmt.modifierJMT();
                    MessageBox.Show("Modification enregistré avec succès !");
                    listJument.Items.Refresh();
                    lbJument.Visibility = Visibility.Hidden;
                    lbNom.Visibility = Visibility.Hidden;
                    btnModifier.Visibility = Visibility.Hidden;
                    lbRace.Visibility = Visibility.Hidden;
                    lbPoids.Visibility = Visibility.Hidden;
                    lbDate.Visibility = Visibility.Hidden;
                    dateNaissance.Visibility = Visibility.Hidden;
                    txtNom.Visibility = Visibility.Hidden;
                    txtRace.Visibility = Visibility.Hidden;
                    txtPoids.Visibility = Visibility.Hidden;


                }catch
                {
                    MessageBox.Show("Une erreur s'est produite lors de l'enregistrement de la modification ! Veuillez réessayer !");
                }
            }
            else
            {
                MessageBox.Show("Un ou plusieurs champs ne sont pas renseignés ! Merci de vérifier !");
            }
            
        }


    }
}
