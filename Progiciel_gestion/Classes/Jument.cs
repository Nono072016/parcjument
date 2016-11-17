using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Progiciel_gestion.Classes
{
    class Jument
    {
        private int idJument;
        private string nomJument;
        private string raceJument;
        private DateTime dateNaissance;
        private int poidsJument;
        private List<Jument> lesJuments;

        public Jument()
        {
            lesJuments=new List<Jument>();
        }

        public Jument(string nom, string race, int poids, DateTime date )
        {
            this.nomJument = nom;
            this.raceJument = race;
            this.poidsJument = poids;
            this.dateNaissance = date;
        }

        public Jument(int id, string nom, string race, int poids, DateTime date)
        {
            this.idJument = id;
            this.nomJument = nom;
            this.raceJument = race;
            this.poidsJument = poids;
            this.dateNaissance = date;
        }

        public string getNomJument()
        {
            return this.nomJument;
        }

        public string getRaceJument()
        {
            return this.raceJument;
        }

        public int getPoidsJument()
        {
            return this.poidsJument;
        }

        public DateTime getDateNaissance()
        {
            return this.dateNaissance;
        }

        public string NomJument { get; set; }
        public int PoidsJument { get; set; }
        public DateTime DateNaissance { get; set; }
        public string RaceJument { get; set; }
        public int IdJument { get; set; }

        public void ajouterJument()
        {
            try
            {
                string sql= "INSERT INTO JUMENT(nom, dateNaissance, race, poids) VALUES ('"+nomJument+"','"+dateNaissance+"','"+raceJument+"',"+poidsJument+");";
                DAO.executeQuery(sql);
            }
            catch (InvalidCastException e)
            {
                throw (e);
            }

        }

        public List<Jument> listeJuments()
        {
            Jument j;
            DataTable dataTableJument = new DataTable();

            string sql = @"SELECT * FROM JUMENT";
            dataTableJument = Classes.DAO.executeQuery(sql);

            foreach (DataRow k in dataTableJument.Rows)
            {
                j = new Jument
                {
                IdJument= Convert.ToInt32(k[0].ToString()),
                NomJument = k[1].ToString(),
                DateNaissance=Convert.ToDateTime(k[2].ToString()),
                RaceJument= k[3].ToString(),
                PoidsJument= Convert.ToInt32(k[4].ToString())
                };

                lesJuments.Add(j);
 
            }
            return lesJuments;
        }

        public void modifierJMT()
        {
            try
            {
                string sql = @"UPDATE JUMENT SET nom='" + nomJument + "', race='" + raceJument + "', poids=" + poidsJument + ", dateNaissance='" + dateNaissance + "' WHERE id=" + idJument;
                DAO.executeQuery(sql);

            }
            catch (InvalidCastException e)
            {
                throw (e);
            }
        }
    }
}
