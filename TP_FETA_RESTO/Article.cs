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
        private String descArticle;
        private String photoArticle;
        private String typeArticle;

        public Article(int NoArticle, String NomArticle, String DescArticle, String PhotoArticle, String TypeArticle)
        {
            this.noArticle = NoArticle;
            this.nomArticle = NomArticle;
            this.descArticle = DescArticle;
            this.photoArticle = PhotoArticle;
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
        public String GetDescArticle()
        {
            return this.descArticle;
        }
        public String GetPhotoArticle()
        {
            return this.photoArticle;
        }
        public String GetTypeArticle()
        {
            return this.typeArticle;
        }
    }
}
