using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_FETA_RESTO
{
    public class Reservation
    {
        private int noResa;
        private int idUser;
        private DateTime dateResa;
        private double montant;
        private String adressLivraison;

        public Reservation(int NoResa,int IdUser, double Montant, String AdressLivraison)
        {
            this.noResa = NoResa;
            this.idUser = IdUser;
            this.dateResa = DateTime.Now;
            this.montant = Montant;
            this.adressLivraison = AdressLivraison;
        }

        public int GetNoResa()
        {
            return this.noResa;
        }
        public int GetIdUser()
        {
            return this.idUser;
        }
        public DateTime GetDateResa()
        {
            return this.dateResa;
        }
        public double GetMontant()
        {
            return this.montant;
        }
        public String GetAdressLivraison()
        {
            return this.adressLivraison;
        }

    }
}
