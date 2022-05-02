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
    public partial class frmGestionAddArticle : Form
    {
        public frmGestionAddArticle()
        {
            InitializeComponent();
            String[] TypeArticle = new String[] { "Entrée", "Plat", "Dessert", "Supplément", "Boisson", "Alcool" };
            listBTypeArticle.Items.AddRange(TypeArticle.ToArray());

            ClearTxt();
        }

        public void ClearTxt()
        {
            listBTypeArticle.SelectedItem = null;
            txtBNomArticle.Text = "";
            listBLesArticles.Items.Clear();
            listBLesArticles.Items.AddRange(ORMmySQL.GetAllArticles().ToArray());
        }

        private void btnAddArticle_Click(object sender, EventArgs e)
        {
            String type = (String)listBTypeArticle.SelectedItem;

            if (String.IsNullOrWhiteSpace(txtBNomArticle.Text))
            {
                MessageBox.Show("Veuiller rentré un Nom Valide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (type == null)
            {
                MessageBox.Show("Veuillez sélectionner un type valide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                ORMmySQL.AjouterArticle(txtBNomArticle.Text, type);
                MessageBox.Show("L'Article à bien été ajouter", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTxt();
            }
        }

        private void btnDeleteArticle_Click(object sender, EventArgs e)
        {
            Article article = (Article)listBLesArticles.SelectedItem;

            if (article == null)
            {
                MessageBox.Show("Veuillez sélectionner un article valide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (ORMmySQL.DeleteArticle(article.GetIdArticle()))
                {
                    MessageBox.Show("L'Article à bien été supprimer", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTxt();
                }

            }
        }

        private void btnEditArticle_Click(object sender, EventArgs e)
        {
            if (listBLesArticles.SelectedItem == null)
            {
                MessageBox.Show("Veuillez choisir un article à modifier", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Article a = (Article)listBLesArticles.SelectedItem;
                lblTitleAddEdit.Text = "Modifier l'Article";
                txtBNomArticle.Text = a.GetNomArticle();

                btnAnnulerEdit.Visible = true;
                btnAddArticle.Visible = false;
                btnValidEdit.Location = new Point(192, 263);
                btnValidEdit.Visible = true;
                for (int i = 0; i < listBTypeArticle.Items.Count; i++)
                {
                    if (a.GetTypeArticle().Equals(listBTypeArticle.Items[i]))
                    {
                        listBTypeArticle.SelectedIndex = i;
                        break;
                    }

                }
            }
        }

        private void btnAnnulerEdit_Click(object sender, EventArgs e)
        {
            lblTitleAddEdit.Text = "Ajouter un Article";
            txtBNomArticle.Clear();
            listBTypeArticle.ClearSelected();

            btnAnnulerEdit.Visible = false;
            btnValidEdit.Visible = false;
            btnValidEdit.Location = new Point(192, 297);
            btnAddArticle.Visible = true;
        }

        private void btnValidEdit_Click(object sender, EventArgs e)
        {
            Article a = (Article)listBLesArticles.SelectedItem;
            String newType = (String)listBTypeArticle.SelectedItem;
            String newName = txtBNomArticle.Text;

            bool edit = ORMmySQL.UpdateArticle(a.GetIdArticle(), newName, newType);
            if (edit)
            {
                MessageBox.Show("L'article a bien été modifier", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTxt();
                btnAnnulerEdit_Click("", EventArgs.Empty);
            }
        }

        private void listBLesArticles_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAnnulerEdit_Click("",EventArgs.Empty);
        }
    }
}
