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
using Progiciel_gestion.Classes;
using System.Data.SqlClient;
using System.Data;

namespace Progiciel_gestion
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string utilisateur = null;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonValider_Click(object sender, RoutedEventArgs e)
        {
            if( txtBoxLogin.Text !="" && txtBoxPassword.ToString() !="")
            {
                string password = txtBoxPassword.Password;
                utilisateur = txtBoxLogin.Text + " " + password;
                Utilisateur utili = new Utilisateur(txtBoxLogin.Text, password);
                utilisateur = utili.getLogin() + " " + utili.getPassword();
                utilisateur = utili.connect();
                if(utilisateur!= null)
                {
                    Window dashboard = new Vues.Dashboard();
                    dashboard.Show();
                    this.Close();
                }
                else
                {
                    lbMessage.Content = "Mot de passe invalide !";
                    txtBoxLogin.Clear();
                    txtBoxPassword.Clear();
                }
                
            }
            else
            {
                MessageBox.Show("Un ou plusieurs champs non renseignés !! Veuillez saisir tous les champs !!");
            }
        }

        private void buttonCancel_Click(object sender, RoutedEventArgs e)
        {
            
            txtBoxLogin.Clear();
            txtBoxPassword.Clear();
        
        }

        
       
    }
}
