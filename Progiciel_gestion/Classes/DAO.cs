using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows;

namespace Progiciel_gestion.Classes
{
    class DAO
    {
        private static SqlConnection maConnexion;

        private static SqlConnection connexion()
        {
            maConnexion = new SqlConnection(@"Data Source=NONO;Initial Catalog=Parc_Jument;Integrated Security=True");
            maConnexion.Open();
            return maConnexion;
        }

        public static bool deconnexion()
        {
            Boolean okDeco = true;
            try
            {
                maConnexion.Close();
                okDeco = true;

            }
            catch (Exception e)
            {
                MessageBoxResult result = MessageBox.Show("Erreur" + e + ",\n Impossible de se déconnecter", "Fermeture impossible", MessageBoxButton.OK);

            }
            return okDeco;
        }

        public static DataTable executeQuery(string leSelect)
        {
            //récupération des données dans un tableau à 2 dimensions
            DataTable laDataTable = new DataTable();

            //éxécution de la requête  sur la connexion à la base de données
            //spécifiée (on adapte  la requête à la connexion voulu)

            SqlDataAdapter monAdaptateur = new SqlDataAdapter(leSelect, connexion());
            monAdaptateur.Fill(laDataTable);
            return laDataTable;
        }

        public static void executeMajBdd(string sql)
        {
            //déclaration de l'objet cmd de type SqlCommand
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;

            // on passe le paramètre qui est une requête sql
            cmd.CommandText = sql;

            // on ouvre la connexion a la bdd
            cmd.Connection = maConnexion;

            //on lance l'exécution de la requête
            cmd.ExecuteNonQuery();
        }
    }
}
