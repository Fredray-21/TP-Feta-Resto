using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_FETA_RESTO
{
    public class Article
    {
        private int noArticle;
        private String nomArticle;
        private String typeArticle;

        public Article(int NoArticle, String NomArticle, String TypeArticle)
        {
            this.noArticle = NoArticle;
            this.nomArticle = NomArticle;
            this.typeArticle = TypeArticle;

        }
       
        public int GetIdArticle()
        {
            return this.noArticle;
        }
        public String GetNomArticle()
        {
            return this.nomArticle;
        }
       
        public String GetTypeArticle()
        {
            return this.typeArticle;
        }

        public override string ToString()
        {
            return $"{this.nomArticle}";
        }
    }
}
