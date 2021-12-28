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
        private String desc;

        private List<Article> ListArticles = new List<Article>();

        public Formule(int NoFormule, String NomFormule, float PrixFormule, String Description)
        {
            this.noFormule = NoFormule;
            this.nomFormule = NomFormule;
            this.prixFormule = PrixFormule;
            this.desc = Description;

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
        public String GetDescFormule()
        {
            return this.desc;
        }


        public override string ToString()
        {
            return $"N°{this.noFormule} - {this.nomFormule} - {this.prixFormule}€";
        }


        public override bool Equals(Object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Formule f = (Formule)obj;
                return (this.noFormule == f.GetIdFormule());
            }
        }
    }
}
