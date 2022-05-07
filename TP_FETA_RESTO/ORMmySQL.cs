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
        public static Compte CurrentUser = null!;
        public static int _counterForm = 0; // permet de renomé et supprimer les formulaire voulu
        public static List<Formule> Panier = new List<Formule>();
        // Note
        // ExecuteNonQuery() -> int  uptade/insert/delete 
        // ExecuteReader() -> table  Select
        // ExecuteScalar() -> objet  Si on veux resevoir un object

        private static String cs = @"server=localhost;userid=fetaresto;password=;database=feta_resto";
        private static MySqlConnection conn = null!;

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
            Compte p = null!;
            if (rdr.Read())
            {
                p = new Compte((int)rdr["idUser"], (String)rdr["MDP"], (String)rdr["NOMCPTE"], (String)rdr["PRENOMCPTE"], (DateTime)rdr["DATEINSCRIP"], (String)rdr["ADRMAILCPTE"], (String)rdr["NOTELCPTE"], (String)rdr["TYPECOMPTE"]);
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
                Formule f = new Formule((int)rdr["NOFORMULE"], (String)rdr["NOMFORMULE"], (float)rdr["PRIXFORMULE"], (String)rdr["DESCFORMULE"]);
                TouteLesFormule.Add(f);
            }
            rdr.Close();
            return TouteLesFormule;
        }

        public static Formule GetFormule(int NOFORMULE)
        {
            MySqlCommand objCmd;
            objCmd = conn.CreateCommand();
            MySqlDataReader rdr;

            String reqCount = $"SELECT * FROM formules WHERE NOFORMULE = {NOFORMULE}";
            objCmd.CommandText = reqCount;
            rdr = objCmd.ExecuteReader();
            Formule f = null!;
            if (rdr.Read())
            {
                f = new Formule((int)rdr["NOFORMULE"], (String)rdr["NOMFORMULE"], (float)rdr["PRIXFORMULE"], (String)rdr["DESCFORMULE"]);
            }
            rdr.Close();
            return f;
        }

        public static bool AjouterArticle(String Nom, String TypeArticle)
        {
            MySqlCommand objCmd;
            objCmd = conn.CreateCommand();

            String reqI = $"INSERT INTO articles (NOMARTICLE,TYPEARTICLE) VALUES(\"{Nom}\",'{TypeArticle}')";
            objCmd.CommandText = reqI;
            int nbMaj = objCmd.ExecuteNonQuery();
            return (nbMaj == 1);

        }

        public static List<Article> GetAllArticles()
        {
            MySqlCommand objCmd;
            objCmd = conn.CreateCommand();
            MySqlDataReader rdr;
            List<Article> ToutLesArticles = new List<Article>();

            String reqCount = $"SELECT * FROM articles";
            objCmd.CommandText = reqCount;
            rdr = objCmd.ExecuteReader();
            while (rdr.Read())
            {
                Article a = new Article((int)rdr["NOARTICLE"], (String)rdr["NOMARTICLE"], (String)rdr["TYPEARTICLE"]);
                ToutLesArticles.Add(a);
            }
            rdr.Close();
            return ToutLesArticles;
        }



        public static bool AjouterFormule(List<Article> lesArticleSelected, String Nom, float Prix, String DescF, byte[] img)
        {
            MySqlCommand objCmd;
            objCmd = conn.CreateCommand();
            float NOFORMULE = -1;

            String reqI = $"INSERT INTO formules (NOMFORMULE,PRIXFORMULE,DESCFORMULE,PHOTOFORMULE) VALUES('{Nom}','{Prix}','{DescF}',@img)";
            objCmd.CommandText = reqI;

            objCmd.Parameters.Add("@img", MySqlDbType.MediumBlob);
            objCmd.Parameters["@img"].Value = img;

            int nbMaj = objCmd.ExecuteNonQuery();
            if (nbMaj == 1)
            {
                String reqNumId = "SELECT LAST_INSERT_ID()";
                objCmd.CommandText = reqNumId;
                object result = objCmd.ExecuteScalar();
                bool convertOK = float.TryParse(result.ToString(), out float id);

                if (convertOK)
                {
                    NOFORMULE = id;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            //fin ajoute table formule

            objCmd = conn.CreateCommand();
            String reqI2 = $"";
            foreach (Article a in lesArticleSelected)
            {
                reqI2 = reqI2 + $"INSERT INTO contient (NOFORMULE,NOARTICLE) VALUES({NOFORMULE},{a.GetIdArticle()});";
            }

            objCmd.CommandText = reqI2;
            objCmd.ExecuteNonQuery();
            return true;
        }


        public static List<Article> GetAllArticleParIdFormule(int IdFormule)
        {
            MySqlCommand objCmd;
            objCmd = conn.CreateCommand();
            MySqlDataReader rdr;
            List<Article> LesArticleDeLaFormule = new List<Article>();

            String reqCount = $"SELECT articles.*,formules.NOFORMULE FROM formules JOIN contient ON formules.NOFORMULE = contient.NOFORMULE JOIN articles ON contient.NOARTICLE = articles.NOARTICLE WHERE formules.NOFORMULE = {IdFormule}";
            objCmd.CommandText = reqCount;
            rdr = objCmd.ExecuteReader();
            while (rdr.Read())
            {
                Article a = new Article((int)rdr["NOARTICLE"], (String)rdr["NOMARTICLE"], (String)rdr["TYPEARTICLE"]);
                LesArticleDeLaFormule.Add(a);
            }
            rdr.Close();
            return LesArticleDeLaFormule;
        }

        public static byte[] GetPictureFormule(int IdFormule)
        {
            MySqlCommand objCmd;
            objCmd = conn.CreateCommand();
            MySqlDataReader rdr;
            byte[] img = null!;

            String reqCount = $"SELECT PHOTOFORMULE from formules WHERE NOFORMULE = {IdFormule}";
            objCmd.CommandText = reqCount;
            rdr = objCmd.ExecuteReader();
            if (rdr.Read())
            {
                img = (byte[])rdr["PHOTOFORMULE"];
            }
            rdr.Close();
            return img;
        }

        public static bool DeleteFormule(int IdFormule)
        {
            MySqlCommand objCmd;
            objCmd = conn.CreateCommand();

            String reqCount = $"DELETE FROM formules WHERE NOFORMULE = {IdFormule}";
            objCmd.CommandText = reqCount;
            int nbMaj = objCmd.ExecuteNonQuery();
            return (nbMaj == 1);
        }
        public static bool DeleteArticle(int IdArticle)
        {
            MySqlCommand objCmd;
            objCmd = conn.CreateCommand();

            String reqCount = $"DELETE FROM articles WHERE NOARTICLE = {IdArticle}";
            objCmd.CommandText = reqCount;
            int nbMaj = objCmd.ExecuteNonQuery();
            return (nbMaj == 1);
        }


        public static bool AjouterReservation(double Prix, String AdresseLivr)
        {
            MySqlCommand objCmd;
            objCmd = conn.CreateCommand();
            float NORESA = -1;
            Prix = (float)Prix;

            String reqI = $"INSERT INTO reservation (idUser,DATERESA,MONTANT,ADRLIVR) VALUES('{ORMmySQL.CurrentUser.GetIdUser()}','{DateTime.Now.ToString("yyy/MM/dd HH:mm:ss")}','{Prix}','{AdresseLivr}')";
            objCmd.CommandText = reqI;


            int nbMaj = objCmd.ExecuteNonQuery();
            if (nbMaj == 1)
            {
                String reqNumId = "SELECT LAST_INSERT_ID()";
                objCmd.CommandText = reqNumId;
                object result = objCmd.ExecuteScalar();
                bool convertOK = float.TryParse(result.ToString(), out float id);

                if (convertOK)
                {
                    NORESA = id;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            //fin ajoute table reservation


            objCmd = conn.CreateCommand();
            String reqI2 = $"";
            foreach (Formule f in ORMmySQL.Panier)
            {
                reqI2 = reqI2 + $"INSERT INTO comporte (NORESA,NOFORMULE) VALUES({NORESA},{f.GetIdFormule()});";
            }

            objCmd.CommandText = reqI2;

            int nbMajj = objCmd.ExecuteNonQuery();
            if (nbMajj != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static List<Reservation> GetAllReservationParUser(Compte CompteCurrent)
        {
            MySqlCommand objCmd;
            objCmd = conn.CreateCommand();
            MySqlDataReader rdr;
            List<Reservation> LesReservationDuCompte = new List<Reservation>();

            String reqCount = $"SELECT reservation.* from reservation WHERE reservation.idUser = {CompteCurrent.GetIdUser()} ORDER BY reservation.DATERESA desc";
            objCmd.CommandText = reqCount;
            rdr = objCmd.ExecuteReader();
            while (rdr.Read())
            {
                Reservation r = new Reservation((int)rdr["NORESA"], (int)rdr["idUser"], (DateTime)rdr["DATERESA"], (float)rdr["MONTANT"], (String)rdr["ADRLIVR"]);

                LesReservationDuCompte.Add(r);
            }
            rdr.Close();
            return LesReservationDuCompte;
        }

        public static List<Reservation> GetAllReservation()
        {
            MySqlCommand objCmd;
            objCmd = conn.CreateCommand();
            MySqlDataReader rdr;
            List<Reservation> LesReservation = new List<Reservation>();

            String reqCount = $"SELECT reservation.* from reservation ORDER BY reservation.DATERESA desc";
            objCmd.CommandText = reqCount;
            rdr = objCmd.ExecuteReader();
            while (rdr.Read())
            {
                Reservation r = new Reservation((int)rdr["NORESA"], (int)rdr["idUser"], (DateTime)rdr["DATERESA"], (float)rdr["MONTANT"], (String)rdr["ADRLIVR"]);

                LesReservation.Add(r);
            }
            rdr.Close();
            return LesReservation;
        }


        public static List<Formule> GetAllFormuleParResa(Reservation r)
        {
            MySqlCommand objCmd;
            objCmd = conn.CreateCommand();
            MySqlDataReader rdr;
            List<Formule> LesFormuleDeLaRESA = new List<Formule>();

            String reqCount = $"SELECT * FROM reservation JOIN comporte ON reservation.NORESA = comporte.NORESA JOIN  formules ON comporte.NOFORMULE = formules.NOFORMULE WHERE reservation.NORESA = {r.GetNoResa()}";

            objCmd.CommandText = reqCount;
            rdr = objCmd.ExecuteReader();
            while (rdr.Read())
            {
                Formule f = new Formule((int)rdr["NOFORMULE"], (String)rdr["NOMFORMULE"], (float)rdr["PRIXFORMULE"], (String)rdr["DESCFORMULE"]);
                LesFormuleDeLaRESA.Add(f);
            }
            rdr.Close();
            return LesFormuleDeLaRESA;
        }

        public static bool UpdateArticle(int idArticle, String Nom, String TypeArticle)
        {
            MySqlCommand objCmd;
            objCmd = conn.CreateCommand();
            String reqU = $"UPDATE articles SET NOMARTICLE = '{Nom}',TYPEARTICLE = '{TypeArticle}' WHERE NOARTICLE = {idArticle}";
            objCmd.CommandText = reqU;
            int nbMaj = objCmd.ExecuteNonQuery();
            return (nbMaj == 1);
        }

        public static bool UpdateFormule(List<Article> lesArticleSelected, String Nom, float Prix, String DescF, byte[] img, int NOFORMULE)
        {
            MySqlCommand objCmd;
            objCmd = conn.CreateCommand();

            String reqI = $"UPDATE formules SET NOMFORMULE = '{Nom}',PRIXFORMULE = '{Prix}',DESCFORMULE = '{DescF}',PHOTOFORMULE = @img WHERE NOFORMULE = {NOFORMULE}";
            objCmd.CommandText = reqI;
            objCmd.Parameters.Add("@img", MySqlDbType.MediumBlob);
            objCmd.Parameters["@img"].Value = img;
            int nbMaj = objCmd.ExecuteNonQuery();
            if (nbMaj > 0)
            {
                objCmd = conn.CreateCommand();
                String reqCount = $"DELETE FROM contient WHERE NOFORMULE = {NOFORMULE}";
                objCmd.CommandText = reqCount;
                nbMaj = objCmd.ExecuteNonQuery();
                if (nbMaj > 0)
                {
                    objCmd = conn.CreateCommand();
                    String reqI2 = $"";
                    foreach (Article a in lesArticleSelected)
                    {
                        reqI2 = reqI2 + $"INSERT INTO contient (NOFORMULE,NOARTICLE) VALUES({NOFORMULE},{a.GetIdArticle()});";
                    }
                    objCmd.CommandText = reqI2;
                    objCmd.ExecuteNonQuery();
                    int nbMajj = objCmd.ExecuteNonQuery();
                    return (nbMajj > 0);
                }
                else return false;
            }
            else return false;
        }
    }
}
