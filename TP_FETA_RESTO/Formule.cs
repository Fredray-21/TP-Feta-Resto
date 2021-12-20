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
        private float prixFormule;
        private List<Article> ListArticles = new List<Article>();

        public Formule(int NoFormule,String NomFormule, float PrixFormule)
        {
            this.noFormule = NoFormule;
            this.nomFormule = NomFormule;
            this.prixFormule = PrixFormule;
            this.ListArticles = new List<Article>();
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


        public override string ToString()
        {
            return $"N°{this.noFormule} - {this.nomFormule} - {this.prixFormule}€";
        }
    }
}
