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
                        listBentree.Items.Add(a);
                    }
                    else if (a.GetTypeArticle() == "Plat")
                    {
                        listBplat.Items.Add(a);
                    }
                    else if (a.GetTypeArticle() == "Dessert")
                    {
                        listBdessert.Items.Add(a);
                    }
                    else if (a.GetTypeArticle() == "Supplément")
                    {
                        listBsupplement.Items.Add(a);
                    }
                    else if (a.GetTypeArticle() == "Boisson")
                    {
                        listBboisson.Items.Add(a);
                    }
                    else if (a.GetTypeArticle() == "Alcool")
                    {
                        listBalcool.Items.Add(a);
                    }
                    else
                    {
                    }
                }
            }
        }
        public void ClearAll()
        {
            listBentree.ClearSelected();
            listBplat.ClearSelected();
            listBdessert.ClearSelected();
            listBsupplement.ClearSelected();
            listBboisson.ClearSelected();
            listBalcool.ClearSelected();
            txtBNomArticle.Clear();
            txtPrixFormule.Clear();
        }
        private void btnAddFormule_Click(object sender, EventArgs e)
        {
            Article entree = (Article)listBentree.SelectedItem;
            Article plat = (Article)listBplat.SelectedItem;
            Article dessert = (Article)listBdessert.SelectedItem;
            Article supplement = (Article)listBsupplement.SelectedItem;
            Article boisson = (Article)listBboisson.SelectedItem;
            Article alcool = (Article)listBalcool.SelectedItem;

            List<Article> LesArticleSelected = new List<Article>();
            if (entree != null)
            {
                LesArticleSelected.Add(entree);
            }
            if (plat != null)
            {
                LesArticleSelected.Add(plat);
            }
            if (dessert != null)
            {
                LesArticleSelected.Add(dessert);
            }
            if (supplement != null)
            {
                LesArticleSelected.Add(supplement);
            }
            if (boisson != null)
            {
                LesArticleSelected.Add(boisson);
            }
            if (alcool != null)
            {
                LesArticleSelected.Add(alcool);
            }

            bool ConvertOK = float.TryParse(txtPrixFormule.Text, out float PrixFormule);
            if (String.IsNullOrWhiteSpace(txtBNomArticle.Text))
            {
                MessageBox.Show("Veuiller rentré un Nom Valide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrWhiteSpace(txtPrixFormule.Text) || ConvertOK==false || PrixFormule == 0)
            {
                MessageBox.Show("Veuiller rentré un Prix Valide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if ((entree != null && plat != null) || (plat != null && dessert != null))
            {
                if (ORMmySQL.AjouterFormule(LesArticleSelected, txtBNomArticle.Text, PrixFormule)) { 
                    MessageBox.Show("La formule à bien été ajouter", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAll();
                }
                else
                {
                    MessageBox.Show("La formule n'à pas été ajouter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Veuiller selectionner au moin (Entrée/plat) ou (Plat/dessert)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnClearentree_Click(object sender, EventArgs e)
        {
            listBentree.ClearSelected();
        }
        private void btnClearplat_Click(object sender, EventArgs e)
        {
            listBplat.ClearSelected();
        }
        private void btnCleardessert_Click(object sender, EventArgs e)
        {
            listBdessert.ClearSelected();
        }
        private void btnClearsupplement_Click(object sender, EventArgs e)
        {
            listBsupplement.ClearSelected();
        }
        private void btnClearboisson_Click(object sender, EventArgs e)
        {
            listBboisson.ClearSelected();
        }
        private void btnClearalcool_Click(object sender, EventArgs e)
        {
            listBalcool.ClearSelected();
        }
    }
}
