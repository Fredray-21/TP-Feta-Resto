using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_FETA_RESTO
{
    public partial class frmGestionAddFormule : Form
    {

        public frmGestionAddFormule()
        {
            InitializeComponent();
            List<Article> LesAticles = ORMmySQL.GetAllArticles();
            if (LesAticles != null)
            {
                foreach (Article a in LesAticles)
                {
                    if (a.GetTypeArticle() == "Entrée")
                    {
                        
                        listBentree.Items.Add((listBentree.Items.Count+1).ToString()+"|"+a.ToString());
                    }
                    else if (a.GetTypeArticle() == "Plat")
                    {
                        listBplat.Items.Add((listBplat.Items.Count + 1).ToString() + "|" + a.ToString());
                    }
                    else if (a.GetTypeArticle() == "Dessert")
                    {
                        listBdessert.Items.Add((listBdessert.Items.Count + 1).ToString() + "|" + a.ToString());
                    }
                    else if (a.GetTypeArticle() == "Supplément")
                    {
                        listBsupplement.Items.Add((listBsupplement.Items.Count + 1).ToString() + "|" + a.ToString());
                    }
                    else if (a.GetTypeArticle() == "Boisson")
                    {
                        listBboisson.Items.Add((listBboisson.Items.Count + 1).ToString() + "|" + a.ToString());
                    }
                    else if (a.GetTypeArticle() == "Alcool")
                    {
                        listBalcool.Items.Add((listBalcool.Items.Count + 1).ToString() + "|" + a.ToString());
                    }
                    else
                    {
                    }
                }
            }
        }

        private void btnAddFormule_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }
    }
}
