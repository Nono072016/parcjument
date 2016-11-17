using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Progiciel_gestion.Classes
{
    class Utilisateur
    {
        private string utilNom;
        private string utilPrenom;
        private string utilLogin;
        private string utilPassword;


        public Utilisateur()
        {
        }

        public Utilisateur(string login, string password)
        {
            this.utilLogin = login;
            this.utilPassword = password;
        }

        public string getNom()
        {
            return this.utilNom;
        }
        public string getPrenom()
        {
            return this.utilPrenom;
        }
        
        public string getLogin()
        {
            return this.utilLogin;
        }

        public string getPassword()
        {
            return this.utilPassword;
        }

        public string connect()
        {
            string utilisateur = null;
            try
            {
                DataTable dataTableUtilisateur = new DataTable();
                string sql="SELECT * FROM UTILISATEUR where login = '"+ utilLogin+"' AND password='"+utilPassword+"'";
                dataTableUtilisateur = Classes.DAO.executeQuery(sql);
                foreach (DataRow maLigne in dataTableUtilisateur.Rows)
                {
                    utilNom = maLigne[3].ToString();
                    utilPrenom = maLigne[4].ToString();
                    utilisateur = utilNom + utilPrenom;
                }
            }
            catch (InvalidCastException e)
            {
                throw (e);
            }
            return utilisateur;
        }
    }
}
