using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;

namespace TP_FETA_RESTO
{
    public static class ORMmySQL
    {
        public static Compte CurrentUser = null; 
        public static int _counterForm = 0; // permet de renomé et supprimer les formulaire voulu
        public static List<int> Panier = new List<int>();
        // Note
        // ExecuteNonQuery() -> int  uptade/insert/delete 
        // ExecuteReader() -> table  Select
        // ExecuteScalar() -> objet  Si on veux resevoir un object

        private static String cs = @"server=localhost;userid=fetaresto;password=;database=feta_resto";
        private static MySqlConnection conn = null;

        public static bool ConnexionDB()
        {
            conn = new MySqlConnection(cs);
            conn.Open();
            return (conn.State == ConnectionState.Open);
        }

        public static Compte ConnexionCompte(String AdrMail, String MDP)
        {
            MySqlCommand objCmd;
            objCmd = conn.CreateCommand();
            MySqlDataReader rdr;

            String reqCount = $"SELECT * FROM compte WHERE ADRMAILCPTE = '{AdrMail}' AND MDP = '{MDP}'";
            objCmd.CommandText = reqCount;
            rdr = objCmd.ExecuteReader();
            Compte p = null;
            if (rdr.Read())
            {
                p = new Compte((int)rdr["idUser"], (String)rdr["MDP"], (String)rdr["NOMCPTE"], (String)rdr["PRENOMCPTE"], (DateTime)rdr["DATEINSCRIP"], (String)rdr["ADRMAILCPTE"],(String)rdr["NOTELCPTE"],(String)rdr["TYPECOMPTE"]);

            }
            rdr.Close();
            return p;
        }

        public static bool UpdateCompte(String Nom, String Prenom, String AdresseMail, String NoTel)
        {
            Compte currentCompte = ORMmySQL.CurrentUser;
            if (currentCompte == null)
            {
                return false;
            }
            else
            {
                MySqlCommand objCmd;
                objCmd = conn.CreateCommand();
                String reqU = $"UPDATE compte SET NOMCPTE = '{Nom}',PRENOMCPTE = '{Prenom}',ADRMAILCPTE = '{AdresseMail}',NOTELCPTE = '{NoTel}' WHERE idUser = '{currentCompte.GetIdUser().ToString()}' ";
                objCmd.CommandText = reqU;
                int nbMaj = objCmd.ExecuteNonQuery();
                if (nbMaj == 0)
                {
                    return false;
                }
            }
            return true;
        }


        public static List<Formule> GetAllFormules()
        {
            MySqlCommand objCmd;
            objCmd = conn.CreateCommand();
            MySqlDataReader rdr;
            List<Formule> TouteLesFormule = new List<Formule>();


            String reqCount = $"SELECT * FROM formules";
            objCmd.CommandText = reqCount;
            rdr = objCmd.ExecuteReader();
            while (rdr.Read())
            {
                Formule f = new Formule((int)rdr["NOFORMULE"], (String)rdr["NOMFORMULE"], (float)rdr["PRIXFORMULE"]);
                TouteLesFormule.Add(f);
            }
            rdr.Close();
            return TouteLesFormule;
        }

    }
}
