using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            comBoxentree.Items.Add(String.Empty);
            comBoxPlat.Items.Add(String.Empty);
            comBoxDessert.Items.Add(String.Empty);
            comBoxSupp.Items.Add(String.Empty);
            comBoxBoisson.Items.Add(String.Empty);
            comBoxAlcool.Items.Add(String.Empty);

            if (LesAticles != null)
            {
                foreach (Article a in LesAticles)
                {
                    if (a.GetTypeArticle() == "Entrée")
                    {
                        comBoxentree.Items.Add(a);
                    }
                    else if (a.GetTypeArticle() == "Plat")
                    {
                        comBoxPlat.Items.Add(a);
                    }
                    else if (a.GetTypeArticle() == "Dessert")
                    {
                        comBoxDessert.Items.Add(a);
                    }
                    else if (a.GetTypeArticle() == "Supplément")
                    {
                        comBoxSupp.Items.Add(a);
                    }
                    else if (a.GetTypeArticle() == "Boisson")
                    {
                        comBoxBoisson.Items.Add(a);
                    }
                    else if (a.GetTypeArticle() == "Alcool")
                    {
                        comBoxAlcool.Items.Add(a);
                    }
                    else
                    {
                    }
                }
            }
        }
        public void ClearAll()
        {
            comBoxentree.SelectedIndex = -1;
            comBoxPlat.SelectedIndex = -1;
            comBoxDessert.SelectedIndex = -1;
            comBoxSupp.SelectedIndex = -1;
            comBoxBoisson.SelectedIndex = -1;
            comBoxAlcool.SelectedIndex = -1;
            txtBNomArticle.Clear();
            txtPrixFormule.Clear();
            txtBDescFormule.Clear();
            pictureBoxPhoto.Image = null;
        }
        private void btnAddFormule_Click(object sender, EventArgs e)
        {
            Article entree = null;
            Article plat = null;
            Article dessert = null;
            Article supplement = null;
            Article boisson = null;
            Article alcool = null;

            if(comBoxentree.SelectedItem is Article)
            {
                entree = (Article)comBoxentree.SelectedItem;

            }
            if(comBoxPlat.SelectedItem is Article)
            {
                plat = (Article)comBoxPlat.SelectedItem;
            }
            if (comBoxDessert.SelectedItem is Article)
            {
                dessert = (Article)comBoxDessert.SelectedItem;
            }
            if (comBoxSupp.SelectedItem is Article)
            {
                supplement = (Article)comBoxSupp.SelectedItem;
            }
            if (comBoxBoisson.SelectedItem is Article)
            {
                boisson = (Article)comBoxBoisson.SelectedItem;
            }
            if (comBoxAlcool.SelectedItem is Article)
            {
                alcool = (Article)comBoxAlcool.SelectedItem;
            }

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
            else if (String.IsNullOrWhiteSpace(txtPrixFormule.Text) || ConvertOK == false || PrixFormule == 0)
            {
                MessageBox.Show("Veuiller rentré un Prix Valide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (String.IsNullOrWhiteSpace(txtBDescFormule.Text))
            {
                MessageBox.Show("Veuiller rentré une Description Valide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (pictureBoxPhoto.Image == null)
            {
                MessageBox.Show("Veuiller choisir une photo Valide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if ((entree != null && plat != null) || (plat != null && dessert != null))
            {
                MemoryStream ms = new MemoryStream();
                pictureBoxPhoto.Image.Save(ms, pictureBoxPhoto.Image.RawFormat);
                byte[] img = ms.ToArray();

                if (ORMmySQL.AjouterFormule(LesArticleSelected, txtBNomArticle.Text, PrixFormule, txtBDescFormule.Text, img))
                {
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


        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files(*.jpg; *.png;)|*.jpg; *.png;|JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                String PicLoc = dlg.FileName.ToString();
                if (PicLoc.Substring(PicLoc.Length - 4) != ".png" && PicLoc.Substring(PicLoc.Length - 4) != ".jpg")
                {
                    MessageBox.Show("Le Format est incorrect (.png ou .jpg)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    pictureBoxPhoto.Image = Image.FromFile(PicLoc);
                }


            }
        }
    }
}
