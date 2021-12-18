using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_FETA_RESTO
{
    public class Formule
    {
        private int noFormule;
        private String nomFormule;
        private double prixFormule;

        public Formule(int NoFormule,String NomFormule,double PrixFormule)
        {
            this.noFormule = NoFormule;
            this.nomFormule = NomFormule;
            this.prixFormule = PrixFormule;
        }

        public int GetIdFormule()
        {
            return this.noFormule;
        }
        public String GetNomFormule()
        {
            return this.nomFormule;
        }
        public double GetPrixFormule()
        {
            return this.prixFormule;
        }

    }
}
