using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_FETA_RESTO
{
    public class Compte
    {
        private int IdUser;
        private String motdePasse;
        private String nom;
        private String prenom;
        private DateTime dateInscrip;
        private String adressMail;
        private String noTel;
        private String typeCompte;

        public Compte(int idUser, string MotdePasse, string Nom, string Prenom, DateTime DateInscrip, string AdressMail, string NoTel, string TypeCompte)
        {
            this.IdUser = idUser;
            this.motdePasse = MotdePasse;
            this.nom = Nom;
            this.prenom = Prenom;
            this.dateInscrip = DateInscrip;
            this.adressMail = AdressMail;
            this.noTel = NoTel;
            this.typeCompte = TypeCompte;
        }

        public int GetIdUser()
        {
            return this.IdUser;
        }
        public String GetMotDePasse()
        {
            return this.motdePasse;
        }
        public String GetNom()
        {
            return this.nom;
        }
        public String GetPrenom()
        {
            return this.prenom;
        }
        public DateTime GetDateInscrip()
        {
            return this.dateInscrip;
        }
        public String GetAdressMail()
        {
            return this.adressMail;
        }
        public String GetnoTel()
        {
            return this.noTel;
        }
        public String GetTypeCompte()
        {
            return this.typeCompte;
        }

    }
}
